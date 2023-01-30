using SoftwareStore.Data.Static;
using SoftwareStore.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Platforms
                if (!context.Platforms.Any())
                {
                    context.Platforms.AddRange(new List<Platform>()
                    {
                        new Platform()
                        {
                            FullName = "platform 1",
                            Bio = "This is the Bio of the first platform",
                            ProfilePictureURL = "http://dotnethow.net/images/Platforms/platform-1.jpeg"

                        },
                        new Platform()
                        {
                            FullName = "platform 2",
                            Bio = "This is the Bio of the second platform",
                            ProfilePictureURL = "http://dotnethow.net/images/Platforms/platform-2.jpeg"
                        },
                        new Platform()
                        {
                            FullName = "platform 3",
                            Bio = "This is the Bio of the second platform",
                            ProfilePictureURL = "http://dotnethow.net/images/Platforms/platform-3.jpeg"
                        },
                        new Platform()
                        {
                            FullName = "platform 4",
                            Bio = "This is the Bio of the second platform",
                            ProfilePictureURL = "http://dotnethow.net/images/Platforms/platform-4.jpeg"
                        },
                        new Platform()
                        {
                            FullName = "platform 5",
                            Bio = "This is the Bio of the second platform",
                            ProfilePictureURL = "http://dotnethow.net/images/Platforms/platform-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first platform",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second platform",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second platform",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the second platform",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the second platform",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Products
                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            Name = "Life",
                            Description = "This is the Life Product description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/Products/Product-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            ProducerId = 3,
                            ProductCategory = ProductCategory.Documentary
                        },
                        new Product()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "http://dotnethow.net/images/Products/Product-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            ProducerId = 1,
                            ProductCategory = ProductCategory.Action
                        },
                        new Product()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost Product description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/Products/Product-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            ProducerId = 4,
                            ProductCategory = ProductCategory.Horror
                        },
                        new Product()
                        {
                            Name = "Race",
                            Description = "This is the Race Product description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/Products/Product-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            ProducerId = 2,
                            ProductCategory = ProductCategory.Documentary
                        },
                        new Product()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob Product description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/Products/Product-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            ProducerId = 3,
                            ProductCategory = ProductCategory.Cartoon
                        },
                        new Product()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles Product description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/Products/Product-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            ProducerId = 5,
                            ProductCategory = ProductCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Platforms & Products
                if (!context.Platforms_Products.Any())
                {
                    context.Platforms_Products.AddRange(new List<Platform_Product>()
                    {
                        new Platform_Product()
                        {
                            platformId = 1,
                            ProductId = 1
                        },
                        new Platform_Product()
                        {
                            platformId = 3,
                            ProductId = 1
                        },

                         new Platform_Product()
                        {
                            platformId = 1,
                            ProductId = 2
                        },
                         new Platform_Product()
                        {
                            platformId = 4,
                            ProductId = 2
                        },

                        new Platform_Product()
                        {
                            platformId = 1,
                            ProductId = 3
                        },
                        new Platform_Product()
                        {
                            platformId = 2,
                            ProductId = 3
                        },
                        new Platform_Product()
                        {
                            platformId = 5,
                            ProductId = 3
                        },


                        new Platform_Product()
                        {
                            platformId = 2,
                            ProductId = 4
                        },
                        new Platform_Product()
                        {
                            platformId = 3,
                            ProductId = 4
                        },
                        new Platform_Product()
                        {
                            platformId = 4,
                            ProductId = 4
                        },


                        new Platform_Product()
                        {
                            platformId = 2,
                            ProductId = 5
                        },
                        new Platform_Product()
                        {
                            platformId = 3,
                            ProductId = 5
                        },
                        new Platform_Product()
                        {
                            platformId = 4,
                            ProductId = 5
                        },
                        new Platform_Product()
                        {
                            platformId = 5,
                            ProductId = 5
                        },


                        new Platform_Product()
                        {
                            platformId = 3,
                            ProductId = 6
                        },
                        new Platform_Product()
                        {
                            platformId = 4,
                            ProductId = 6
                        },
                        new Platform_Product()
                        {
                            platformId = 5,
                            ProductId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }

        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@SoftwareStore.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if(adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@SoftwareStore.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}
