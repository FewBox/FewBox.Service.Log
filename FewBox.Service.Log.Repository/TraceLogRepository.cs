using Dapper;
using FewBox.Service.Log.Model.Entities;
using FewBox.Service.Log.Model.Repositories;
using FewBox.Core.Persistence.Orm;
using System;

namespace FewBox.Service.Log.Repository
{
    public class TraceLogRepository : BaseRepository<TraceLog, Guid>, ITraceLogRepository
    {
        public TraceLogRepository(IOrmSession ormSession, ICurrentUser<Guid> currentUser) 
        : base("tracelog", ormSession, currentUser)
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