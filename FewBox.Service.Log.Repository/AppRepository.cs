using Dapper;
using FewBox.Service.Log.Model.Entities;
using FewBox.Service.Log.Model.Repositories;
using FewBox.Core.Persistence.Orm;
using System;

namespace FewBox.Service.Log.Repository
{
    public class AppRepository : BaseRepository<App, Guid>, IAppRepository
    {
        public AppRepository(IOrmSession ormSession, ICurrentUser<Guid> currentUser) 
        : base("app", ormSession, currentUser)
        {
        }

        protected override string GetSaveSegmentSql()
        {
            return "Name";
        }

        protected override string GetUpdateSegmentSql()
        {
            return "Name";
        }

        protected override string GetUpdateWithUniqueKeyWhereSegmentSql()
        {
            throw new NotImplementedException();
        }
    }
}