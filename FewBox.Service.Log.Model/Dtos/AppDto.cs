using FewBox.Core.Web.Dto;
using System;

namespace FewBox.Service.Log.Model.Dtos
{
    public class AppDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}