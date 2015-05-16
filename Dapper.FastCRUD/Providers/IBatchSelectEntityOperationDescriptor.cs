namespace Dapper.FastCrud.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    internal interface IBatchSelectEntityOperationDescriptor<TEntity>:IOperationDescriptor<TEntity>
    {
        IEnumerable<TEntity> Execute(
            IDbConnection connection,
            FormattableString whereClause = null,
            FormattableString orderClause = null,
            int? skipRowsCount = null,
            int? limitRowsCount = null,
            object queryParameters = null,
            bool streamResults = false,
            IDbTransaction transaction = null,
            TimeSpan? commandTimeout = null);
    }
}