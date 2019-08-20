using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ASTMgmt.ViewModels;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace ASTMgmt.BusinessLogic
{
    public class LoginBL
    {
        public LoginViewModel Authenticate(LoginViewModel loginviewModel)
        {
            try
            {
                if (string.IsNullOrEmpty(loginviewModel.UserId.Trim()) || string.IsNullOrEmpty(loginviewModel.Password.Trim()))
                {
                    loginviewModel.RequestMessage.CreateErrorResponse(HttpStatusCode.Unauthorized, "Invalid UserId or Password");
                    return loginviewModel;
                }
                // remove below check and validate pwd and uid with database
                else if (loginviewModel.UserId.Trim() != "Admin" && loginviewModel.Password.Trim() != "")
                {
                    loginviewModel.RequestMessage.CreateErrorResponse(HttpStatusCode.Unauthorized, "Invalid UserId or Password");
                    return loginviewModel;
                }

                loginviewModel.RequestMessage.CreateResponse(HttpStatusCode.OK);

                loginviewModel.Token = CreateToken( loginviewModel);

                loginviewModel.Password = "";
                loginviewModel.InformationMessage = "Authentication successful";

                return loginviewModel;
            }
            catch (Exception ex)
            {
                loginviewModel.RequestMessage.CreateErrorResponse(HttpStatusCode.Unauthorized, ex);
                return loginviewModel;

            }

        }

        private string CreateToken(LoginViewModel loginviewModel)
        {
            DateTime IssueAt = DateTime.Now;
            DateTime ExpiredAt = DateTime.Now.AddDays(1);

            //create a identity and add claims to the user which we want to log in
            //Represents a claims-based identity.
            //There are two common authorization approaches that are based on Role and Claim.
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, loginviewModel.UserId)
            });


            var securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(System.Text.Encoding.Default.GetBytes(Constants.SecKey));
            //Represents the cryptographic key and security algorithms that are used to generate a digital signature.
            var signingCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(securityKey, Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha256Signature);

            var tokenHandler = new JwtSecurityTokenHandler();
            var token =
             (JwtSecurityToken)
                 tokenHandler.CreateJwtSecurityToken(audience: "http://rajeshjbhawsar.com", issuer: "http://google.com",
                     subject: claimsIdentity, notBefore: IssueAt, expires: ExpiredAt, signingCredentials: signingCredentials);

            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
                        
        }
    }
}