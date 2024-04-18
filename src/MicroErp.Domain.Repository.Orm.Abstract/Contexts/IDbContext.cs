﻿using MicroErp.Domain.Entity.Bases;
using Microsoft.EntityFrameworkCore;

namespace MicroErp.Domain.Repository.Orm.Abstract.Contexts;

public interface IDbContext
{
    DbSet<T> Set<T>() where T : BaseEntity;
    EntityState Entry<T>(T entity) where T : BaseEntity;
    Task<int> SaveChangeAsync(CancellationToken cancellationToken = default);
    Task SaveChangesAsync(CancellationToken cancellationToken);
}