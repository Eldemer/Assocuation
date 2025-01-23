using Volo.Abp.Modularity;

namespace Assocuation;

[DependsOn(
    typeof(AssocuationApplicationModule),
    typeof(AssocuationDomainTestModule)
)]
public class AssocuationApplicationTestModule : AbpModule
{

}
