using System;
using System.Collections.Generic;
using System.Text;


/**
* @author HariLab
* @date - 8/11/2021 12:22:47 AM 
*/

namespace Social.Network.Domain.Models
{
    public class People
    {
        public int? ID { get; set; }
        public int? UserId { get; set; }
        public string Title { get; set; }
        public Users Users { get; set; }
        public string FullName
        {
            get
            {
                return $"{Users.FirstName} {Users.LastName}";
            }
        }

    }
}
