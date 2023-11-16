using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiHarbor.RapidApi.DataOcean.NetflixApi.Responses
{
    public class TitleListsResponse
    {
        public static Root Create(string json)
        {
            Root root = JsonConvert.DeserializeObject<Root>(json);
            return root;
        }
        public class Credits
        {
            [JsonProperty("href")]
            public string Href { get; set; }
        }

        public class Data
        {
            [JsonProperty("pagination")]
            public Pagination Pagination { get; set; }

            [JsonProperty("titles")]
            public List<_Title> Titles { get; set; }

            [JsonProperty("is_empty")]
            public bool IsEmpty { get; set; }
        }

        public class Details
        {
            [JsonProperty("href")]
            public string Href { get; set; }
        }

        public class Links
        {
            [JsonProperty("details")]
            public Details Details { get; set; }

            [JsonProperty("similar")]
            public Similar Similar { get; set; }

            [JsonProperty("media")]
            public Media Media { get; set; }

            [JsonProperty("credits")]
            public Credits Credits { get; set; }
        }

        public class Media
        {
            [JsonProperty("href")]
            public string Href { get; set; }
        }

        public class Pagination
        {
            [JsonProperty("has_next_page")]
            public bool HasNextPage { get; set; }

            [JsonProperty("next_page_url")]
            public string NextPageUrl { get; set; }

            [JsonProperty("next_page_token")]
            public string NextPageToken { get; set; }

            [JsonProperty("total_count")]
            public int? TotalCount { get; set; }

            [JsonProperty("total_pages")]
            public int? TotalPages { get; set; }
        }

        public class Root
        {
            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("status")]
            public int? Status { get; set; }

            [JsonProperty("data")]
            public Data Data { get; set; }
        }

        public class Similar
        {
            [JsonProperty("href")]
            public string Href { get; set; }
        }

        public class _Title
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("rating")]
            public double? Rating { get; set; }

            [JsonProperty("_links")]
            public Links Links { get; set; }
        }


    }
}
