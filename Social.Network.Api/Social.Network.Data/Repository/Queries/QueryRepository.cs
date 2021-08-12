using Microsoft.Extensions.Options;
using Social.Network.Domain.Models;
using Social.Network.Domain.Models.Databases;
using Social.Network.Domain.Queries;
using Social.Network.Domain.Seeds;
using System.Collections.Generic;
using System.Linq;
/**
* @author HariLab
* @date - 8/11/2021 12:39:35 AM 
*/
namespace Social.Network.Data.Repository.Queries
{
    public class QueryRepository : IQueryRepository
    {

        #region Private Members

        private readonly IOptions<ConnectionStrings> options;
        private readonly IDataSeeds seeds;

        #endregion

        #region Constructor

        public QueryRepository(IOptions<ConnectionStrings> options, IDataSeeds seeds)
        {
            this.options = options;
            this.seeds = seeds;
        }

        #endregion

        #region People

        public IEnumerable<People> GetPeople() => seeds.PeopleList();

        #endregion

        #region Channels

        public IEnumerable<Channels> GetChannels() => seeds.ChannelList();

        #endregion

        #region Documents

        public IEnumerable<Documents> GetDocuments() => seeds.DocumentList();

        #endregion

        #region Videos

        public IEnumerable<Videos> GetVideos() => seeds.VideoList();

        #endregion

        #region Activities

        public IEnumerable<Activities> GetActivities() => seeds.ActivityList();

        #endregion

        #region Users

        public IEnumerable<Users> GetUsers() => seeds.UserList();
        public Users GetUser(int id) => seeds.UserList().Where(x => x.ID == id).SingleOrDefault();
     

        #endregion

    }
}
