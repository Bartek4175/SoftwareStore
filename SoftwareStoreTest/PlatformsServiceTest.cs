using Microsoft.AspNetCore.Builder;
using SoftwareStore;
using SoftwareStore.Controllers;
using SoftwareStore.Data.Base;
using SoftwareStore.Data.Services;
using SoftwareStore.Models;
using System.Linq.Expressions;

namespace SoftwareStoreTest
{
    public class PlatformsServiceTest : IPlatformsService
    {
        public Task AddAsync(Platform entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException(); 
        }

        public Task<IEnumerable<Platform>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Platform>> GetAllAsync(params Expression<Func<Platform, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<Platform> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Platform> GetByIdAsync(int id, params Expression<Func<Platform, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void PlatformsControllerTest()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Platform entity)
        {
            throw new NotImplementedException();
        }
    }
}
