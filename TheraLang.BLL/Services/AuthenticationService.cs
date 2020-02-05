using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class AuthenticationService : IAuthenticateService
    {
        private readonly TokenManagement _tokenManagement;
        private readonly IHttpContextAccessor _context;


        public AuthenticationService(IOptions<TokenManagement> tokenManagement, IHttpContextAccessor context)
        {
            _tokenManagement = tokenManagement.Value;
            _context = context;
        }
        public bool IsAuthenticated(out string token, User user)
        {

            token = string.Empty;

            var claim = new[]
            {
                new Claim("Id", user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, user.Role.NormalizedName)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenManagement.Secret));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var jwtToken = new JwtSecurityToken(
                _tokenManagement.Issuer,
                _tokenManagement.Audience,
                claim,
                expires: DateTime.Now.AddMinutes(_tokenManagement.AccessExpiration),
                signingCredentials: credentials
            );
            token = new JwtSecurityTokenHandler().WriteToken(jwtToken);
            return true;

        }

        public Task<AuthUser> GetAuthUserAsync()
        {
            return Task.Run(() =>
            {
                var claims = _context.HttpContext.User.Claims;
                var userId = claims.FirstOrDefault(x => x.Type == "Id")?.Value;
                if (userId == null)
                {
                    return null;
                }
                var userName = claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;
                var userRole = claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value;

                return new AuthUser()
                {
                    Id = new Guid(userId),
                    UserName = userName,
                    Role = userRole
                };
            });

        }
    }
}
