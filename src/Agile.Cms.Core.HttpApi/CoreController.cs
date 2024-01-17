using Agile.Cms.Core.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Agile.Cms.Core;

public abstract class CoreController : AbpControllerBase
{
    protected CoreController()
    {
        LocalizationResource = typeof(CoreResource);
    }
}
