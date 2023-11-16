using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiHarbor.RapidApi.DataOcean.NetflixApi.Responses
{
    public class TitleDetailsResponse
    {
        public static Root Create(string json)
        {
            Root root = JsonConvert.DeserializeObject<Root>(json);
            return root;
        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class AgeRating
        {
            [JsonProperty("country_code")]
            public string CountryCode { get; set; }

            [JsonProperty("rating")]
            public string Rating { get; set; }
        }

        public class Creator
        {
            [JsonProperty("full_name")]
            public string FullName { get; set; }

            [JsonProperty("gender")]
            public string Gender { get; set; }
        }

        public class Credits
        {
            [JsonProperty("href")]
            public string Href { get; set; }
        }

        public class Data
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("original_title")]
            public string OriginalTitle { get; set; }

            [JsonProperty("original_language")]
            public string OriginalLanguage { get; set; }

            [JsonProperty("release_date")]
            public DateTime? ReleaseDate { get; set; }

            [JsonProperty("duration_in_mins")]
            public int? DurationInMins { get; set; }

            [JsonProperty("duration_time")]
            public string DurationTime { get; set; }

            [JsonProperty("release_year")]
            public int? ReleaseYear { get; set; }

            [JsonProperty("overview")]
            public string Overview { get; set; }

            [JsonProperty("vote_average")]
            public double? VoteAverage { get; set; }

            [JsonProperty("vote_count")]
            public int? VoteCount { get; set; }

            [JsonProperty("genres")]
            public List<string> Genres { get; set; }

            [JsonProperty("origin_country")]
            public OriginCountry OriginCountry { get; set; }

            [JsonProperty("age_ratings")]
            public List<AgeRating> AgeRatings { get; set; }

            [JsonProperty("external_ids")]
            public ExternalIds ExternalIds { get; set; }

            [JsonProperty("main_url")]
            public string MainUrl { get; set; }

            [JsonProperty("keywords")]
            public List<string> Keywords { get; set; }

            [JsonProperty("tmdb_poster_url")]
            public string TmdbPosterUrl { get; set; }

            [JsonProperty("tv_show_details")]
            public TvShowDetails TvShowDetails { get; set; }

            [JsonProperty("_links")]
            public Links Links { get; set; }
        }

        public class ExternalIds
        {
            [JsonProperty("imdb_id")]
            public string ImdbId { get; set; }

            [JsonProperty("tvdb_id")]
            public string TvdbId { get; set; }

            [JsonProperty("facebook_id")]
            public object FacebookId { get; set; }

            [JsonProperty("twitter_id")]
            public object TwitterId { get; set; }

            [JsonProperty("instagram_id")]
            public object InstagramId { get; set; }
        }

        public class Links
        {
            [JsonProperty("credits")]
            public Credits Credits { get; set; }

            [JsonProperty("similar")]
            public Similar Similar { get; set; }

            [JsonProperty("media")]
            public Media Media { get; set; }
        }

        public class Media
        {
            [JsonProperty("href")]
            public string Href { get; set; }
        }

        public class OriginCountry
        {
            [JsonProperty("country_name")]
            public string CountryName { get; set; }

            [JsonProperty("country_code")]
            public string CountryCode { get; set; }
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

        public class TvShowDetails
        {
            [JsonProperty("languages")]
            public List<string> Languages { get; set; }

            [JsonProperty("seasons_num")]
            public int? SeasonsNum { get; set; }

            [JsonProperty("episodes_num")]
            public int? EpisodesNum { get; set; }

            [JsonProperty("last_episode_date")]
            public DateTime? LastEpisodeDate { get; set; }

            [JsonProperty("creators")]
            public List<Creator> Creators { get; set; }
        }


    }
}
