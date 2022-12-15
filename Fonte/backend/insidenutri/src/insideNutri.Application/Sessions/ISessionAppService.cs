using System.Threading.Tasks;
using Abp.Application.Services;
using insideNutri.Sessions.Dto;

namespace insideNutri.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
