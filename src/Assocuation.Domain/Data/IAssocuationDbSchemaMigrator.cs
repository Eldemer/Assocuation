using System.Threading.Tasks;

namespace Assocuation.Data;

public interface IAssocuationDbSchemaMigrator
{
    Task MigrateAsync();
}
