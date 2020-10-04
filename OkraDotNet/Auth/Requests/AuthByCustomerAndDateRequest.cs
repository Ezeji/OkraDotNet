namespace OkraDotNet.Auth.Requests
{
    public class AuthByCustomerAndDateRequest : AuthByDateRequest
    {
        public string Customer { get; set; }
    }
}