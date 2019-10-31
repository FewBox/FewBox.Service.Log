using Dapper;
using FewBox.Service.Log.Model.Entities;
using FewBox.Service.Log.Model.Repositories;
using FewBox.Core.Persistence.Orm;
using System;

namespace FewBox.Service.Log.Repository
{
    public class ExceptionLogRepository : BaseRepository<ExceptionLog, Guid>, IExceptionLogRepository
    {
        public ExceptionLogRepository(IOrmSession ormSession, ICurrentUser<Guid> currentUser) 
        : base("exceptionlog", ormSession, currentUser)
        {
        }

        protected override string GetSaveSegmentSql()
        {
            return "Name, Param";
        }

        protected override string GetUpdateSegmentSql()
        {
            return "Name, Param";
        }

        protected override string GetUpdateWithUniqueKeyWhereSegmentSql()
        {
            throw new NotImplementedException();
        }
    }
}