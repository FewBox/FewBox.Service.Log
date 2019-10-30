using FewBox.Service.Log.Model.Dtos;

namespace FewBox.Service.Log.Model.Services
{
    public interface IAppService
    {
        HealthyDto GetHealtyInfo();
    }
}