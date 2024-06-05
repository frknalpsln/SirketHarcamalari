using Harcama.DataAccess.Services;
using Harcama.Entities.Concrete;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.DataAccess.Services.Concrete
{
    public class JwtProvider : IJwtProvider
    {
        public string CreateToken(AppUser user)
        {
            List<Claim> claims = new()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Adi),
                new Claim(ClaimTypes.Surname, user.Soyadi),
                new Claim("UserName", user.UserName),

            };
            DateTime expires = DateTime.Now.AddDays(1);

            SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(string.Join("-" , Guid.NewGuid(),Guid.NewGuid(), Guid.NewGuid())));
            SigningCredentials signingCredentials = new(securityKey , SecurityAlgorithms.HmacSha512);

            JwtSecurityToken securityToken = new(
                        issuer: "Furkan Alpaslan",
                        audience: "Şirket Yönetim",
                        claims: claims,
                        notBefore: DateTime.Now,
                        expires: expires,
                        signingCredentials: signingCredentials
                        );

            JwtSecurityTokenHandler handler = new();
            string token = handler.WriteToken(securityToken);

            return token;
        }
    }
}
