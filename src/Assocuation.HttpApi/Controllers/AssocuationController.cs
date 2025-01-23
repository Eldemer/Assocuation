using Assocuation.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Assocuation.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AssocuationController : AbpControllerBase
{
    protected AssocuationController()
    {
        LocalizationResource = typeof(AssocuationResource);
    }
}
