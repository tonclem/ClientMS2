using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificationService.Data.Data;
using NotificationService.Data.Models;
using NotificationService.Data;
using NotificationService.Helpers;
using NotificationService.InputOutputData;
using NotificationService.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ClientMicroservice.InputOutputData;

namespace NotificationService.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ClientController: ControllerBase
    {

       
        private readonly AppSettings _appSettings;
        private readonly IClientService _clientService;

        public ClientController(IClientService _clientService, IOptions<AppSettings> appSettings)
        {
            this._clientService = _clientService;
            this._appSettings = appSettings.Value;

        }


        [HttpGet("test")]
        public IActionResult Getx()
        {
           return Ok("Test API is working...");
        }

        [HttpGet("authorization/{key}/valid")]
        public IActionResult GetAuthKey(string key)
        {
            var checker = _clientService.GetAuthorizationKey(key);
            if (checker.Result == true)
            {
                return Ok(true);
            }
            return Ok(false);
        }


        [HttpGet("subscriptionTier")]
        public IActionResult GetSubscriptionTier()
        {

            var res = _clientService.GetsubscriptionTiers();
            if(res.Result != null) {
                return Ok(res.Result);
            }
            return BadRequest(new { message = "Bad Request" });    

        }

        [HttpPost("create")]
        public IActionResult postClient([FromBody] Client client)
        {
            if (ModelState.IsValid)
            {
                var res = _clientService.CreateClient(client);
                return Ok(res.Result);
            }
            return BadRequest(new { message = "All fields required" });
        }



        [HttpPost("clientoutline/create")]
        public IActionResult postClientOutlet([FromBody] ClientOutlet client)
        {
            if (ModelState.IsValid)
            {
                var res = _clientService.CreateClientOutlet(client);
                return Ok(res.Result);
            }
            return BadRequest(new { message = "All fields required" });
        }


        [HttpGet("x")]
        public IActionResult getAllClients()
        {
            var res = _clientService.GetClientsAndDefaultOutlet();
            if (res.Result != null)
            {
                Ok(res.Result);
            }
            return BadRequest();
        }




        [HttpPost("non-member")]
        public IActionResult createNonMember([FromBody] NonNetworkMemInput data)
        {
            if (ModelState.IsValid)
            {
                var res = _clientService.createNonMember(data);
                if (res.Result != null)
                {
                    return Ok(res.Result);
                }
                return BadRequest(new { message = "This client already exists" });

            }
            return BadRequest(new { message = "All fields required" });
        }





        [HttpGet("name/{name}")]
        public IActionResult getClientsByName(string name)
        {
            if (name != null)
            {
                var res = _clientService.GetClientsByName(name);
                if(res.Result != null) { return Ok(res.Result); }
                return Ok(null);
            }
            return BadRequest(new { message = "Name is required" });
        }



        [HttpGet("{clientId}")]
        public IActionResult getClientsById(int clientId)
        {
                var res = _clientService.GetClientsById(clientId);
                if (res.Result != null) { return Ok(res.Result); }
                return Ok(null);
           
        }




        [HttpGet("outlet/state/{stateId}")]
        public IActionResult getClientOutletByState(int stateId)
        {
            var res = _clientService.GetClientOutletByStateId(stateId);
            if (res.Result != null) { return Ok(res.Result); }
            return Ok(null);
           
        }




        [HttpGet("outlet/lga/{lgaId}")]
        public IActionResult getClientOutletByLGA(int lgaId)
        {
            var res = _clientService.GetClientOutletByLGAId(lgaId);
            if (res.Result != null) { return Ok(res.Result); }
            return Ok(null);

            
        }


        [HttpGet("clientType/{clientTypeId}/lat/{latitude}/lon/{longitude}")]
        public IActionResult getClientOutletByProximity(string latitude, string longitude,string clientTypeId)
        {
            if (latitude != null && longitude != null && clientTypeId != null)
            {
                var res = _clientService.GetClientOutletByProximity(latitude, longitude, clientTypeId);
                if (res.Result != null) { return Ok(res.Result); }
                return Ok(null);
            }return BadRequest(new { message = "All fields required" });
           
        }



        [HttpGet("clientType/{clientTypeId}")]
        public IActionResult getClientOutletByClientType(int clientTypeId)
        {
            var res = _clientService.GetClientOutletByClientType(clientTypeId);
            if (res.Result != null) { return Ok(res.Result); }
            return Ok(null);
          
        }


        [Authorize]
        [HttpPost("outlet/bank/update")]
        public IActionResult updateBankingDetails([FromBody]UpdateBankInput bankInput)
        {
            //The username that is logged in is on the token
            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            string username = attachUserToContext(token);

            if (ModelState.IsValid)
            {
                var res = _clientService.UpdateBankingDetails(bankInput,username);
                if (res.Result != null) { return Ok(res.Result); }
                return Ok(null);

            }

            return BadRequest(new { message = "All fields required" });
        }




        [HttpGet("outlet/{clientOutletId}")]
        public IActionResult getOutletsDetails(int clientOutletId)
        {
            var res = _clientService.GetOutletsDetails(clientOutletId);
            if (res.Result != null) { return Ok(res.Result); }
            return Ok(null);
        }




        [HttpGet("{clientauthorizationKey}/outlet/{clientOutletId}/bank")]
        public IActionResult getOutletsBankInfo(string clientauthorizationKey, int clientOutletId)
        {
            
            if(clientauthorizationKey != null)
            {
                var res = _clientService.GetOutletsBankInfo(clientauthorizationKey, clientOutletId);
                if (res.Result != null) { return Ok(res.Result); }
                return Ok(null);
                
            }

            return BadRequest(new ResponseMessage() { message = "UnAuthorized Key", success = 400 });
        }



      




        [Authorize]
        [HttpPost("contactPerson")]
        public IActionResult updateClientContact([FromBody] ContactInput input)
        {
            if (ModelState.IsValid)
            {
                // The username that is logged in is on the token
                var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
                string username = attachUserToContext(token);

                var res = _clientService.UpdateClientContact(input, username);
                if (res.Result) { return Ok(res.Result); }
                return Ok(res.Result);
                
            }
            return BadRequest(new ResponseMessage() { message = "All fields required", success = 400 });
        }



        [HttpGet("y")]
        public async Task<IActionResult> getToken()
        {

            var token = Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            string username = attachUserToContext(token);
            Console.WriteLine("Hello people of the world oooooo");

            Console.WriteLine(username);

            if (token != null)
            {
                return Ok(new { message = username });

            }

            return BadRequest(new ResponseMessage() { message = "Empty Token", success = 400 });
        }


        [Authorize]
        [HttpGet("z")]
        public async Task<IActionResult> getX()
        {
            return Ok(new ResponseMessage() { message = "All Token", success = 200 });
        }


      


        [HttpPost("clienttype")]
        public IActionResult addClientType([FromBody]ClientType client)
        {
            if (ModelState.IsValid)
            {
                var res = _clientService.AddClientType(client);
                if (res.Result != null) { return Ok(res.Result); }
                return Ok(null);
            }
            return BadRequest(new ResponseMessage() { message = "All fields required", success = 400 });
        }

        [HttpGet("clienttype")]
        public IActionResult getClientType()
        {
            var res = _clientService.GetAllClientTypes();
            if (res.Result != null) { return Ok(res.Result); }
            return Ok(null);
            
        }



        private string attachUserToContext(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                //var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "username").Value);
                var username = jwtToken.Claims.First(x => x.Type == "username").Value;

                return username;
                // attach user to context on successful jwt validation
                //context.Items["User"] = userService.GetById(username);
            }
            catch
            {
                // do nothing if jwt validation fails
                // user is not attached to context so request won't have access to secure routes
            }

            return null;
        }

    }



    //public class TierOutput
    //{

    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public bool isDeleted { get; set; }
    //    public double price { get; set; }
    //    public List<SubscriptionTierFeature> tierList { get; set; }
    //}




}
