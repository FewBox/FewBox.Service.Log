﻿using FewBox.Service.Log.Model.Entities;
using FewBox.Core.Persistence.Orm;
using System;

namespace FewBox.Service.Log.Model.Repositories
{
    public interface IExceptionLogRepository : IBaseRepository<ExceptionLog, Guid>
    {
    }
}