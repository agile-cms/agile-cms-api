using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Agile.Cms.Core.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
