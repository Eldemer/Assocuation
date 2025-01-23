using Assocuation.Samples;
using Xunit;

namespace Assocuation.EntityFrameworkCore.Domains;

[Collection(AssocuationTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AssocuationEntityFrameworkCoreTestModule>
{

}
