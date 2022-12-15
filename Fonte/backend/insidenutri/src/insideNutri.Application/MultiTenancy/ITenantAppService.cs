using Abp.Application.Services;
using insideNutri.MultiTenancy.Dto;

namespace insideNutri.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

