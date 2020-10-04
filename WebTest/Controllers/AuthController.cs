using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Mvc;
using OkraDotNet;
using OkraDotNet.Auth;
using OkraDotNet.Auth.Requests;
using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : BaseController
    {
        private readonly IAuthApi _api;

        public AuthController(OkraApi api)
        {
            _api = api.Auth;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RetrieveAuth(PaginatedRequest request) => Result(await _api.RetrieveAuthAsync(request));

        [HttpPost("[action]")]
        public async Task<IActionResult> AuthById([FromForm] AuthByIdRequest request) => Result(await _api.AuthByIdAsync(request));

        [HttpPost("[action]")]
        public async Task<IActionResult> AuthByBank([FromForm] AuthByBankRequest request) => Result(await _api.AuthByBankAsync(request));

        [HttpPost("[action]")]
        public async Task<IActionResult> AuthByCustomer([FromForm] AuthByCustomerRequest request) => Result(await _api.AuthByCustomerAsync(request));

        [HttpPost("[action]")]
        public async Task<IActionResult> AuthByCustomerAndDate([FromForm] AuthByCustomerAndDateRequest request) => Result(await _api.AuthByCustomerAndDateAsync(request));

        [HttpPost("[action]")]
        public async Task<IActionResult> AuthByDate([FromForm] AuthByDateRequest request) => Result(await _api.AuthByDateAsync(request));
    }
}