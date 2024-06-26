﻿using System.Linq.Expressions;

namespace MicroErp.Infra.Data.Repository.Orm.Filter;

internal class ExpressionParser
{
    public WhereClause Criteria { get; set; }
    public Expression FieldToFilter { get; set; }
    public Expression FilterBy { get; set; }
}
