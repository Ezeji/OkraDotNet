using Newtonsoft.Json;
using OkraDotNet.Common;
using OkraDotNet.Common.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace OkraDotNet.Identity.Responses
{
    public class IdentityResponse : BaseResponse, IBaseResponse<IdentityResponseData>
    {
        [JsonProperty("data")]
        public IdentityResponseData Data { get; set; }
    }

    public partial class IdentityResponseData
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("identity")]
        public List<Identity> Identity { get; set; }
    }

    public partial class Identity
    {
        [JsonProperty("enrollment")]
        public Enrollment Enrollment { get; set; }

        [JsonProperty("aliases")]
        public List<string> Aliases { get; set; }

        [JsonProperty("phone")]
        public List<string> Phone { get; set; }

        [JsonProperty("email")]
        public List<string> Email { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("next_of_kins")]
        public List<object> NextOfKins { get; set; }

        [JsonProperty("address")]
        public List<string> Address { get; set; }

        [JsonProperty("record")]
        public object Record { get; set; }

        [JsonProperty("bvn_updated")]
        public bool BvnUpdated { get; set; }

        [JsonProperty("smileId")]
        public bool SmileId { get; set; }

        [JsonProperty("ref_ids")]
        public List<object> RefIds { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("bvn")]
        public string Bvn { get; set; }

        [JsonProperty("__v")]
        public long V { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("customer")]
        public CommonCustomer Customer { get; set; }

        [JsonProperty("dob")]
        public DateTimeOffset Dob { get; set; }

        [JsonProperty("env")]
        public string Env { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("fullname")]
        public string Fullname { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("marital_status")]
        public object MaritalStatus { get; set; }

        [JsonProperty("middlename")]
        public object Middlename { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("level_of_account")]
        public string LevelOfAccount { get; set; }

        [JsonProperty("lga_of_origin")]
        public string LgaOfOrigin { get; set; }

        [JsonProperty("lga_of_residence")]
        public string LgaOfResidence { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("photo_id")]
        public List<PhotoId> PhotoId { get; set; }

        [JsonProperty("state_of_origin")]
        public string StateOfOrigin { get; set; }

        [JsonProperty("state_of_residence")]
        public string StateOfResidence { get; set; }

        [JsonProperty("watch_listed")]
        public string WatchListed { get; set; }
    }

    public partial class Enrollment
    {
        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("branch")]
        public string Branch { get; set; }

        [JsonProperty("registration_date")]
        public string RegistrationDate { get; set; }
    }

    public partial class PhotoId
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("image_type")]
        public string ImageType { get; set; }

        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}