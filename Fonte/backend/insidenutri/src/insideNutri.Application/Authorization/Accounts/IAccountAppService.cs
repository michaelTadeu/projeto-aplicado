using System.Threading.Tasks;
using Abp.Application.Services;
using insideNutri.Authorization.Accounts.Dto;

namespace insideNutri.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
