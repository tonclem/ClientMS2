using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClientMicroservice.InputOutputData;
using NotificationService.Data.Models;
using NotificationService.InputOutputData;


namespace NotificationService.Repository
{
    public interface IClientService
    {
        Task<List<ClientType>> GetAllClientTypes();
        Task<Boolean> GetAuthorizationKey(string key);
        Task<Client> CreateClient(Client client);
        Task<ClientOutlet> CreateClientOutlet(ClientOutlet outlet);
        Task<List<SubTiersOutput>> GetsubscriptionTiers();
        Task<List<ClientResponse>> GetClientsAndDefaultOutlet();
        Task<List<ClientResponse>> GetClientsByName(string name);
        Task<List<ClientResponse>> GetClientsById(int clientId);
        Task<List<ClientOutletResponse>> GetClientOutletByStateId(int stateId);
        Task<List<ClientOutletResponse>> GetClientOutletByLGAId(int lgaId);
        Task<List<ClientOutletResponse>> GetClientOutletByProximity(string latitude, string longitude, string clientTypeId);
        Task<List<ClientResponse>> GetClientOutletByClientType(int clientTypeId);
        Task<ClientOutletDetailsResponse> GetOutletsDetails(int clientOutletId);
        Task<BankResponse> GetOutletsBankInfo(string clientauthorizationKey, int clientOutletId);
        Task<Boolean> UpdateClientContact(ContactInput contactInput,string username);
        Task<ClientOutlet> UpdateBankingDetails(UpdateBankInput input,string username);
        Task<ClientType> AddClientType(ClientType clientType);
        Task<Client> createNonMember(NonNetworkMemInput data);
    }
}
