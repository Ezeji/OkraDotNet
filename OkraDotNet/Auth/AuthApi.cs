using CSharpFunctionalExtensions;
using OkraDotNet.Auth.Requests;
using OkraDotNet.Auth.Responses;
using OkraDotNet.Common;
using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OkraDotNet.Auth
{
    public interface IAuthApi
    {
        /// <summary>
        /// Allows you to fetch authentication info using the bank id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<AuthResponseData, OkraError>> AuthByBankAsync(AuthByBankRequest request);

        /// <summary>
        /// Allows you to fetch authentication info using the customer id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<AuthResponseData, OkraError>> AuthByCustomerAsync(AuthByCustomerRequest request);

        /// <summary>
        /// Allows you to fetch authentication for a customer  using a date range and customer id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<AuthResponseData, OkraError>> AuthByCustomerAndDateAsync(AuthByCustomerAndDateRequest request);

        /// <summary>
        /// Allows you to fetch authentication info using a date range
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<AuthResponseData, OkraError>> AuthByDateAsync(AuthByDateRequest request);

        /// <summary>
        /// Allows you to fetch authentication info using the id
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<AuthResponseData, OkraError>> AuthByIdAsync(AuthByIdRequest request);

        /// <summary>
        /// Pulls successful bank verification for customers
        /// </summary>
        /// <returns></returns>
        Task<Result<RetrieveAuthResponseData, OkraError>> RetrieveAuthAsync(PaginatedRequest request);

        /// <summary>
        /// Pulls successful bank verification for customers as pdf file link
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<string, OkraError>> RetrieveAuthAsPdfAsync(PaginatedRequest request);

        /// <summary>
        /// Pull data from callback url
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<Result<AuthCallbackResponseData, OkraError>> AuthCallBackAsync(string record);
    }

    public class AuthApi : IAuthApi
    {
        private readonly OkraApi _okraApi;

        public AuthApi(OkraApi okraApi)
        {
            _okraApi = okraApi;
        }

        public async Task<Result<RetrieveAuthResponseData, OkraError>> RetrieveAuthAsync(PaginatedRequest request)
        {
            var url = "products/auths";

            var response = await _okraApi.Post<RetrieveAuthResponse, PaginatedRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<string, OkraError>> RetrieveAuthAsPdfAsync(PaginatedRequest request)
        {
            var url = "products/auths";

            var response = await _okraApi.Post<RetrieveAuthAsPdfResponse, RetrieveAuthAsPdfRequest>(url,
                new RetrieveAuthAsPdfRequest { Limit = request.Limit, Page = request.Page });

            return response.ToResult();
        }

        public async Task<Result<AuthResponseData, OkraError>> AuthByIdAsync(AuthByIdRequest request)
        {
            var url = "auth/getById";

            var response = await _okraApi.Post<AuthResponse, AuthByIdRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<AuthResponseData, OkraError>> AuthByCustomerAsync(AuthByCustomerRequest request)
        {
            var url = "auth/getByCustomer";

            var response = await _okraApi.Post<AuthResponse, AuthByCustomerRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<AuthResponseData, OkraError>> AuthByDateAsync(AuthByDateRequest request)
        {
            var url = "auth/getByDate";

            var response = await _okraApi.Post<AuthResponse, AuthByDateRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<AuthResponseData, OkraError>> AuthByBankAsync(AuthByBankRequest request)
        {
            var url = "auth/getByBank";

            var response = await _okraApi.Post<AuthResponse, AuthByBankRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<AuthResponseData, OkraError>> AuthByCustomerAndDateAsync(AuthByCustomerAndDateRequest request)
        {
            var url = "auth/getByCustomerDate";

            var response = await _okraApi.Post<AuthResponse, AuthByCustomerAndDateRequest>(url, request);

            return response.ToResult();
        }

        public async Task<Result<AuthCallbackResponseData, OkraError>> AuthCallBackAsync(string record)
        {
            var url = "callback";

            var request = new AuthCallBackRequest
            {
                Record = record
            };

            var response =
                await _okraApi.Get<AuthCallbackResponse, AuthCallBackRequest>(url, request);

            return response.ToResult();
        }
    }
}