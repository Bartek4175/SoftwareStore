using Microsoft.AspNetCore.Builder;
using SoftwareStore;
using SoftwareStore.Controllers;
using SoftwareStore.Data.Base;
using SoftwareStore.Data.Services;
using SoftwareStore.Models;
using System;
using System.Linq.Expressions;

namespace SoftwareStoreTest
{
    public class PlatformsServiceTest : IPlatformsService
    {
        private readonly Dictionary<int, Platform> Platforms;
        public PlatformsServiceTest()
        {
            Platforms = new Dictionary<int, Platform>();
            
        }
        private int counter = 1;
        private int UniqId()
        {
            return counter++;
        }
        public bool DeleteAsync(int? id) => (id is null) ? false : Platforms.Remove((int)id);

        public IEnumerable<Platform?> GetAllAsync()
        {
            foreach (KeyValuePair<int, Platform> item in Platforms)
            {
                yield return item.Value;
            }
        }
        public Task AddAsync(Platform entity)
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

        Task<IEnumerable<Platform>> IEntityBaseRepository<Platform>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAsync(int id)
        {
            if (id == null) return false;
            return Platforms.Remove(id ?? 1);
        }
    }
}
