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
    public class tokengenerator
    {

        public string jwtGenerateToken(string username,string email,string name,string surname)
        {

            var securityKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes("20derste20projetoken??74burakhanulusoysecurity"));//imza
            var credentials =new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);//şifre alg

            var claimseee = new[]//token paramaetreleri
            {
                new Claim(JwtRegisteredClaimNames.Sub,username),//sub id için kullanılır
                new Claim(JwtRegisteredClaimNames.Email,email),
                new Claim(JwtRegisteredClaimNames.GivenName,name),
                new Claim(JwtRegisteredClaimNames.FamilyName,surname),



                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };

            var token= new JwtSecurityToken(
                issuer: "localhost",//yayınlayıcı
                audience: "localhost",//dinleyici
                claims: claimseee,
                expires: DateTime.Now.AddMinutes(5), // Token geçerlilik süresi
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);




        }
        public string jwtGenerateToken2(string username)
        {

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("20derste20projetoken??74burakhanulusoysecurity"));//imza
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);//şifre alg

            var claimseee = new[]//token paramaetreleri
            {
                new Claim(JwtRegisteredClaimNames.Sub,username),//sub id için kullanılır
    

                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: "localhost",//yayınlayıcı
                audience: "localhost",//dinleyici
                claims: claimseee,
                expires: DateTime.Now.AddMinutes(5), // Token geçerlilik süresi
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);




        }



    }
}
