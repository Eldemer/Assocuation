using Volo.Abp.Modularity;

namespace Assocuation;

/* Inherit from this class for your domain layer tests. */
public abstract class AssocuationDomainTestBase<TStartupModule> : AssocuationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
