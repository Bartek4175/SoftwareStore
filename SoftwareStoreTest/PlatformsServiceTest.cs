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
        public Task AddAsync(Platform entity)
        {
            Platforms.Add(entity.Id, entity);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Platform>> GetAllAsync(params Expression<Func<Platform, object>>[] includeProperties)
        {
            return Task.FromResult<IEnumerable<Platform>>(Platforms.Values);
        }

        public Task<Platform> GetByIdAsync(int id)
        {
            return Task.FromResult(Platforms.ContainsKey(id) ? Platforms[id] : null);
        }

        public Task<Platform> GetByIdAsync(int id, params Expression<Func<Platform, object>>[] includeProperties)
        {
            return Task.FromResult(Platforms.ContainsKey(id) ? Platforms[id] : null);
        }

        public Task UpdateAsync(int id, Platform entity)
        {
            if (Platforms.ContainsKey(id))
            {
                Platforms[id] = entity;
            }
            return Task.CompletedTask;
        }

        public Task DeleteAsync(int id)
        {
            if (Platforms.ContainsKey(id))
            {
                Platforms.Remove(id);
            }
            return Task.CompletedTask;
        }

        Task<IEnumerable<Platform>> IEntityBaseRepository<Platform>.GetAllAsync()
        {
            return GetAllAsync();
        }

        Task IEntityBaseRepository<Platform>.DeleteAsync(int id)
        {
            return DeleteAsync(id);
        }
    }
}