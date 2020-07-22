using EzyFindMobileApi.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EzyFindMobileApi.General
{
    public static class JwtExtensions
    {
        public static void GenerateToken(this MstUsers user, IConfiguration configuration)
        {
            try
            {
                MstUserRole mstUserRole = user.Role;
                var token = new JwtTokenBuilder()
                                .AddSecurityKey(JwtSecurityKey.Create(configuration.GetValue<string>("JwtSecretKey")))
                                .AddIssuer(configuration.GetValue<string>("JwtIssuer"))
                                .AddAudience(configuration.GetValue<string>("JwtAudience"))
                                .AddExpiry(90)
                                .AddClaim("Id", user.UserId.ToString())
                                .AddRole(mstUserRole.RoleName)
                                .Build();

                user.Token = token.Value;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
