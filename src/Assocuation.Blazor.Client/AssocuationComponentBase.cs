using Assocuation.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Assocuation.Blazor.Client;

public abstract class AssocuationComponentBase : AbpComponentBase
{
    protected AssocuationComponentBase()
    {
        LocalizationResource = typeof(AssocuationResource);
    }
}
