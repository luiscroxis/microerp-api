﻿namespace MicroErp.Domain.Entity.Bases;

public class PaginatedMetaDataEntity
{
    public int TotalItems { get; set; }
    public int TotalPages { get; set; }
    public int PageSize { get; set; }
    public int PageNumber { get; set; }
    public bool HasPreviousPage => PageNumber > 1;
    public bool HasNextPage => PageNumber < TotalPages;
}