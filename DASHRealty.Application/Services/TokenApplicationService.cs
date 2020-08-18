using DASHRealty.Application.DTOs;
using DASHRealty.Application.Interfaces;
using DASHRealty.Domain;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DASHRealty.Application.Services
{
    public class TokenApplicationService : ITokenApplicationService
    {
        public string GenerateToken(UserDTO userDTO)
        {
            try
            {
                var key = Encoding.ASCII.GetBytes(Settings.Secret);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[] {
                new Claim(ClaimTypes.Email,userDTO.Email.ToString())
                }),
                    Expires = DateTime.UtcNow.AddHours(2),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                var tokenHandler = new JwtSecurityTokenHandler();

                var token = tokenHandler.CreateToken(tokenDescriptor);

                return tokenHandler.WriteToken(token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
