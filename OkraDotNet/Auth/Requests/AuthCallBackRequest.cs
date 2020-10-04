using OkraDotNet.Common.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Auth.Requests
{
    public class AuthCallBackRequest
    {
        public string Record { get; set; }

        public string Method { get; } = CallBackRequestTypes.AUTH;
    }
}