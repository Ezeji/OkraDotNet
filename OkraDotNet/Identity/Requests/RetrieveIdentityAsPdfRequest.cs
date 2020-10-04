using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Identity.Requests
{
    public class RetrieveIdentityAsPdfRequest : PaginatedRequest
    {
        public bool Pdf { get; set; } = true;
    }
}