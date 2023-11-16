using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiHarbor.RapidApi.DataOcean.NetflixApi.Responses
{
    public class TitleCreditsResponse
    {
        public static Root Create(string json)
        {
            Root root = JsonConvert.DeserializeObject<Root>(json);
            return root;
        }
        
        public class Cast
        {
            [JsonProperty("id")]
            public int? Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("original_name")]
            public string OriginalName { get; set; }

            [JsonProperty("character")]
            public string Character { get; set; }

            [JsonProperty("gender")]
            public string Gender { get; set; }

            [JsonProperty("popularity")]
            public double? Popularity { get; set; }

            [JsonProperty("is_adult")]
            public bool? IsAdult { get; set; }

            [JsonProperty("_links")]
            public Links Links { get; set; }
        }

        public class Crew
        {
            [JsonProperty("id")]
            public int? Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("original_name")]
            public string OriginalName { get; set; }

            [JsonProperty("job")]
            public string Job { get; set; }

            [JsonProperty("department")]
            public string Department { get; set; }

            [JsonProperty("known_for_department")]
            public string KnownForDepartment { get; set; }

            [JsonProperty("gender")]
            public string Gender { get; set; }

            [JsonProperty("popularity")]
            public double? Popularity { get; set; }

            [JsonProperty("is_adult")]
            public bool? IsAdult { get; set; }

            [JsonProperty("_links")]
            public Links Links { get; set; }
        }

        public class Data
        {
            [JsonProperty("cast")]
            public List<Cast> Cast { get; set; }

            [JsonProperty("crew")]
            public List<Crew> Crew { get; set; }
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


    }
}
