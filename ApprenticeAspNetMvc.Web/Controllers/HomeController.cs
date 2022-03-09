using ApprenticeAspNetMvc.Web.Jason;
using ApprenticeAspNetMvc.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace ApprenticeAspNetMvc.Web.Controllers {
    public class HomeController : Controller {

       // private static readonly HttpClient client = new HttpClient();

        private static readonly HttpClient clientWiki = new HttpClient();

        private const string URL = "https://randomuser.me/api/";

        private const string URLWiki = "https://en.wikipedia.org/api/rest_v1/feed/featured/";

       

        private readonly ILogger<HomeController> _logger;
        private readonly ApprenticeAspNetMvcContext _context;
        public HomeController(ApprenticeAspNetMvcContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

       

        public  async Task<IActionResult> Index() {

           HttpClient client = new HttpClient();

            HttpClient clientWiki = new HttpClient();

            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

           // HttpRequestMessage msg = new HttpRequestMessage
           // {
           //     Method = HttpMethod.Put,
           //     RequestUri = new Uri(URL),
           //     //Headers = new HttpRequestHeaders;
           // };
           // msg.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

           //await client.SendAsync(msg);


            bool checkUser = false;
            
            while(checkUser == false)
            {
                var response = await client.GetStreamAsync(URL);
                var newResult = await JsonSerializer.DeserializeAsync<RootObject>(response);

                foreach (var item in newResult.Results)
                {
                    if (_context.Users.Where(u=> u.UuId == item.Login.Uuid).Any())
                    {
                        checkUser = false;
                    }
                    else
                    {
                        var newUser = new User(item);

                        await _context.AddAsync(newUser);

                        checkUser = true;
                    }

            }
            


            }

            string WikiURL = URLWiki + WikipediaArticle.DateConverter();
            clientWiki.BaseAddress = new Uri(WikiURL);
            clientWiki.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            var responseWiki = await clientWiki.GetStreamAsync(WikiURL);
            var wikiResult = await JsonSerializer.DeserializeAsync<WikiRootObject>(responseWiki);

            int checkDailyWikipediaArticle = _context.WikipediaArticles
                .Where(u=> u.CreateDate == DateTime.Now.Date)
                .Count();
            if(checkDailyWikipediaArticle == 0)
            {
                var newWiki = new WikipediaArticle(wikiResult);

                await _context.AddAsync(newWiki);
            }

           await _context.SaveChangesAsync();


            return View(await GetUser());
        }

        public async Task<List<User>> GetUser()
        {

            ApprenticeAspNetMvcContext context = new ApprenticeAspNetMvcContext();
            List<User> users = new List<User>();

            Random random = new Random();

            int randomNumber = random.Next(1, _context.Users
                .Count());

            users = await  _context.Users
                .Where(u => u.Id == randomNumber)
                .ToListAsync();



            return users;

            //}
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}