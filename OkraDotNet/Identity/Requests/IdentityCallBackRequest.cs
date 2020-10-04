using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Identity.Requests
{
    public class IdentityCallBackRequest
    {
        public string Record { get; set; }

        public string Method { get; } = CallBackRequestTypes.IDENTITY;
    }
}