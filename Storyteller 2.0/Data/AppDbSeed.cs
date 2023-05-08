using Microsoft.AspNetCore.Identity;
using Storyteller_2._0.Data.Enum;
using Storyteller_2._0.Data.Stoned;
using Storyteller_2._0.Models;

namespace Storyteller_2._0.Data
{
    public class AppDbSeed
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                if (!context.Comics.Any())
                {
                    context.Comics.AddRange(new List<Comic>()
                    {
                        new Comic()
                        {
                            Name = "Comic 1",
                            Description = "This is the description of the first Comic",
                            PageCount = 5,
                            Genre = "Shonen",
                            Size = "A3",
                            Type = ComicCategory.Monochrome,
                            PageId = 1


                        },
                        new Comic()
                        {
                           Name = "Comic 2",
                            Description = "This is the description of the second Comic",
                            PageCount = 4,
                            Genre = "Seinen",
                            Size = "A3",
                            Type = ComicCategory.Monochrome,
                            PageId = 2
                        },
                        new Comic()
                        {
                           Name = "Comic 3",
                            Description = "This is the description of the third Comic",
                            PageCount = 3,
                            Genre = "Short",
                            Size = "A3",
                            Type = ComicCategory.Monochrome,
                            PageId = 3
                        },
                        new Comic()
                        {
                           Name = "Comic 4",
                            Description = "This is the description of the fourth Comic",
                            PageCount = 2,
                            Genre = "Shonen",
                            Size = "A3",
                            Type = ComicCategory.Monochrome,
                            PageId = 4
                        },

                    }) ;
                    context.SaveChanges();
                }
                if (!context.Pages.Any())
                {
                    context.Pages.AddRange(new List<Page>()
                    {
                        new Page()
                        {
                            Description = "This is the description of the first Comic",
                            panels = 3


                        },
                        new Page()
                        {
                            Description = "This is the description of the first Comic",
                            panels = 4


                        },
                        new Page()
                        {
                            Description = "This is the description of the first Comic",
                            panels = 4


                        },
                        new Page()
                        {
                            Description = "This is the description of the first Comic",
                            panels = 4


                        },
                        new Page()
                        {
                            Description = "This is the description of the first Comic",
                            panels = 4


                        },
                        new Page()
                        {
                            Description = "This is the description of the first Comic",
                            panels = 4


                        },
                        new Page()
                        {
                            Description = "This is the description of the first Comic",
                            panels = 4


                        },
                        new Page()
                        {
                            Description = "This is the description of the first Comic",
                            panels = 4


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
                string adminUserEmail = "admin@etickets.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
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


                string appUserEmail = "user@etickets.com";

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
