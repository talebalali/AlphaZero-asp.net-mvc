using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlphaZero.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AlphaZero.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();
                //Mobiles
                if (!context.Mobiles.Any())
                {
                    context.Mobiles.AddRange(new List<Mobile>()
                    {
                        new Mobile()
                        {
                            PictureUrl = "https://m.media-amazon.com/images/I/71HN4P-pd5L._AC_SX466_.jpg ",
                            ModelName = "Galaxy A53 5G",
                            WirelessCarrier = "Unlocked for All Carriers ",
                            Brand = Brand.SAMSUNG,
                            FormFactor = "Slate ",
                            RamMemory = 8,
                            OperatingSystem = OperSystem.Android,
                            Color = " Black",
                            CellularTechnology = "5G ",
                            Year = 2022,
                            Resolution = 1080,
                            AboutThisItem = "LONG-LASTING BATTERY: Your busy life deserves a battery built for busy; Whether you’re taking a video call on your commute, catching up on your favorite show or with friends and family, your long-lasting, super fast charging battery* has your back ",
                            InternalStorageMemory = 128,
                            Bio = "SAMSUNG Galaxy A53 5G A Series Cell Phone, Factory Unlocked Android Smartphone, 128GB, 6.5” FHD Super AMOLED Screen, Long Battery Life, US Version, Black ",
                            Price = 450,
                            SIMCardSlotCount = SIMCardSlotCount.DualSIM,
                            SIMCardSize = SIMCardSize.Micro
                        },
                      new Mobile()
                        {
                            PictureUrl = "https://images-na.ssl-images-amazon.com/images/I/41XydBYdgRL.__AC_SY300_SX300_QL70_FMwebp_.jpg",
                            ModelName = "XQBE62/B",
                            WirelessCarrier = "Unlocked for All Carriers ",
                            Brand = Brand.Sony,
                            FormFactor = "Slate ",
                            RamMemory = 8,
                            OperatingSystem = OperSystem.Android,
                            Color = " Black",
                            CellularTechnology = "5G ",
                            Year = 2022,
                            Resolution = 1080,
                            AboutThisItem = "LONG-LASTING BATTERY: Your busy life deserves a battery built for busy; Whether you’re taking a video call on your commute, catching up on your favorite show or with friends and family, your long-lasting, super fast charging battery* has your back ",
                            InternalStorageMemory = 128,
                            Bio = "Xperia PRO-I 5G smartphone with 1-inch image sensor, triple camera array and 120Hz 6.5” 21:9 4K HDR OLED Display - XQBE62/B",
                            Price = 450,
                            SIMCardSlotCount = SIMCardSlotCount.DualSIM,
                            SIMCardSize = SIMCardSize.Micro
                        },
                      new Mobile()
                        {
                            PictureUrl = "https://m.media-amazon.com/images/I/71Ptb2ttfaS._AC_SX466_.jpg",
                            ModelName = "G10",
                            WirelessCarrier = "Unlocked for All Carriers ",
                            Brand = Brand.Nokia,
                            FormFactor = "Slate ",
                            RamMemory = 8,
                            OperatingSystem = OperSystem.Android,
                            Color = " Black",
                            CellularTechnology = "5G ",
                            Year = 2022,
                            Resolution = 1080,
                            AboutThisItem = "LONG-LASTING BATTERY: Your busy life deserves a battery built for busy; Whether you’re taking a video call on your commute, catching up on your favorite show or with friends and family, your long-lasting, super fast charging battery* has your back ",
                            InternalStorageMemory = 128,
                            Bio = "Nokia G10 | Android 11 | Unlocked Smartphone | 3-Day Battery | Dual SIM | US Version | 3/32GB | 6.52-Inch Screen | 13MP Triple Camera | Polar Night",
                            Price = 450,
                            SIMCardSlotCount = SIMCardSlotCount.DualSIM,
                            SIMCardSize = SIMCardSize.Micro
                        },

                      new Mobile()
                        {
                            PictureUrl = "https://m.media-amazon.com/images/I/61s2ICnGk0L._AC_SX522_.jpg",
                            ModelName = "HTC One M9",
                            WirelessCarrier = "Unlocked for All Carriers ",
                            Brand = Brand.HTC,
                            FormFactor = "Slate ",
                            RamMemory = 8,
                            OperatingSystem = OperSystem.Android,
                            Color = " Black",
                            CellularTechnology = "5G ",
                            Year = 2022,
                            Resolution = 1080,
                            AboutThisItem = "LONG-LASTING BATTERY: Your busy life deserves a battery built for busy; Whether you’re taking a video call on your commute, catching up on your favorite show or with friends and family, your long-lasting, super fast charging battery* has your back ",
                            InternalStorageMemory = 128,
                            Bio = "HTC One M9 32GB Unlocked GSM 4G LTE Smartphone w/ 20MP Camera - Amber Gold",
                            Price = 450,
                            SIMCardSlotCount = SIMCardSlotCount.DualSIM,
                            SIMCardSize = SIMCardSize.Micro
                        },

                      new Mobile()
                        {
                            PictureUrl = "https://m.media-amazon.com/images/I/81nIH5A24bS._AC_SX522_.jpg",
                            ModelName = "G91 PRO",
                            WirelessCarrier = "Unlocked for All Carriers ",
                            Brand = Brand.BLU,
                            FormFactor = "Slate ",
                            RamMemory = 8,
                            OperatingSystem = OperSystem.Android,
                            Color = " Black",
                            CellularTechnology = "5G ",
                            Year = 2022,
                            Resolution = 1080,
                            AboutThisItem = "LONG-LASTING BATTERY: Your busy life deserves a battery built for busy; Whether you’re taking a video call on your commute, catching up on your favorite show or with friends and family, your long-lasting, super fast charging battery* has your back ",
                            InternalStorageMemory = 128,
                            Bio = "BLU G91 Pro | 2022 | 3-Day Battery | Unlocked | 6.7” Full HD+ Display | 128GB | 48MP Quad Camera | US Version | US Warranty | Graphite",
                            Price = 450,
                            SIMCardSlotCount = SIMCardSlotCount.DualSIM,
                            SIMCardSize = SIMCardSize.Micro
                        },

                      new Mobile()
                        {
                            PictureUrl = "https://m.media-amazon.com/images/I/71HN4P-pd5L._AC_SX466_.jpg ",
                            ModelName = "Galaxy A53 5G",
                            WirelessCarrier = "Unlocked for All Carriers ",
                            Brand = Brand.SAMSUNG,
                            FormFactor = "Slate ",
                            RamMemory = 8,
                            OperatingSystem = OperSystem.Android,
                            Color = " Black",
                            CellularTechnology = "5G ",
                            Year = 2022,
                            Resolution = 1080,
                            AboutThisItem = "LONG-LASTING BATTERY: Your busy life deserves a battery built for busy; Whether you’re taking a video call on your commute, catching up on your favorite show or with friends and family, your long-lasting, super fast charging battery* has your back ",
                            InternalStorageMemory = 128,
                            Bio = "SAMSUNG Galaxy A53 5G A Series Cell Phone, Factory Unlocked Android Smartphone, 128GB, 6.5” FHD Super AMOLED Screen, Long Battery Life, US Version, Black ",
                            Price = 450,
                            SIMCardSlotCount = SIMCardSlotCount.DualSIM,
                            SIMCardSize = SIMCardSize.Micro
                        },

                      new Mobile()
                        {
                            PictureUrl = "https://m.media-amazon.com/images/I/71HN4P-pd5L._AC_SX466_.jpg ",
                            ModelName = "Pixel 6 Pro",
                            WirelessCarrier = "Unlocked for All Carriers ",
                            Brand = Brand.SAMSUNG,
                            FormFactor = "Slate ",
                            RamMemory = 8,
                            OperatingSystem = OperSystem.Android,
                            Color = " Black",
                            CellularTechnology = "5G ",
                            Year = 2022,
                            Resolution = 1080,
                            AboutThisItem = "LONG-LASTING BATTERY: Your busy life deserves a battery built for busy; Whether you’re taking a video call on your commute, catching up on your favorite show or with friends and family, your long-lasting, super fast charging battery* has your back ",
                            InternalStorageMemory = 128,
                            Bio = "SAMSUNG Galaxy A53 5G A Series Cell Phone, Factory Unlocked Android Smartphone, 128GB, 6.5” FHD Super AMOLED Screen, Long Battery Life, US Version, Black ",
                            Price = 450,
                            SIMCardSlotCount = SIMCardSlotCount.DualSIM,
                            SIMCardSize = SIMCardSize.Micro
                        },

                      new Mobile()
                        {
                            PictureUrl = "https://m.media-amazon.com/images/I/71HN4P-pd5L._AC_SX466_.jpg ",
                            ModelName = "Galaxy A53 5G",
                            WirelessCarrier = "Unlocked for All Carriers ",
                            Brand = Brand.SAMSUNG,
                            FormFactor = "Slate ",
                            RamMemory = 8,
                            OperatingSystem = OperSystem.Android,
                            Color = " Black",
                            CellularTechnology = "5G ",
                            Year = 2022,
                            Resolution = 1080,
                            AboutThisItem = "LONG-LASTING BATTERY: Your busy life deserves a battery built for busy; Whether you’re taking a video call on your commute, catching up on your favorite show or with friends and family, your long-lasting, super fast charging battery* has your back ",
                            InternalStorageMemory = 128,
                            Bio = "SAMSUNG Galaxy A53 5G A Series Cell Phone, Factory Unlocked Android Smartphone, 128GB, 6.5” FHD Super AMOLED Screen, Long Battery Life, US Version, Black ",
                            Price = 450,
                            SIMCardSlotCount = SIMCardSlotCount.DualSIM,
                            SIMCardSize = SIMCardSize.Micro
                        },

                      new Mobile()
                        {
                            PictureUrl = "https://m.media-amazon.com/images/I/71HN4P-pd5L._AC_SX466_.jpg ",
                            ModelName = "Galaxy A53 5G",
                            WirelessCarrier = "Unlocked for All Carriers ",
                            Brand = Brand.SAMSUNG,
                            FormFactor = "Slate ",
                            RamMemory = 8,
                            OperatingSystem = OperSystem.Android,
                            Color = " Black",
                            CellularTechnology = "5G ",
                            Year = 2022,
                            Resolution = 1080,
                            AboutThisItem = "LONG-LASTING BATTERY: Your busy life deserves a battery built for busy; Whether you’re taking a video call on your commute, catching up on your favorite show or with friends and family, your long-lasting, super fast charging battery* has your back ",
                            InternalStorageMemory = 128,
                            Bio = "SAMSUNG Galaxy A53 5G A Series Cell Phone, Factory Unlocked Android Smartphone, 128GB, 6.5” FHD Super AMOLED Screen, Long Battery Life, US Version, Black ",
                            Price = 450,
                            SIMCardSlotCount = SIMCardSlotCount.DualSIM,
                            SIMCardSize = SIMCardSize.Micro
                        },

                      new Mobile()
                        {
                            PictureUrl = "https://m.media-amazon.com/images/I/71HN4P-pd5L._AC_SX466_.jpg ",
                            ModelName = "Galaxy A53 5G",
                            WirelessCarrier = "Unlocked for All Carriers ",
                            Brand = Brand.SAMSUNG,
                            FormFactor = "Slate ",
                            RamMemory = 8,
                            OperatingSystem = OperSystem.Android,
                            Color = " Black",
                            CellularTechnology = "5G ",
                            Year = 2022,
                            Resolution = 1080,
                            AboutThisItem = "LONG-LASTING BATTERY: Your busy life deserves a battery built for busy; Whether you’re taking a video call on your commute, catching up on your favorite show or with friends and family, your long-lasting, super fast charging battery* has your back ",
                            InternalStorageMemory = 128,
                            Bio = "SAMSUNG Galaxy A53 5G A Series Cell Phone, Factory Unlocked Android Smartphone, 128GB, 6.5” FHD Super AMOLED Screen, Long Battery Life, US Version, Black ",
                            Price = 450,
                            SIMCardSlotCount = SIMCardSlotCount.DualSIM,
                            SIMCardSize = SIMCardSize.Micro
                        },

                      new Mobile()
                        {
                            PictureUrl = "https://m.media-amazon.com/images/I/71HN4P-pd5L._AC_SX466_.jpg ",
                            ModelName = "Galaxy A53 5G",
                            WirelessCarrier = "Unlocked for All Carriers ",
                            Brand = Brand.SAMSUNG,
                            FormFactor = "Slate ",
                            RamMemory = 8,
                            OperatingSystem = OperSystem.Android,
                            Color = " Black",
                            CellularTechnology = "5G ",
                            Year = 2022,
                            Resolution = 1080,
                            AboutThisItem = "LONG-LASTING BATTERY: Your busy life deserves a battery built for busy; Whether you’re taking a video call on your commute, catching up on your favorite show or with friends and family, your long-lasting, super fast charging battery* has your back ",
                            InternalStorageMemory = 128,
                            Bio = "SAMSUNG Galaxy A53 5G A Series Cell Phone, Factory Unlocked Android Smartphone, 128GB, 6.5” FHD Super AMOLED Screen, Long Battery Life, US Version, Black ",
                            Price = 450,
                            SIMCardSlotCount = SIMCardSlotCount.DualSIM,
                            SIMCardSize = SIMCardSize.Micro
                        }



                    });
                    context.SaveChanges();
                }

            }

        }

        /* public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
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
         }*/
    }
}
