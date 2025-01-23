using Assocuation.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Assocuation.Blazor;

public abstract class AssocuationComponentBase : AbpComponentBase
{
    protected AssocuationComponentBase()
    {
        LocalizationResource = typeof(AssocuationResource);
    }
}
