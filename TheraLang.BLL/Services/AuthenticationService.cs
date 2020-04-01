using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using Common.Configurations;

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
        public async Task<string> Authenticate(User user)
        {
            if (user.Role.Name != "Unconfirmed" && user.Role.Name != "Blocked")
            {
                return await Task.Run(() =>
                {
                    var claim = new[]
                    {
                    new Claim("Id", user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, user.Role.Name)
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
                    var token = new JwtSecurityTokenHandler().WriteToken(jwtToken);
                    return token;
                });
            }
            return null;
        }
        public async Task<AuthUser> GetAuthUser()
        {
            return await TryGetAuthUser() ?? throw new Exception($"Error while getting user id from token");
        }

        public async Task<AuthUser> TryGetAuthUser()
        {
            return await Task.Run(() =>
            {
                var claims = _context.HttpContext.User.Claims;
                var userId = claims.FirstOrDefault(x => x.Type == "Id")?.Value;
                var userEmail = claims.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;
                var userRole = claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value;

                if (userId == null || userEmail == null || userRole == null)
                {
                    return null;
                }

                return new AuthUser()
                {
                    Id = new Guid(userId),
                    UserEmail = userEmail,
                    Role = userRole
                };
            });
        }
    }
}