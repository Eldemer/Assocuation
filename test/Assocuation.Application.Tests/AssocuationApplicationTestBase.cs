using Volo.Abp.Modularity;

namespace Assocuation;

public abstract class AssocuationApplicationTestBase<TStartupModule> : AssocuationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
