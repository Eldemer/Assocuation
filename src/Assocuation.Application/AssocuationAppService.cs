using System;
using System.Collections.Generic;
using System.Text;
using Assocuation.Localization;
using Volo.Abp.Application.Services;

namespace Assocuation;

/* Inherit your application services from this class.
 */
public abstract class AssocuationAppService : ApplicationService
{
    protected AssocuationAppService()
    {
        LocalizationResource = typeof(AssocuationResource);
    }
}
