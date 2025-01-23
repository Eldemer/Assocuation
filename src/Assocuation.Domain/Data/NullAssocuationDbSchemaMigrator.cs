using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Assocuation.Data;

/* This is used if database provider does't define
 * IAssocuationDbSchemaMigrator implementation.
 */
public class NullAssocuationDbSchemaMigrator : IAssocuationDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
