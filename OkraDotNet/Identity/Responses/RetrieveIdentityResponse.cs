using Newtonsoft.Json;
using OkraDotNet.Common;
using OkraDotNet.Common.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Identity.Responses
{
    public class RetrieveIdentityResponse : BaseResponse, IBaseResponse<RetrieveIdentityResponseData>
    {
        [JsonProperty("data")]
        public RetrieveIdentityResponseData Data { get; set; }
    }

    public class RetrieveIdentityResponseData
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("identities")]
        public List<RetrieveIdentityResponseIdentity> Identities { get; set; }
    }

    public class RetrieveIdentityResponseIdentity
    {
        [JsonProperty("fullname")]
        public string Fullname { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("bvn")]
        public string Bvn { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }

        [JsonProperty("env")]
        public string Env { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("aliases")]
        public List<string> Aliases { get; set; }

        [JsonProperty("customer")]
        public CommonCustomer Customer { get; set; }

        [JsonProperty("dob")]
        public string Dob { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("middlename")]
        public object Middlename { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("phone")]
        public List<string> Phone { get; set; }

        [JsonProperty("email")]
        public List<string> Email { get; set; }

        [JsonProperty("address")]
        public List<string> Address { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("photo_id")]
        public List<RetrieveIdentityResponsePhotoId> PhotoId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class RetrieveIdentityResponsePhotoId
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("image_type")]
        public string ImageType { get; set; }
    }

    public class RetrieveIdentityAsPdfResponse : BaseResponse, IBaseResponse<string>
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}