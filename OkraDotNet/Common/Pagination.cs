using Newtonsoft.Json;

namespace OkraDotNet.Common
{
    public class Pagination
    {
        [JsonProperty("totalDocs")]
        public long TotalDocs { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("hasPrevPage")]
        public bool HasPrevPage { get; set; }

        [JsonProperty("hasNextPage")]
        public bool HasNextPage { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("totalPages")]
        public long TotalPages { get; set; }

        [JsonProperty("pagingCounter")]
        public long PagingCounter { get; set; }

        [JsonProperty("prevPage")]
        public object PrevPage { get; set; }

        [JsonProperty("nextPage")]
        public object NextPage { get; set; }
    }
}