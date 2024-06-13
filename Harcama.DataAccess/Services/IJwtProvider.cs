using Harcama.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Harcama.DataAccess.Services
{
    public interface IJwtProvider
    {
        Task<string> CreateToken(AppUser user);
        
    }
}
