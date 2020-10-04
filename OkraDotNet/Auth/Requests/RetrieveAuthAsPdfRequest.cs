using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Auth.Requests
{
    internal class RetrieveAuthAsPdfRequest : PaginatedRequest
    {
        public bool Pdf { get; set; } = true;
    }
}