using SB.BrandManagement.Api.Contracts.Common.ExternalEntity;
using SB.BrandManagement.Api.Contracts.Output;
using SB.BrandManagement.Api.Infrastructure.API.Client;
using SB.Community.Serialisation.Interfaces;

namespace SB.Customer.Management.Common.Application.Repositories
{
    public class BrandManagementRepository
    {
        private readonly IPartnerClient _partnerClient;
        private readonly IExternalEntityClient _externalEntityClient;

        private readonly SemaphoreSlim _externalEntities_Semaphore = new SemaphoreSlim(1, 1);

        public BrandManagementRepository(
            ICommunitySerialiser communitySerializer)
        {
            _partnerClient = new PartnerClient("http://sb-bm-api.qa.bde.local/", new HttpClient(), communitySerializer);
            _externalEntityClient = new ExternalEntityClient("http://sb-bm-api.qa.bde.local/", new HttpClient(), communitySerializer);
        }

        private const string ShouldPersistMerchantUserIdToSbdbKey =
            "CustomerManagement|SB.Customer.Management.Service|CreateCustomer|ShouldPersistMerchantUserIdToSBDB";


        public async Task GetDefaultBrandExternalEntityAsync(string brandId)
        {
            var externalEntities = await GetExternalEntitiesAsync();

            var defaultExternalEntity = externalEntities.FirstOrDefault(ee =>
                ee.BrandContext.BrandId.Equals(brandId, StringComparison.InvariantCultureIgnoreCase) &&
                ee.ExternalEntityType.Value is ExternalEntityType.PAM);

            Console.WriteLine("");
        }

        private async Task<IEnumerable<VersionedExternalEntity>> GetExternalEntitiesAsync()
        {
            await _externalEntities_Semaphore.WaitAsync();

            try
            {
                var externalEntitiesResponse = await 
                    _externalEntityClient.GetExternalEntitiesAsync(Enumerable.Empty<string>(), Guid.NewGuid().ToString());

                if (externalEntitiesResponse is null || externalEntitiesResponse.ResponseCode != ResponseCode.Success)
                {
                    const string errorMessage = "Invalid GetExternalEntities response from BrandManagement";
                    throw new Exception(errorMessage);
                }

                return externalEntitiesResponse.ExternalEntities;
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error: {e}");
                return new List<VersionedExternalEntity>();
            }
            finally
            {
                _externalEntities_Semaphore.Release();
            }
        }

        public void Dispose()
        {
            _partnerClient?.Dispose();
        }
    }
}
