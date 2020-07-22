using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
//https://medium.com/@engr.mmohsin/asp-net-core-2-0-webapi-jwt-role-based-authentication-authorization-with-custom-tables-and-identity-401c898d9ef1
//https://github.com/mohsin91/NetCore2JWTRoleBasedAuth/blob/master/NetCoreWebApi/DTOs/UserDTO.cs

namespace EzyFindMobileApi.General
{
    public sealed class JwtToken
    {
        private JwtSecurityToken token;

        internal JwtToken(JwtSecurityToken token)
        {
            this.token = token;
        }

        public DateTime ValidTo => token.ValidTo;
        public string Value => new JwtSecurityTokenHandler().WriteToken(this.token);
    }
}
