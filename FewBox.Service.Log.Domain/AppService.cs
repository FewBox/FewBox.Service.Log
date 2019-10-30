using FewBox.Service.Log.Model.Configs;
using FewBox.Service.Log.Model.Dtos;
using FewBox.Service.Log.Model.Services;

namespace FewBox.Service.Log.Domain
{
    public class AppService : IAppService
    {
        private HealthyConfig HealthyConfig { get; set; }
        public AppService(HealthyConfig healthyConfig)
        {
            this.HealthyConfig = healthyConfig;
        }

        public HealthyDto GetHealtyInfo()
        {
            return new HealthyDto{
                Version = this.HealthyConfig.Version
            };
        }
    }
}