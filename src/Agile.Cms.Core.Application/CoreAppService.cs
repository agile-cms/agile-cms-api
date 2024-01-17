using Agile.Cms.Core.Localization;
using Volo.Abp.Application.Services;

namespace Agile.Cms.Core;

public abstract class CoreAppService : ApplicationService
{
    protected CoreAppService()
    {
        LocalizationResource = typeof(CoreResource);
        ObjectMapperContext = typeof(CoreApplicationModule);
    }
}
