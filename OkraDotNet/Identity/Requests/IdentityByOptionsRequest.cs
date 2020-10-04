using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Identity.Requests
{
    public class IdentityByOptionsRequest : PaginatedRequest
    {
        public dynamic Options { get; set; }
    }

    //public class Options
    //{
    //    public string FirstName { get; set; }

    //    public string LastName { get; set; }
    //}
}