using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiHarbor.RapidApi.DataOcean.NetflixApi.Responses
{
    public class TitleMediaResponse
    {
        public static Root Create(string json)
        {
            Root root = JsonConvert.DeserializeObject<Root>(json);
            return root;
        }

        public class Data
        {
            [JsonProperty("videos")]
            public List<Video> Videos { get; set; }

            [JsonProperty("backdrops")]
            public List<object> Backdrops { get; set; }

            [JsonProperty("logos")]
            public List<object> Logos { get; set; }

            [JsonProperty("posters")]
            public List<Poster> Posters { get; set; }
        }

        public class Poster
        {
            [JsonProperty("tmdb_url")]
            public string TmdbUrl { get; set; }

            [JsonProperty("width")]
            public int? Width { get; set; }

            [JsonProperty("height")]
            public int? Height { get; set; }
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

        public class Video
        {
            [JsonProperty("tmdb_url")]
            public string TmdbUrl { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("source")]
            public string Source { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("size")]
            public int? Size { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("language")]
            public string Language { get; set; }
        }


    }
}
