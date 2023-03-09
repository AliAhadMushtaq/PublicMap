using System.Threading.Tasks;
using Abp.Application.Services;
using Maps.Sessions.Dto;

namespace Maps.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
