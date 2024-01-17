using Agile.Cms.Core.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Agile.Cms.Core.Pages;

public abstract class CorePageModel : AbpPageModel
{
    protected CorePageModel()
    {
        LocalizationResourceType = typeof(CoreResource);
    }
}
