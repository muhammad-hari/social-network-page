using Social.Network.Domain.Models;
using System.Collections.Generic;


/**
* @author HariLab
* @date - 8/11/2021 1:33:35 AM 
*/

namespace Social.Network.Domain.Seeds
{
    public interface IDataSeeds
    {
        List<Users> UserList();
        List<People> PeopleList();
        List<Documents> DocumentList();
        List<Videos> VideoList();
        List<Channels> ChannelList();
        List<Activities> ActivityList();
    }
}
