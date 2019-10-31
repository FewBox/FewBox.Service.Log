using FewBox.Core.Persistence.Orm;
using System;

namespace FewBox.Service.Log.Model.Entities
{
    public abstract class Log : Entity<Guid>
    {
        public string Name { get; set; }
        public string Param { get; set; }
    }
}