using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Providers.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
