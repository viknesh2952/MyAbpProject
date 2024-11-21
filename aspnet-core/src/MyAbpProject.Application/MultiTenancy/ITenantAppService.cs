using Abp.Application.Services;
using MyAbpProject.MultiTenancy.Dto;

namespace MyAbpProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

