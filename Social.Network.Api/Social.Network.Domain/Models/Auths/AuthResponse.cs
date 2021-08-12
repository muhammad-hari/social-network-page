using System;
using System.Collections.Generic;
using System.Text;


/**
* @author HariLab
* @date - 8/11/2021 1:24:37 PM 
*/

namespace Social.Network.Domain.Models.Auths
{
    public class AuthResponse
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }


        public AuthResponse(Users user, string token)
        {
            Id = user.ID;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.Username;
            Token = token;
        }
    }
}
