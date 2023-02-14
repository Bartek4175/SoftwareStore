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
            Platforms.Add(1, new Platform() { Id = 1, ProfilePictureURL = "pic1.png", FullName = "Origin", Bio = "Testowy opis 1" });
            Platforms.Add(2, new Platform() { Id = 2, ProfilePictureURL = "pic2.png", FullName = "Steam", Bio = "Testowy opis 2" });
            Platforms.Add(3, new Platform() { Id = 3, ProfilePictureURL = "pic3.png", FullName = "Allegro", Bio = "Testowy opis 3" });
            Platforms.Add(4, new Platform() { Id = 4, ProfilePictureURL = "pic4.png", FullName = "Windows", Bio = "Testowy opis 4" });
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

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
