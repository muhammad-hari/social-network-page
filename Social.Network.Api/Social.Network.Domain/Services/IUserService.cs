using Social.Network.Domain.Models;
using Social.Network.Domain.Models.Auths;
using System;
using System.Collections.Generic;
using System.Text;


/**
* @author HariLab
* @date - 8/11/2021 1:23:34 PM 
*/

namespace Social.Network.Domain.Services
{
    public interface IUserService
    {
        AuthResponse Authenticate(AuthRequest model);
    }
}
