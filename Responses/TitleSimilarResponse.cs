using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiHarbor.RapidApi.DataOcean.NetflixApi.Responses
{
    public class TitleSimilarResponse
    {
        public static Root Create(string json)
        {
            Root root = JsonConvert.DeserializeObject<Root>(json);
            return root;
        }
        
        public class Data
        {
            [JsonProperty("paging")]
            public Paging Paging { get; set; }

            [JsonProperty("similar")]
            public List<Similar> Similar { get; set; }
        }

        public class Details
        {
            [JsonProperty("html")]
            public string Html { get; set; }
        }

        public class Links
        {
            [JsonProperty("details")]
            public Details Details { get; set; }
        }

        public class Paging
        {
            [JsonProperty("next_page")]
            public string NextPage { get; set; }

            [JsonProperty("prev_page")]
            public string PrevPage { get; set; }
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
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("original_title")]
            public string OriginalTitle { get; set; }

            [JsonProperty("release_date")]
            public DateTime? ReleaseDate { get; set; }

            [JsonProperty("origin_country")]
            public string OriginCountry { get; set; }

            [JsonProperty("original_language")]
            public string OriginalLanguage { get; set; }

            [JsonProperty("overview")]
            public string Overview { get; set; }

            [JsonProperty("vote_average")]
            public double? VoteAverage { get; set; }

            [JsonProperty("vote_count")]
            public int? VoteCount { get; set; }

            [JsonProperty("tmdb_poster_url")]
            public string TmdbPosterUrl { get; set; }

            [JsonProperty("_links")]
            public Links Links { get; set; }
        }


    }
}
