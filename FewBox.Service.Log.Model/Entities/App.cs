using FewBox.Core.Persistence.Orm;
using System;

namespace FewBox.Service.Log.Model.Entities
{
    public class App : Entity<Guid>
    {
        public string Name { get; set; }
    }
}
   