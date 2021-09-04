using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotificationService.Data.Data;
using NotificationService.Data.Models;
using NotificationService.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;




namespace NotificationService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController2 : ControllerBase
    {

        private readonly MyDatabaseContext _context;
        public ClientController2(MyDatabaseContext myDatabaseContext)
        {
            this._context = myDatabaseContext;
        }

        


       


        [HttpPost("postTier")]
        public async Task<IActionResult> addSub(SubscriptionTier subscriptionTier)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subscriptionTier);
                await _context.SaveChangesAsync();
                return Ok(subscriptionTier);
            }
            return BadRequest(new ResponseMessage() { message = "All fields required", success = 400 });
        }



        [HttpPost("test/createState")]
        public async Task<IActionResult> createState(State state)
        {
            if (ModelState.IsValid)
            {
                _context.Add(state);
                await _context.SaveChangesAsync();
                return Ok(state);
            }
            return BadRequest(new ResponseMessage() { message = "All fields required", success = 400 });
        }


        [HttpPost("test/createCountry")]
        public async Task<IActionResult> createCountry(Country country)
        {
            if (ModelState.IsValid)
            {
                _context.Add(country);
                await _context.SaveChangesAsync();
                return Ok(country);
            }
            return BadRequest(new ResponseMessage() { message = "All fields required", success = 400 });
        }


        [HttpPost("test/createLGA")]
        public async Task<IActionResult> createLGA(LocalGovernmentArea lga)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lga);
                await _context.SaveChangesAsync();
                return Ok(lga);
            }
            return BadRequest(new ResponseMessage() { message = "All fields required", success = 400 });
        }


        [HttpPost("test/createAdress")]
        public async Task<IActionResult> createAddress(Address address)
        {
            if (ModelState.IsValid)
            {
                _context.Add(address);
                await _context.SaveChangesAsync();
                return Ok(address);
            }
            return BadRequest(new ResponseMessage() { message = "All fields required", success = 400 });
        }


        [HttpPost("test/updateAdress")]
        public async Task<IActionResult> updateAddress(Address address)
        {
            if (ModelState.IsValid)
            {
                address.LocalGovtId = 2;
                _context.Update(address);
                await _context.SaveChangesAsync();
                return Ok(address);
            }
            return BadRequest(new ResponseMessage() { message = "All fields required", success = 400 });
        }


        [HttpPost("test/createClientOutlet")]
        public async Task<IActionResult> createClientOutlet(ClientOutlet outlet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(outlet);
                await _context.SaveChangesAsync();
                return Ok(outlet);
            }
            return BadRequest(new ResponseMessage() { message = "All fields required", success = 400 });
        }



        [HttpPost("test/createClient")]
        public async Task<IActionResult> createClient(Client client)
        {
            if (ModelState.IsValid)
            {
                _context.Add(client);
                await _context.SaveChangesAsync();
                return Ok(client);
            }
            return BadRequest(new ResponseMessage() { message = "All fields required", success = 400 });
        }


        [HttpPost("test/createClientType")]
        public async Task<IActionResult> createClientType(ClientType clientType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientType);
                await _context.SaveChangesAsync();
                return Ok(clientType);
            }
            return BadRequest(new ResponseMessage() { message = "All fields required", success = 400 });
        }



        [HttpPost("test/createAuthorizationKey")]
        public async Task<IActionResult> createAuthKey(AuthorizationKey authorizationKey)
        {
            if (ModelState.IsValid)
            {
                _context.Add(authorizationKey);
                await _context.SaveChangesAsync();
                return Ok(authorizationKey);
            }
            return BadRequest(new ResponseMessage() { message = "All fields required", success = 400 });
        }

        [HttpPost("test/getDistance")]
        public async Task<IActionResult> getDistance()
        {
            var distanceAway = DistanceCalculator.CalculateDistanceBtw2Locales("4.824167", "7.033611", "4.664030", "6.036987");

            //var sCoord = new GeoCoordinate(Convert.ToDouble("4.824167"), Convert.ToDouble("7.033611"));
            //var eCoord = new GeoCoordinate(Convert.ToDouble("4.664030"), Convert.ToDouble("6.036987"));

            //This answer is in metres, so you have to convert to kilometres
            //var distanceAway = sCoord.GetDistanceTo(eCoord);

            // converting from meters to kilometres
            var converted = distanceAway / 1000;
            int res = Convert.ToInt32(converted);
            return Ok(res);

        }


        [HttpPost("postTierFeature")]
        public async Task<IActionResult> addFeature(SubscriptionTierFeature subscriptionTier)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subscriptionTier);
                await _context.SaveChangesAsync();
                return Ok(subscriptionTier);
            }
            return BadRequest(new ResponseMessage() { message = "All fields required", success = 400 });
        }



        //public async Task<User> GetUser(Guid userId, string userGroup, bool noTracking = false)
        //{
        //    IQueryable<SubscriptionTier> queryable = _context.SubscriptionTier.Select(x => x);

        //    if (!string.IsNullOrEmpty(userGroup))
        //        queryable = queryable.Where(x => x. == userGroup);

        //    if (noTracking)
        //        queryable = queryable.AsNoTracking();

        //    return await queryable.FirstOrDefaultAsync(x => x.userId == userId);
        //}


    }



  

}