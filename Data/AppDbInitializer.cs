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
                            FullName = "Windows",
                            Bio = "Rodzina systemów operacyjnych stworzonych przez firmę Microsoft. Systemy rodziny Windows działają na serwerach, systemach wbudowanych oraz na komputerach osobistych, z którymi są najczęściej kojarzone.",
                            ProfilePictureURL = "https://i.imgur.com/RIMTfDI.png"

                        },
                        new Platform()
                        {
                            FullName = "Steam",
                            Bio = "Platforma dystrybucji cyfrowej i zarządzania prawami cyfrowymi, system gry wieloosobowej oraz serwis społecznościowy stworzony przez Valve Corporation. W październiku 2012 roku Valve rozszerzyło ofertę o oprogramowanie niebędące grami.",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Steam_icon_logo.svg/800px-Steam_icon_logo.svg.png"
                        },
                        new Platform()
                        {
                            FullName = "Adobe Creative Cloud",
                            Bio = "Adobe Creative Cloud to zestaw aplikacji i usług firmy Adobe Inc., który zapewnia subskrybentom dostęp do zbioru oprogramowania używanego do projektowania graficznego, edycji wideo, tworzenia stron internetowych, fotografii, a także zestawu aplikacji mobilnych, a także niektórych opcjonalnych usług w chmurze.",
                            ProfilePictureURL = "https://i.imgur.com/z9RrE49.png"
                        },
                        new Platform()
                        {
                            FullName = "Norton",
                            Bio = "Marka Norton oferuje zaliczające się do najlepszych w branży oprogramowanie antywirusowe i zabezpieczające dla komputerów PC i Mac oraz urządzeń przenośnych. Pobierz plan Norton™ 360 — chroń swoje urządzenia przed wirusami, oprogramowaniem wymuszającym okup, oprogramowaniem destrukcyjnym i innymi zagrożeniami pochodzącymi z Internetu.",
                            ProfilePictureURL = "https://i.imgur.com/ICTM523.png"
                        },
                        new Platform()
                        {
                            FullName = "Subiekt GT",
                            Bio = "Subiekt GT to nowoczesny system sprzedaży stworzony z myślą o firmach, które poszukują sprawnego narzędzia wspomagającego całościową obsługę działu handlowego, sklepu, punktu usługowego, itp.",
                            ProfilePictureURL = "https://fpc.pl/wp-content/uploads/2022/04/Insert-Subiekt-GT-%E2%80%93-Licencja-Elektroniczna.png"
                        },
                        new Platform()
                        {
                            FullName = "Origin",
                            Bio = "Platforma firmy Electronic Arts pełniąca funkcję sklepu z grami w wersji cyfrowej oraz systemu kontroli dostępu do danych w formie cyfrowej.",
                            ProfilePictureURL = "https://i.imgur.com/GRPeJb8.png"
                        },
                        new Platform()
                        {
                            FullName = "Allegro.pl",
                            Bio = "Największa platforma e-handlu w Polsce. Portal należy do przedsiębiorstwa Allegro Sp. z o.o.",
                            ProfilePictureURL = "https://i.imgur.com/4YTIyfA.png"
                        },
                        new Platform()
                        {
                            FullName = "ESET Internet",
                            Bio = "ESET Internet Security to wszechstronna ochrona podczas codziennego korzystania z Internetu, oferująca idealne połączenie szybkości, skuteczności i funkcjonalności.",
                            ProfilePictureURL = "https://i.imgur.com/I7Q3fYL.png"
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
                            FullName = "Microsoft",
                            Bio = "Amerykańskie przedsiębiorstwo informatyczne. Najbardziej znane jako producent systemów operacyjnych MS-DOS, Microsoft Windows i oprogramowania biurowego Microsoft Office. Spółka publiczna z siedzibą w Redmond w stanie Waszyngton. Założona w 1975 roku przez Billa Gatesa i Paula Allena.",
                            ProfilePictureURL = "https://i.imgur.com/JuX7YVh.png"

                        },
                        new Producer()
                        {
                            FullName = "Valve",
                            Bio = "Amerykański producent gier komputerowych. Valve jest twórcą serii Half-Life oraz Counter-Strike. W 2003 przedsiębiorstwo uruchomiło platformę dystrybucji cyfrowej Steam.",
                            ProfilePictureURL = "https://i.imgur.com/h4MsuCc.png"
                        },
                        new Producer()
                        {
                            FullName = "Adobe",
                            Bio = "Amerykańskie przedsiębiorstwo informatyczne z siedzibą w San Jose, w stanie Kalifornia, znane z projektowania szeroko rozumianego oprogramowania graficznego dla systemów macOS i Windows. ",
                            ProfilePictureURL = "https://i.imgur.com/UkddR3l.png"
                        },
                        new Producer()
                        {
                            FullName = "NortonLifeLock",
                            Bio = "Amerykańskie przedsiębiorstwo założone w 1982 roku. Jest to międzynarodowa firma sprzedająca oprogramowanie komputerowe, szczególnie koncentrując się na dziedzinie bezpieczeństwa danych i zarządzania informacjami.",
                            ProfilePictureURL = "https://i.imgur.com/8tdPbT0.png"
                        },
                        new Producer()
                        {
                            FullName = "InsERT",
                            Bio = "InsERT jest liderem rynku oprogramowania dla mikro-, małych i średnich firm. Oferuje nowoczesne i proste w obsłudze systemy wspomagające zarządzanie.\r\n",
                            ProfilePictureURL = "https://www.insert.com.pl/.grafika/interfejs/najlepsze_programy_dla_firm.png"
                        },
                        new Producer()
                        {
                            FullName = "Electronic Arts",
                            Bio = "Amerykański producent oraz wydawca gier komputerowych. Jest to drugie co do wielkości przedsiębiorstwo zajmujące się grami w obu Amerykach i Europie pod względem przychodów i kapitalizacji rynkowej po Activision Blizzard, a wyprzedzające Take-Two Interactive, CD Projekt i Ubisoft. ",
                            ProfilePictureURL = "https://i.imgur.com/vx4GSC2.png"
                        },
                        new Producer()
                        {
                            FullName = "Allegro",
                            Bio = "Polska spółka z branży e-commerce z siedzibą w Poznaniu, prowadząca serwis allegro.pl. Była częścią południowoafrykańskiego koncernu mediowego Naspers[2]. Od października 2016 należy do funduszy Cinven, Permira i Mid Europa[3][4]. Bezpośrednim właścicielem spółki jest, notowana od października 2020 na Giełdzie Papierów Wartościowych w Warszawie, spółka Allegro.eu S.A.\r\n\r\n",
                            ProfilePictureURL = "https://i.imgur.com/gXU4h3W.png"
                        },
                        new Producer()
                        {
                            FullName = "ESET",
                            Bio = "Słowackie przedsiębiorstwo informatyczne z siedzibą w Bratysławie, założone w roku 1992 przez Miroslava Trnkę, Petera Paško i Rudolfa Hrubego. Zajmuje się tworzeniem oprogramowania antywirusowego.",
                            ProfilePictureURL = "https://in.eset.pl/storage/www_nowyeset/special/fornax/logo.png"
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
                            Name = "Windows 10 Home",
                            Description = "Windows 10 – wersja systemu operacyjnego Microsoft Windows, która została wydana 29 lipca 2015 roku. Do 29 lipca 2016 roku możliwa była darmowa aktualizacja systemu Windows 7 lub 8.1 do Windowsa 10.",
                            Price = 199.00,
                            ImageURL = "https://kluczesoft.pl/28-thickbox_default/microsoft-windows-10-home.jpg",
                            ProducerId = 1,
                            ProductCategory = ProductCategory.OperatingSystem
                        },
                        new Product()
                        {
                            Name = "Norton 360 Standard",
                            Description = "Program Norton 360 Standard zapewnia kompleksową ochronę przed oprogramowaniem destrukcyjnym pojedynczego komputera PC lub Mac albo urządzenia z systemem Android lub iOS, a także kopię zapasową w chmurze4, dla komputera PC, aby zapobiec utracie danych z powodu oprogramowania wymuszającego okup lub awarii dysku twardego, a także rozszerzenie Password Manager do przechowywania haseł i zarządzania nimi.",
                            Price = 89.00,
                            ImageURL = "https://www.mediaexpert.pl/media/cache/resolve/gallery/images/23/2332312/Antywirus-NORTON-360-Standard-10GB-1-Urzadzenie-1-Rok-front.jpg",
                            ProducerId = 4,
                            ProductCategory = ProductCategory.Antivirus
                        },
                        new Product()
                        {
                            Name = "Windows 11 Pro",
                            Description = "System Windows 11, zaprojektowany z myślą o pracy hybrydowej, ułatwia i bezproblemowo pracę z dowolnego miejsca.\r\n\r\nProste, skuteczne środowisko użytkownika pomaga zwiększyć produktywność i skupienie.\r\nNowe funkcje umożliwiają maksymalne wykorzystanie dostępnego miejsca na pulpicie.\r\nZgodność aplikacji i zarządzanie chmurą ułatwiają wdrażanie.\r\nSystem operacyjny z modelem zabezpieczeń Zeto Trust pomaga chronić dane i dostęp wszędzie tam, gdzie wysyła Cię praca.",
                            Price = 525.00,
                            ImageURL = "https://prod-api.mediaexpert.pl/api/images/gallery_500_500/thumbnails/images/32/3290325/Program-MICROSOFT-Windows-11-Pro-PL-x64-DVD-OEM-front.jpg",
                            ProducerId = 1,
                            ProductCategory = ProductCategory.OperatingSystem
                        },
                        new Product()
                        {
                            Name = "Photoshop Elements 2023",
                            Description = "Oprogramowanie Adobe Photoshop Elements 2023 służy do obróbki zdjęć. Jest przeznaczone dla wszystkich osób, które chcą tworzyć wspaniałe materiały oparte na fotografiach. Zakup jest jednorazowy — nie wymaga członkostwa.\r\n\r\n",
                            Price = 375.00,
                            ImageURL = "https://www.swisssoftware24.pl/media/cache/isoshop_box_image/d7/23/9eac479a20ab1600014c322d8245.png",
                            ProducerId = 3,
                            ProductCategory = ProductCategory.Graphics
                        },
                        new Product()
                        {
                            Name = "Insert Subiekt GT",
                            Description = "Subiekt GT jest sprawnym i szybkim systemem wyposażonym w najnowsze rozwiązania interfejsowe czyniące go programem bardzo ergonomicznym i przyjaznym dla użytkownika. Jednocześnie jego wszechstronność i możliwości konfiguracji czynią go produktem niemal dla każdego.\r\n\r\n",
                            Price = 599.00,
                            ImageURL = "https://fpc.pl/wp-content/uploads/2022/04/Insert-Subiekt-GT-%E2%80%93-Wersja-pudelkowa_34521.png",
                            ProducerId = 5,
                            ProductCategory = ProductCategory.Financial
                        },
                        new Product()
                        {
                            Name = "ESET Internet Security",
                            Description = "ESET Internet Security to antywirus, dzięki któremu wszystko, co robisz w Internecie, jest skutecznie zabezpieczone. Pakiet ESET Internet Security chroni przed ransomware i hakerami, zabezpieczając jednocześnie wszystkie urządzenia podłączone do Wi-Fi. Dzięki ESET możesz bezpiecznie korzystać z bankowości internetowej, nie martwiąc się o to, że Twoje hasła lub dane zostaną wykradzione. W ramach pakietu otrzymujesz również opcję kontroli rodzicielskiej oraz zabezpieczenie antyphishingowe.",
                            Price = 155.00,
                            ImageURL = "https://az.pl/img/cms/b454bcd0-158c-408c-92e0-ea59ac74b765/eset-internet-security.png?version=0/eset-internet-security.png",
                            ProducerId = 8,
                            ProductCategory = ProductCategory.Antivirus
                        },
                        new Product()
                        {
                            Name = "FIFA 23",
                            Description = "FIFA 23 wnosi na boisko jeszcze więcej energii i realizmu piłki nożnej. Dzięki rozbudowie technologii HyperMotion2, uzyskanej dzięki dwa razy większej bazie motion capture, w każdym meczu zobaczysz więcej autentycznych animacji niż kiedykolwiek przedtem. Zagraj w najważniejszych turniejach piłkarskich, w tym w nadchodzących pucharach mistrzostw świata (FIFA World Cup™) mężczyzn i kobiet. ",
                            Price = 179.99,
                            ImageURL = "https://prod-api.mediaexpert.pl/api/images/gallery_500_500/thumbnails/images/39/3959630/FIFA-23-Gra-PC-Okladka-1.jpg",
                            ProducerId = 6,
                            ProductCategory = ProductCategory.Games
                        },
                        new Product()
                        {
                            Name = "ALLEGRO 50PLN",
                            Description = "Voucher o wartości 50zł do wykorzystania w serwisie ALLEGRo.PL. Karta podarunkowa jest ważna co najmniej 6 miesięcy od daty zakupu. Szczegółową datę ważności dostaniesz wraz z kodem.",
                            Price = 50.00,
                            ImageURL = "https://i.imgur.com/LRbGIpe.png",
                            ProducerId = 7,
                            ProductCategory = ProductCategory.Voucher
                        },
                        new Product()
                        {
                            Name = "Microsoft 365 Personal",
                            Description = "Microsoft 365 Personal - Aplikacje Office w wersji premium, dodatkowe miejsce w chmurze, zaawansowane zabezpieczenia i nie tylko wszystko w jednej wygodnej subskrypcji.",
                            Price = 299.00,
                            ImageURL = "https://prod-api.mediamarkt.pl/api/images/gallery_545_400/thumbnails/images/21/21109206/new1_personal.jpg",
                            ProducerId = 1,
                            ProductCategory = ProductCategory.Office
                        },
                        new Product()
                        {
                            Name = "Counter-Strike: Global Offensive Prime",
                            Description = "CS: GO to wieloosobowa strzelanka, w której widok przedstawiony jest z perspektywy oczu bohatera, w którego się wcielasz. Stajesz się członkiem jednej z losowych drużyn — terrorystów lub antyterrorystów, którzy toczą ze sobą walkę na jednej map. Zadaniem terrorystów jest podłożenie bomby lub obrona wziętych przez siebie zakładników. Antyterroryści zwyciężą, jeśli wyeliminują swoich przeciwników w określonym czasie.",
                            Price = 68.50,
                            ImageURL = "https://image.ceneostatic.pl/data/article_picture/dc/0d/208b-d7e0-4a32-8ca2-ecd287d311e0_medium.jpg",
                            ProducerId = 2,
                            ProductCategory = ProductCategory.Games
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
                            PlatformId = 1,
                            ProductId = 1
                        },
                        new Platform_Product()
                        {
                            PlatformId = 4,
                            ProductId = 2
                        },
                        new Platform_Product()
                        {
                            PlatformId = 1,
                            ProductId = 3
                        },
                        new Platform_Product()
                        {
                            PlatformId = 3,
                            ProductId = 4
                        },
                        new Platform_Product()
                        {
                            PlatformId = 5,
                            ProductId = 5
                        },
                        new Platform_Product()
                        {
                            PlatformId = 8,
                            ProductId = 6
                        },
                        new Platform_Product()
                        {
                            PlatformId = 6,
                            ProductId = 7
                        },
                        new Platform_Product()
                        {
                            PlatformId = 7,
                            ProductId = 8
                        },
                        new Platform_Product()
                        {
                            PlatformId = 1,
                            ProductId = 9
                        },
                        new Platform_Product()
                        {
                            PlatformId = 2,
                            ProductId = 10
                        }
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
