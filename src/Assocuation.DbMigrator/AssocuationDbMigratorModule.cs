using Assocuation.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Assocuation.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AssocuationEntityFrameworkCoreModule),
    typeof(AssocuationApplicationContractsModule)
    )]
public class AssocuationDbMigratorModule : AbpModule
{
}
