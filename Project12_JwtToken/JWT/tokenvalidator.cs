using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Project12_JwtToken.JWT
{
    public class tokenvalidator
    {
        public ClaimsPrincipal validateJWTToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
           
            var key=Encoding.UTF8.GetBytes("20derste20projetoken??74burakhanulusoysecurity");

            try
            {
                var principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidIssuer = "localhost", // Yayıncı
                    ValidateAudience = true,
                    ValidAudience = "localhost", // Dinleyici
                    ValidateLifetime = true, // Token süresini kontrol et
                    ClockSkew = TimeSpan.Zero // Token süresi bitiminden sonra 0 saniye bekle
                }, out SecurityToken validatedToken);
                return principal;
            }
            catch
            {
                return null; // Token geçersizse null döndür
            }



        }   





    }
}
