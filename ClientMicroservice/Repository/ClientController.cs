using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NotificationService.Data.Data;
using NotificationService.Data.Models;
using NotificationService.Helpers;
using Microsoft.EntityFrameworkCore;
using KissLog;
using Microsoft.Extensions.Options;
using NotificationService.InputOutputData;
using System.Linq;
using NotificationService.Data;
using ClientMicroservice.InputOutputData;

namespace NotificationService.Repository
{
    public class ClientController : IClientService
    {
        private readonly MyDatabaseContext _context;
        private readonly AppSettings _appSettings;
        private readonly ILogger _logger;

        public ClientController(MyDatabaseContext _context, IOptions<AppSettings> appSettings, ILogger logger)
        {

            this._context = _context;
            this._appSettings = appSettings.Value;
            _logger = logger;
        }

        public async Task<Client> CreateClient(Client client)
        {
            try
            {
                _context.Add(client);
                await _context.SaveChangesAsync();
                return client;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                return null;
            }
        }

        public async Task<ClientOutlet> CreateClientOutlet(ClientOutlet outlet)
        {
            try
            {
                _context.Add(outlet);
                await _context.SaveChangesAsync();
                return outlet;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                return null;
            }
        }

       

        public async Task<Boolean> GetAuthorizationKey(string key)
        {
            try
            {
                var authorizationKey = await _context.AuthorizationKey.FirstOrDefaultAsync(o => o.Key == key);
                if (authorizationKey != null)
                {
                    if (authorizationKey.AuthorizationKeyStatus == 1)
                    {
                        //Authorization key is still valid
                        return true;
                    }
                    return false;
                }
                return false;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                return false;
            }


        }

        public async Task<List<ClientResponse>> GetClientsAndDefaultOutlet()
        {
            try
            {
                var clients = await _context.Client.ToListAsync();
                if (clients != null)
                {

                    List<ClientResponse> allClients = new List<ClientResponse>();

                    foreach (var data in clients)
                    {

                        // Check if client is not deleted and is Authorized.
                        if (data.IsDeleted == false && data.IsApproved == true)
                        {
                            var clientOutlets = await _context.ClientOutlet.Where(a => a.ClientId == data.Id).ToListAsync();

                            if (clientOutlets != null)
                            {
                                // Loop through all clientOutlets of users
                                foreach (var clientOutletData in clientOutlets)
                                {
                                    //Check for the default outlet
                                    if (clientOutletData.IsDefault == true)
                                    {
                                        //Get the default client outlet address
                                        //string addressId = clientOutletData.addressId.ToString();
                                        var defaultAddress = await _context.Address.FirstOrDefaultAsync(o => o.Id == clientOutletData.AddressId);
                                        if (defaultAddress != null)
                                        {
                                            ClientResponse clientR = new ClientResponse
                                            {
                                                clientId = data.Id,
                                                clientName = data.Name,
                                                defaultCity = defaultAddress.City,
                                                defaultContactPerson = clientOutletData.ContactPerson,
                                                defaultEmailAddress = clientOutletData.EmailAddress,
                                                defaultState = defaultAddress.StateId.ToString(),
                                                defaultLga = defaultAddress.LocalGovtId.ToString(),
                                                defaultCountry = defaultAddress.CountryId.ToString(),
                                                defaultStreetName = defaultAddress.Street,
                                                defaultStreetNumber = defaultAddress.Number,
                                                defaultPhoneNumber = clientOutletData.PhoneNumber,
                                                clientType = data.ClientTypeId.ToString(),
                                                numOfOutlets = clientOutlets.Count,
                                                //businessLicenseNumber = clientOutletData.BusinesssLicenseNumber
                                            };

                                            allClients.Add(clientR);
                                        }


                                    }

                                }

                            }

                        }


                    }



                    return allClients;
                }
                return null;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                return null;
            }
        }




        public async Task<List<ClientResponse>> GetClientsById(int clientId)
        {
            try
            {
                var clients = await _context.Client.Where(x => x.Id == clientId).ToListAsync();
                if (clients.Count != 0)
                {

                    List<ClientResponse> allClients = new List<ClientResponse>();

                    foreach (var data in clients)
                    {

                        // Check if client is not deleted and is Authorized.
                        if (data.IsDeleted == false && data.IsApproved == true)
                        {
                            var clientOutlets = await _context.ClientOutlet.Where(a => a.ClientId == data.Id).ToListAsync();

                            if (clientOutlets != null)
                            {
                                // Loop through all clientOutlets of users
                                foreach (var clientOutletData in clientOutlets)
                                {
                                    //Check for the default outlet
                                    if (clientOutletData.IsDefault == true)
                                    {
                                        //Get the default client outlet address
                                        //string addressId = clientOutletData.addressId.ToString();
                                        var defaultAddress = await _context.Address.FirstOrDefaultAsync(o => o.Id == clientOutletData.AddressId);
                                        if (defaultAddress != null)
                                        {
                                            ClientResponse clientR = new ClientResponse
                                            {
                                                clientId = data.Id,
                                                clientName = data.Name,
                                                defaultCity = defaultAddress.City,
                                                defaultContactPerson = clientOutletData.ContactPerson,
                                                defaultEmailAddress = clientOutletData.EmailAddress,
                                                defaultState = defaultAddress.StateId.ToString(),
                                                defaultLga = defaultAddress.LocalGovtId.ToString(),
                                                defaultCountry = defaultAddress.CountryId.ToString(),
                                                defaultStreetName = defaultAddress.Street,
                                                defaultStreetNumber = defaultAddress.Number,
                                                defaultPhoneNumber = clientOutletData.PhoneNumber,
                                                clientType = data.ClientTypeId.ToString(),
                                                numOfOutlets = clientOutlets.Count,
                                                //businessLicenseNumber = clientOutletData.businesssLicenseNumber
                                            };

                                            allClients.Add(clientR);
                                        }


                                    }

                                }

                            }

                        }


                    }

                    return allClients;
                }
                return null;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                return null;
            }
        }




        public async Task<List<ClientResponse>> GetClientsByName(string name)
        {
            try
            {
                var clients = await _context.Client.Where(x => x.Name.Contains(name)).ToListAsync();
                if (clients != null)
                {

                    List<ClientResponse> allClients = new List<ClientResponse>();

                    foreach (var data in clients)
                    {

                        // Check if client is not deleted and is Authorized.
                        if (data.IsDeleted == false && data.IsApproved == true)
                        {
                            var clientOutlets = await _context.ClientOutlet.Where(a => a.ClientId == data.Id).ToListAsync();

                            if (clientOutlets != null)
                            {
                                // Loop through all clientOutlets of users
                                foreach (var clientOutletData in clientOutlets)
                                {
                                    //Check for the default outlet
                                    if (clientOutletData.IsDefault == true)
                                    {
                                        //Get the default client outlet address
                                        //string addressId = clientOutletData.addressId.ToString();
                                        var defaultAddress = await _context.Address.FirstOrDefaultAsync(o => o.Id == clientOutletData.AddressId);
                                        if (defaultAddress != null)
                                        {
                                            ClientResponse clientR = new ClientResponse
                                            {
                                                clientId = data.Id,
                                                clientName = data.Name,
                                                defaultCity = defaultAddress.City,
                                                defaultContactPerson = clientOutletData.ContactPerson,
                                                defaultEmailAddress = clientOutletData.EmailAddress,
                                                defaultState = defaultAddress.StateId.ToString(),
                                                defaultLga = defaultAddress.LocalGovtId.ToString(),
                                                defaultCountry = defaultAddress.CountryId.ToString(),
                                                defaultStreetName = defaultAddress.Street,
                                                defaultStreetNumber = defaultAddress.Number,
                                                defaultPhoneNumber = clientOutletData.PhoneNumber,
                                                clientType = data.ClientTypeId.ToString(),
                                                numOfOutlets = clientOutlets.Count,
                                                //businessLicenseNumber = clientOutletData.businesssLicenseNumber
                                            };

                                            allClients.Add(clientR);
                                        }


                                    }

                                }

                            }

                        }


                    }

                    return allClients;
                }
                return null;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                return null;
            }
        }

        public async Task<List<ClientOutletResponse>> GetClientOutletByStateId(int stateId)
        {
            try
            {
                var addresses = await _context.Address.Where(x => x.StateId == stateId).ToListAsync();

                if (addresses.Count != 0)
                {

                    List<ClientOutletResponse> allClients = new List<ClientOutletResponse>();

                    foreach (var data in addresses)
                    {


                        var clientOutlets = await _context.ClientOutlet.Where(a => a.AddressId == data.Id).ToListAsync();

                        if (clientOutlets.Count != 0)
                        {
                            // Loop through all clientOutlets of users
                            foreach (var clientOutletData in clientOutlets)
                            {

                                if (clientOutletData.IsDeleted == false)
                                {


                                    var client = await _context.Client.FirstOrDefaultAsync(o => o.Id == clientOutletData.ClientId);

                                    if (client.IsDeleted == false && client.IsApproved == true)
                                    {
                                        var state = await _context.State.FirstOrDefaultAsync(o => o.Id == data.StateId);
                                        var country = await _context.Country.FirstOrDefaultAsync(o => o.Id == data.CountryId);
                                        var LGA = await _context.LocalGovernmentArea.FirstOrDefaultAsync(o => o.Id == data.LocalGovtId);


                                        ClientOutletResponse clientR = new ClientOutletResponse
                                        {

                                            clientId = client.Id,
                                            clientName = client.Name,
                                            clientType = client.ClientTypeId.ToString(),

                                            outletId = clientOutletData.Id,
                                            outletName = clientOutletData.ContactPerson,
                                            phoneNumber = clientOutletData.PhoneNumber,
                                            emailAddress = clientOutletData.EmailAddress,
                                            contactPerson = clientOutletData.ContactPerson,
                                            contactPersonPhoneNumber = clientOutletData.ContactPersonPhoneNumber,
                                            contactPersonEmailAddress = clientOutletData.ContactPersonEmail,
                                            streetNumber = data.Number,
                                            streetName = data.Street,

                                            state = state.Name,
                                            country = country.Name,
                                            lga = LGA.Name,
                                            city = data.City,

                                        };

                                        allClients.Add(clientR);
                                    }

                                }

                            }

                        }


                    }



                    return allClients;
                }
                return null;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                return null;
            }

        }



        public async Task<List<SubTiersOutput>> GetsubscriptionTiers()
        {
            try
            {
                var subscriptionTiers = await _context.SubscriptionTier.ToListAsync();
                if (subscriptionTiers != null)
                {
                    List<SubTiersOutput> allTiers = new List<SubTiersOutput>();

                    foreach (var data in subscriptionTiers)
                    {
                        var subscriptionTierFeatures = await _context.SubscriptionTierFeature.Where(a => a.SubscriptionTierId == data.Id).ToListAsync();
                        SubTiersOutput subTiersOutput = new SubTiersOutput()
                        {
                            id = data.Id,
                            name = data.Name,
                            price = data.Price,
                            isDeleted = data.IsDeleted,
                            list = subscriptionTierFeatures,
                        };
                        allTiers.Add(subTiersOutput);
                    }

                    return allTiers;
                }
                return null;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                return null;
            }

        }


        public async Task<List<ClientOutletResponse>> GetClientOutletByLGAId(int lgaId)
        {

            try
            {
                var addresses = await _context.Address.Where(x => x.LocalGovtId == lgaId).ToListAsync();

                //return Ok(addresses);

                if (addresses.Count != 0)
                {

                    List<ClientOutletResponse> allClients = new List<ClientOutletResponse>();

                    foreach (var data in addresses)
                    {


                        var clientOutlets = await _context.ClientOutlet.Where(a => a.AddressId == data.Id).ToListAsync();

                        if (clientOutlets.Count != 0)
                        {
                            // Loop through all clientOutlets of users
                            foreach (var clientOutletData in clientOutlets)
                            {

                                if (clientOutletData.IsDeleted == false)
                                {


                                    var client = await _context.Client.FirstOrDefaultAsync(o => o.Id == clientOutletData.ClientId);

                                    if (client.IsDeleted == false && client.IsApproved == true)
                                    {
                                        var state = await _context.State.FirstOrDefaultAsync(o => o.Id == data.StateId);
                                        var country = await _context.Country.FirstOrDefaultAsync(o => o.Id == data.CountryId);
                                        var LGA = await _context.LocalGovernmentArea.FirstOrDefaultAsync(o => o.Id == data.LocalGovtId);


                                        ClientOutletResponse clientR = new ClientOutletResponse
                                        {

                                            clientId = client.Id,
                                            clientName = client.Name,
                                            clientType = client.ClientTypeId.ToString(),

                                            outletId = clientOutletData.Id,
                                            outletName = clientOutletData.ContactPerson,
                                            phoneNumber = clientOutletData.PhoneNumber,
                                            emailAddress = clientOutletData.EmailAddress,
                                            contactPerson = clientOutletData.ContactPerson,
                                            contactPersonPhoneNumber = clientOutletData.ContactPersonPhoneNumber,
                                            contactPersonEmailAddress = clientOutletData.ContactPersonEmail,
                                            streetNumber = data.Number,
                                            streetName = data.Street,

                                            state = state.Name,
                                            country = country.Name,
                                            lga = LGA.Name,
                                            city = data.City,

                                        };

                                        allClients.Add(clientR);
                                    }

                                }

                            }

                        }


                    }


                    return allClients;
                }
                return null;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                return null;
            }
        }

        public async Task<List<ClientOutletResponse>> GetClientOutletByProximity(string latitude, string longitude, string clientTypeId)
        {
            try
            {
                var addresses = await _context.Address.Where(x => x.StateId == 1).ToListAsync();
                if (addresses.Count != 0)
                {

                    List<ClientOutletResponse> allClients = new List<ClientOutletResponse>();

                    foreach (var data in addresses)
                    {

                        var distanceAway = DistanceCalculator.CalculateDistanceBtw2Locales(latitude, longitude, data.Latitude, data.Longitude);

                        // var convert from Metres to Kilometres
                        var converted = distanceAway / 1000;
                        int res = Convert.ToInt32(converted);


                        if (res < 10)
                        {

                            var clientOutlets = await _context.ClientOutlet.Where(a => a.AddressId == data.Id).ToListAsync();

                            if (clientOutlets.Count != 0)
                            {
                                // Loop through all clientOutlets of users
                                foreach (var clientOutletData in clientOutlets)
                                {

                                    if (clientOutletData.IsDeleted == false)
                                    {


                                        var client = await _context.Client.FirstOrDefaultAsync(o => o.Id == clientOutletData.ClientId);

                                        if (client.IsDeleted == false && client.IsApproved == true)
                                        {
                                            var state = await _context.State.FirstOrDefaultAsync(o => o.Id == data.StateId);
                                            var country = await _context.Country.FirstOrDefaultAsync(o => o.Id == data.CountryId);
                                            var LGA = await _context.LocalGovernmentArea.FirstOrDefaultAsync(o => o.Id == data.LocalGovtId);


                                            ClientOutletResponse clientR = new ClientOutletResponse
                                            {

                                                clientId = client.Id,
                                                clientName = client.Name,
                                                clientType = client.ClientTypeId.ToString(),

                                                outletId = clientOutletData.Id,
                                                outletName = clientOutletData.ContactPerson,
                                                phoneNumber = clientOutletData.PhoneNumber,
                                                emailAddress = clientOutletData.EmailAddress,
                                                contactPerson = clientOutletData.ContactPerson,
                                                contactPersonPhoneNumber = clientOutletData.ContactPersonPhoneNumber,
                                                contactPersonEmailAddress = clientOutletData.ContactPersonEmail,
                                                streetNumber = data.Number,
                                                streetName = data.Street,

                                                state = state.Name,
                                                country = country.Name,
                                                lga = LGA.Name,
                                                city = data.City,
                                                distanceAway = converted

                                            };

                                            allClients.Add(clientR);
                                        }

                                    }

                                }

                            }

                        }


                    }

                    if (allClients.Count == 0)
                    {
                        return null;
                        //return BadRequest(new { message = "No client outlets in 2 kilometeres to your proximity" });
                    }
                    return allClients;
                }
                return null;

            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                return null;
            }
        }



        public async Task<List<ClientResponse>> GetClientOutletByClientType(int clientTypeId)
        {
            try
            {
                var clients = await _context.Client.Where(x => x.ClientTypeId == clientTypeId).ToListAsync();
                if (clients.Count != 0)
                {

                    List<ClientResponse> allClients = new List<ClientResponse>();

                    foreach (var data in clients)
                    {

                        // Check if client is not deleted and is Authorized.
                        if (data.IsDeleted == false && data.IsApproved == true)
                        {
                            var clientOutlets = await _context.ClientOutlet.Where(a => a.ClientId == data.Id).ToListAsync();

                            if (clientOutlets != null)
                            {
                                // Loop through all clientOutlets of users
                                foreach (var clientOutletData in clientOutlets)
                                {
                                    //Check for the default outlet
                                    if (clientOutletData.IsDefault == true)
                                    {
                                        //Get the default client outlet address
                                        //string addressId = clientOutletData.addressId.ToString();
                                        var defaultAddress = await _context.Address.FirstOrDefaultAsync(o => o.Id == clientOutletData.AddressId);
                                        if (defaultAddress != null)
                                        {
                                            var state = await _context.State.FirstOrDefaultAsync(o => o.Id == defaultAddress.StateId);
                                            var country = await _context.Country.FirstOrDefaultAsync(o => o.Id == defaultAddress.CountryId);
                                            var LGA = await _context.LocalGovernmentArea.FirstOrDefaultAsync(o => o.Id == defaultAddress.LocalGovtId);
                                            var clientType = await _context.ClientType.FirstOrDefaultAsync(o => o.Id == clientTypeId);

                                            ClientResponse clientR = new ClientResponse
                                            {
                                                clientId = data.Id,
                                                clientName = data.Name,
                                                defaultCity = defaultAddress.City,
                                                defaultContactPerson = clientOutletData.ContactPerson,
                                                defaultEmailAddress = clientOutletData.EmailAddress,
                                                defaultState = state.Name,
                                                defaultLga = LGA.Name,
                                                defaultCountry = country.Name,
                                                defaultStreetName = defaultAddress.Street,
                                                defaultStreetNumber = defaultAddress.Number,
                                                defaultPhoneNumber = clientOutletData.PhoneNumber,
                                                clientType = clientType.Name,
                                                numOfOutlets = clientOutlets.Count,
                                                //businessLicenseNumber = clientOutletData.businesssLicenseNumber
                                            };

                                            allClients.Add(clientR);
                                        }


                                    }

                                }

                            }

                        }


                    }

                    return allClients;
                }
                return null;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                return null;
            }


        }

        public async Task<ClientOutletDetailsResponse> GetOutletsDetails(int clientOutletId)
        {
            try
            {
                var clientOutlet = await _context.ClientOutlet.FirstOrDefaultAsync(o => o.Id == clientOutletId);
                var bank = await _context.Bank.FirstOrDefaultAsync(o => o.Id == clientOutlet.BankId);

                if (clientOutlet != null)
                {

                    var client = await _context.Client.FirstOrDefaultAsync(o => o.Id == clientOutlet.ClientId);
                    var addressData = await _context.Address.FirstOrDefaultAsync(o => o.Id == clientOutlet.AddressId);

                    if (addressData != null)
                    {

                        var state = await _context.State.FirstOrDefaultAsync(o => o.Id == addressData.StateId);
                        var country = await _context.Country.FirstOrDefaultAsync(o => o.Id == addressData.CountryId);
                        var LGA = await _context.LocalGovernmentArea.FirstOrDefaultAsync(o => o.Id == addressData.LocalGovtId);
                        var clientType = await _context.ClientType.FirstOrDefaultAsync(o => o.Id == client.ClientTypeId);


                        ClientOutletDetailsResponse clientOutletDetails = new ClientOutletDetailsResponse
                        {
                            clientId = client.Id,
                            clientName = client.Name,
                            clientType = clientType.Name,
                            city = addressData.City,
                            contactPerson = clientOutlet.ContactPerson,
                            contactPersonEmailAddress = clientOutlet.ContactPersonEmail,
                            contactPersonPhoneNumber = clientOutlet.ContactPersonPhoneNumber,
                            country = country.Name,
                            emailAddress = clientOutlet.EmailAddress,
                            lga = LGA.Name,
                            outletId = clientOutlet.Id,
                            outletName = clientOutlet.Name,
                            phoneNumber = clientOutlet.PhoneNumber,
                            state = state.Name,
                            streetName = addressData.Street,
                            streetNumber = addressData.Number,
                            subscribedToPromotions = (bool)clientOutlet.SubscribedToPromotions

                        };

                        return clientOutletDetails;

                    }
                    return null;
                    //return BadRequest(new { message = "No Assigned address for outlet" });

                }
                return null;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                return null;
            }

        }

        public async Task<BankResponse> GetOutletsBankInfo(string clientauthorizationKey, int clientOutletId)
        {
            try
            {
                var authorizationKey = await _context.AuthorizationKey.FirstOrDefaultAsync(o => o.Key == clientauthorizationKey);
                if (authorizationKey != null)
                {
                    if (authorizationKey.AuthorizationKeyStatus == 1)
                    {

                        var clientOutlet = await _context.ClientOutlet.FirstOrDefaultAsync(o => o.Id == clientOutletId);
                        var bank = await _context.Bank.FirstOrDefaultAsync(o => o.Id == clientOutlet.BankId);

                        BankResponse bankResponse = new BankResponse
                        {
                            bankAccountName = clientOutlet.BankAccountName,
                            bankAccountNumber = clientOutlet.BankAccountNumber,
                            bankName = bank.Name
                        };
                        return bankResponse;

                    }
                    return null;

                }
                return null;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                return null;
            }
        }

        public async Task<bool> UpdateClientContact(ContactInput contactInput, string username)
        {
            try
            {
                var authorizationKey = await _context.AuthorizationKey.FirstOrDefaultAsync(o => o.Key == contactInput.clientAuthorizationKey);
                if (authorizationKey != null)
                {
                    if (authorizationKey.AuthorizationKeyStatus == 1)
                    {

                        // Authorization key is still valid
                        return true;
                    }
                    //return Ok(new { message = "AuthorizationKey is not valid" });
                    return false;
                }
                return false;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                return false;
            }
        }

        public async Task<ClientOutlet> UpdateBankingDetails(UpdateBankInput bankInput, string username)
        {
            try
            {
                var authorizationKey = await _context.AuthorizationKey.FirstOrDefaultAsync(o => o.Key == bankInput.clientAuthorizationKey);
                if (authorizationKey != null)
                {
                    if (authorizationKey.AuthorizationKeyStatus == 1)
                    {


                        var user = await _context.UserData.FirstOrDefaultAsync(o => o.Username == username);
                        var client = await _context.Client.FirstOrDefaultAsync(o => o.CreatorUserId == user.Id);
                        var clientOutlet = await _context.ClientOutlet.FirstOrDefaultAsync(o => o.Id == bankInput.clientOutletId);

                        if (client.Id == clientOutlet.ClientId)
                        {
                            clientOutlet.BankAccountName = bankInput.bankAccountName;
                            clientOutlet.BankAccountNumber = bankInput.bankAccountNumber;
                            clientOutlet.BankId = bankInput.bankId;

                            _context.Update(clientOutlet);
                            await _context.SaveChangesAsync();
                            return clientOutlet;
                        }
                        return null;
                        //return BadRequest(new { message = "Not Authorized to update this outlet" });


                    }
                    return null;
                    //return BadRequest(new { message = "Key is not authorized" });

                }
                return null;
                //return BadRequest(new { message = "No Authorization Key found" });
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                return null;
            }

        }

        public async Task<List<ClientType>> GetAllClientTypes()
        {
            var clientType = await _context.ClientType.OrderBy(a => a.Id).ToListAsync();
            if (clientType != null)
            {
                return clientType;
            }
            return null;
        }

        public async Task<ClientType> AddClientType(ClientType clientType)
        {
            _context.Add(clientType);
            await _context.SaveChangesAsync();
            return clientType;
        }

        public async Task<Client> createNonMember(NonNetworkMemInput data)
        {
            var client = await _context.Client.Where(a => a.Id == data.ClientTypeId && a.Name == data.ClientName).ToListAsync();
            if (client == null)
            {
                Client clinteN = new Client()
                {
                    Name = data.FirstName + " " + data.LastName,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    IsApproved = false,
                    ClientStatusId = 0,
                    ClientTypeId = data.ClientTypeId,
                    IsWithinAhanetwork = false,

                };
                _context.Add(client);
                await _context.SaveChangesAsync();
                return clinteN;

            }
            return null;
            //return BadRequest(new { message = "This client already exists" });
        }


        


    }
}
