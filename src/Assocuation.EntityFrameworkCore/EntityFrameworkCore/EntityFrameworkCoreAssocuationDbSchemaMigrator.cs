using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Assocuation.Data;
using Volo.Abp.DependencyInjection;

namespace Assocuation.EntityFrameworkCore;

public class EntityFrameworkCoreAssocuationDbSchemaMigrator
    : IAssocuationDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAssocuationDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the AssocuationDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AssocuationDbContext>()
            .Database
            .MigrateAsync();
    }
}
