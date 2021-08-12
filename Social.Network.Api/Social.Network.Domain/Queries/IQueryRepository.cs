using Social.Network.Domain.Models;
using System.Collections.Generic;

/**
* @author HariLab
* @date - 8/11/2021 12:37:53 AM 
*/

namespace Social.Network.Domain.Queries
{
    public interface IQueryRepository
    {
        IEnumerable<People> GetPeople();
        IEnumerable<Documents> GetDocuments();
        IEnumerable<Channels> GetChannels();
        IEnumerable<Videos> GetVideos();
        IEnumerable<Activities> GetActivities();
        IEnumerable<Users> GetUsers();
        Users GetUser(int id);
    }
}
