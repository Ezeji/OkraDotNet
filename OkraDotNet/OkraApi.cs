using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using OkraDotNet.Auth;
using OkraDotNet.Balance;
using OkraDotNet.Common;
using OkraDotNet.Identity;
using OkraDotNet.Income;
using OkraDotNet.Transactions;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OkraDotNet
{
    public class OkraApi
    {
        private readonly HttpClient _client;

        public OkraApi(string accessToken, bool useSandBox)
        {
            if (string.IsNullOrWhiteSpace(accessToken))
                throw new ArgumentException("Okra api token cannot be empty", nameof(accessToken));

            var baseUrl = useSandBox ? "https://api.okra.ng/sandbox/v2/" : "https://api.okra.ng/v2/";

            _client = CreateClient(baseUrl, accessToken);
            InitializeProducts();
        }

        public OkraApi(string accessToken, string baseApiUrl)
        {
            _client = CreateClient(baseApiUrl, accessToken);
            InitializeProducts();
        }

        private void InitializeProducts()
        {
            Auth = new AuthApi(this);
            Balance = new BalanceApi(this);
            Identity = new IdentityApi(this);
            Income = new IncomeApi(this);
            Transactions = new TransactionsApi(this);
        }

        private HttpClient CreateClient(string baseUrl, string accessToken)
        {
            //When an application requests a connection to an Internet resource Uniform Resource
            //Identifier(URI) through the ServicePointManager object, the ServicePointManager returns
            //a ServicePoint object that contains connection information for the host and scheme identified
            //by the URI.If there is an existing ServicePoint object for that host and scheme,
            //the ServicePointManager object returns the existing ServicePoint object; otherwise,
            //the ServicePointManager object creates a new ServicePoint object.
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var client = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }

        public IAuthApi Auth { get; private set; }

        public IBalanceApi Balance { get; private set; }

        public IIdentityApi Identity { get; private set; }

        public IIncomeApi Income { get; private set; }

        public ITransactionsApi Transactions { get; private set; }

        internal async Task<TRes> Post<TRes, TReq>(string relativeUrl, TReq request) where TRes : IBaseResponse
        {
            var serializedRequest = JsonConvert.SerializeObject(request, Formatting.None, RequestSerializationSettings);

            var rawJson = await _client.PostAsync(relativeUrl, new StringContent(serializedRequest, Encoding.UTF8, "application/json")).Result.Content.ReadAsStringAsync();

            var serializeSettings = new JsonSerializerSettings();
            //serializeSettings.Converters.Add(new EnvConverter());

            return JsonConvert.DeserializeObject<TRes>(rawJson, serializeSettings);
        }

        internal async Task<TRes> Get<TRes, T>(string relativeUrl, T request)
            where TRes : class
        {
            var queryString = "";
            if (request != null)
                queryString = "?" + request.ToQueryString();

            var rawJson = await _client.GetAsync(relativeUrl + queryString).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TRes>(rawJson);
        }

        internal static JsonSerializerSettings RequestSerializationSettings { get; } = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate
        };
    }

    public static class Extension
    {
        public static string ToQueryString(this object request)
        {
            var properties = from p in request.GetType().GetProperties()
                             let v = p.GetValue(request, null)
                             where v != null
                             select p.Name.ToLower() + "=" + HttpUtility.UrlEncode(v.ToString());

            return string.Join("&", properties.ToArray());
        }
    }
}