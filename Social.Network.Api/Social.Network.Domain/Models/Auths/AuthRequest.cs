using System.ComponentModel.DataAnnotations;


/**
* @author HariLab
* @date - 8/11/2021 1:25:29 PM 
*/

namespace Social.Network.Domain.Models.Auths
{
    public class AuthRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
