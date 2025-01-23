using Microsoft.Extensions.Localization;
using Assocuation.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Assocuation.Blazor.Client;

[Dependency(ReplaceServices = true)]
public class AssocuationBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AssocuationResource> _localizer;

    public AssocuationBrandingProvider(IStringLocalizer<AssocuationResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
