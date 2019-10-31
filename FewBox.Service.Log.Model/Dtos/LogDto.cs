using FewBox.Core.Web.Dto;
using System;

namespace FewBox.Service.Log.Model.Dtos
{
    public class LogDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Param { get; set; }
    }
}