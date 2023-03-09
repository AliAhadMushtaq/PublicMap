using System.Threading.Tasks;
using Abp.Application.Services;
using Maps.Authorization.Accounts.Dto;

namespace Maps.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
