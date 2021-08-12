using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Social.Network.Domain.Models;
using Social.Network.Domain.Models.Auths;
using Social.Network.Domain.Queries;
using Social.Network.Domain.Services;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;


/**
* @author HariLab
* @date - 8/11/2021 1:28:25 PM 
*/

namespace Social.Network.Application.Services
{
    public class UserService : IUserService
    {
        #region Private Members

        private readonly OAuthIdentity oAuthIdentity;
        private readonly IQueryRepository query;

        #endregion

        #region Constructor


        public UserService(IOptions<OAuthIdentity> oAuthIdentity, IQueryRepository query)
        {
            this.oAuthIdentity = oAuthIdentity.Value;
            this.query = query;
        }

        #endregion

        public AuthResponse Authenticate(AuthRequest model)
        {
            var user = query.GetUsers().SingleOrDefault(x => x.Username == model.Username && x.Password == model.Password);

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = GenerateJwtToken(user);

            return new AuthResponse(user, token);
        }

        #region Private Helpers

        /// <summary>
        /// Generate token for users
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private string GenerateJwtToken(Users user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(oAuthIdentity.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.ID.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        } 

        #endregion
    }
}
