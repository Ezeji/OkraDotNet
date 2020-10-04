using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Common.Responses
{
    public class PeriodicResponse : BaseResponse, IBaseResponse<PeriodicResponseData>
    {
        [JsonProperty("data")]
        public PeriodicResponseData Data { get; set; }
    }

    public class PeriodicResponseData
    {
        [JsonProperty("callback_url")]
        public Uri CallbackUrl { get; set; }
    }
}