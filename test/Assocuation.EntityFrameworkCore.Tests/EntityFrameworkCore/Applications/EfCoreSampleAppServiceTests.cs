using Assocuation.Samples;
using Xunit;

namespace Assocuation.EntityFrameworkCore.Applications;

[Collection(AssocuationTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AssocuationEntityFrameworkCoreTestModule>
{

}
