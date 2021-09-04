using NotificationService.Data.Data;
using NotificationService.Data.Models;
using NotificationService.Data;
using NotificationService.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using WebApi.Helpers;
using WebApi.Models;

namespace WebApi.Services
{
    public interface IUserService
    {
        //Task<AuthenticateResponse> Authenticate(AuthenticateRequest model);
       // AuthenticateResponse Authenticate(TokenServices.Core.Models.User model);
        //IEnumerable<User> GetAll();
        Task<User2> GetById(string username);
    }

    public class UserService : IUserService
    {
      
        
        private readonly AppSettings _appSettings;
        private readonly DBNewContext myDatabaseContext2;

        public UserService(IOptions<AppSettings> appSettings, DBNewContext myDatabaseContext2)
        {
            _appSettings = appSettings.Value;
            this.myDatabaseContext2 = myDatabaseContext2;
            
        }



    


       


        public async Task<User2> GetById(string username)
        {
            var model = await myDatabaseContext2.UserData.FirstOrDefaultAsync(o => o.Username == username);
            User2 user1 = new User2 { FirstName = model.Firstname, LastName = model.Lastname, Username = model.Username, Password = model.Password };
            Console.WriteLine("We are in Header now ....");
            Console.WriteLine(user1.Username);
            Console.WriteLine(user1);
            return user1;
        }


      

        private string generateJwtToken(User2 user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("username", user.Username) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        //Task<User> IUserService.GetById(string username)
        //{
        //    throw new NotImplementedException();
        //}
    }
}