using HotelListing.API.Contracts;
using HotelListing.API.Data;
using System.Security.Cryptography.X509Certificates;

namespace HotelListing.API.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}
