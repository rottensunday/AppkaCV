using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appka_CV.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace Appka_CV.Controllers
{

    public class JobOfferController : Controller
    {

        private EFJobOffersRepository JobOffersRepository { get; set; }
        private EFCompaniesRepository CompaniesRepository { get; set; }
        private static IConfiguration Configuration { get; set; }
        private AuthenticationContext authContext;
        private ClientCredential credential;
        private string tenant;
        private string clientId;
        private string clientSecret;
        public JobOfferController(EFJobOffersRepository repo1, EFCompaniesRepository repo2, IConfiguration config)
        {
            JobOffersRepository = repo1;
            CompaniesRepository = repo2;
            Configuration = config;
            tenant = Configuration["B2C:Tenant"];
            clientId = Configuration["B2C:ClientID"];
            clientSecret = Configuration["B2C:ClientSecret"];
            authContext = new AuthenticationContext("https://login.microsoftonline.com/" + tenant);
            credential = new ClientCredential(clientId, clientSecret);
        }

        public ViewResult Index()
        {
            Task<AuthenticationResult> result = authContext.AcquireTokenAsync("https://graph.windows.net", credential);
            HttpClient http = new HttpClient();
            string url = "https://graph.windows.net/" + tenant + "/users" + "?" + "api-version=1.6";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", result.Result.AccessToken);
            Task<HttpResponseMessage> response = http.SendAsync(request);
            Task<String> resultString = response.Result.Content.ReadAsStringAsync();

            var jsonDoc = JsonDocument.Parse(resultString.Result);
            var root = jsonDoc.RootElement;
            JsonElement valueCollection = root.GetProperty("value");
            JsonElement collection = valueCollection[0];
            foreach (var elem in valueCollection.EnumerateArray())
            {
                string ObjectID = elem.GetProperty("objectId").GetString();
                if (elem.TryGetProperty("extension_644097f3a9a845d8b34d5f41f88e64e6_IsAdmin", out collection) == false)
                {
                    AddUser(ObjectID);
                }
            }
            return View(JobOffersRepository.JobOffers);
        }

        [Authorize(Policy = "HROnly")]
        [HttpGet]
        public ViewResult AddOffer(int id)
        {
            return View(id);
        }

        public void AddUser(string objectId)
        {
            Task<AuthenticationResult> result = authContext.AcquireTokenAsync("https://graph.windows.net", credential);
            HttpClient http = new HttpClient();
            string url = "https://graph.windows.net/" + tenant + "/users/" + objectId + "?" + "api-version=1.6";
            HttpRequestMessage request = new HttpRequestMessage(new HttpMethod("PATCH"), url);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", result.Result.AccessToken);
            string JsonRequest;

            JsonRequest = "{\"extension_644097f3a9a845d8b34d5f41f88e64e6_IsHR\": false,";
            JsonRequest += "\"extension_644097f3a9a845d8b34d5f41f88e64e6_IsAdmin\": false}";

            request.Content = new StringContent(JsonRequest, Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> response = http.SendAsync(request);

            response.Wait();
            System.Threading.Thread.Sleep(4000);
            return;

        }
    }
}
