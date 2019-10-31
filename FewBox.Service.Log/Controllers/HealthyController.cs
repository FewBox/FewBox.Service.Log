using FewBox.Service.Log.Model.Dtos;
using FewBox.Core.Web.Dto;
using Microsoft.AspNetCore.Mvc;
using FewBox.Service.Log.Model.Configs;

namespace FewBox.Service.Log.Controllers
{
    [Route("api/[controller]")]
    public class HealthyController : ControllerBase
    {
        private HealthyConfig HealthyConfig { get; set; }

        public HealthyController(HealthyConfig healthyConfig)
        {
            this.HealthyConfig = healthyConfig;
        }

        [HttpGet]
        public PayloadResponseDto<HealthyDto> Get()
        {
            return new PayloadResponseDto<HealthyDto>
            {
                Payload = new HealthyDto
                {
                    Version = this.HealthyConfig.Version
                }
            };
        }
    }
}
