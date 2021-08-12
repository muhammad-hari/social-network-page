using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


/**
* @author HariLab
* @date - 8/11/2021 12:34:14 AM 
*/

namespace Social.Network.Domain.Models
{
    public class Users
    {
        public int? ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string ImageUrl { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
