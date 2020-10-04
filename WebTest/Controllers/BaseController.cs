using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Mvc;
using OkraDotNet.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTest.Controllers
{
    public class BaseController : ControllerBase
    {
        public IActionResult Result<T>(Result<T, OkraError> result)
        {
            if (result.IsFailure) return BadRequest(result.Error);
            else return Ok(result.Value);
        }
    }
}