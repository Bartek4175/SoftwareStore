using SoftwareStore.Data.Base;
using SoftwareStore.Models;

namespace SoftwareStore.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
