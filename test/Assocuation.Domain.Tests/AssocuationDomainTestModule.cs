using Volo.Abp.Modularity;

namespace Assocuation;

[DependsOn(
    typeof(AssocuationDomainModule),
    typeof(AssocuationTestBaseModule)
)]
public class AssocuationDomainTestModule : AbpModule
{

}
