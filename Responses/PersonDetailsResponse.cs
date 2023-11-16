using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiHarbor.RapidApi.DataOcean.NetflixApi.Responses
{
    public class PersonDetailsResponse
    {
        public static Root Create(string json)
        {
            Root root = JsonConvert.DeserializeObject<Root>(json);
            return root;
        }

        public class Cast
        {
            [JsonProperty("character")]
            public string Character { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("original_title")]
            public string OriginalTitle { get; set; }

            [JsonProperty("release_date")]
            public DateTime? ReleaseDate { get; set; }

            [JsonProperty("is_adult")]
            public bool? IsAdult { get; set; }

            [JsonProperty("tmdb_poster_url")]
            public string TmdbPosterUrl { get; set; }
        }

        public class Crew
        {
            [JsonProperty("department")]
            public string Department { get; set; }

            [JsonProperty("job")]
            public string Job { get; set; }

            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("original_title")]
            public string OriginalTitle { get; set; }

            [JsonProperty("release_date")]
            public DateTime? ReleaseDate { get; set; }

            [JsonProperty("is_adult")]
            public bool? IsAdult { get; set; }

            [JsonProperty("tmdb_poster_url")]
            public string TmdbPosterUrl { get; set; }
        }

        public class Data
        {
            [JsonProperty("is_adult")]
            public bool? IsAdult { get; set; }

            [JsonProperty("know_for_other_roles")]
            public List<string> KnowForOtherRoles { get; set; }

            [JsonProperty("biography")]
            public string Biography { get; set; }

            [JsonProperty("gender")]
            public string Gender { get; set; }

            [JsonProperty("external_ids")]
            public ExternalIds ExternalIds { get; set; }

            [JsonProperty("url")]
            public object Url { get; set; }

            [JsonProperty("images")]
            public List<Image> Images { get; set; }

            [JsonProperty("movie_credits")]
            public MovieCredits MovieCredits { get; set; }

            [JsonProperty("tv_show_credits")]
            public TvShowCredits TvShowCredits { get; set; }

            [JsonProperty("popularity")]
            public double? Popularity { get; set; }
        }

        public class ExternalIds
        {
            [JsonProperty("facebook_id")]
            public object FacebookId { get; set; }

            [JsonProperty("imdb_id")]
            public string ImdbId { get; set; }

            [JsonProperty("twitter_id")]
            public object TwitterId { get; set; }

            [JsonProperty("instagram_id")]
            public object InstagramId { get; set; }

            [JsonProperty("freebase_id")]
            public string FreebaseId { get; set; }

            [JsonProperty("freebase_mid")]
            public string FreebaseMid { get; set; }

            [JsonProperty("id")]
            public int? Id { get; set; }

            [JsonProperty("tvrage_id")]
            public string TvrageId { get; set; }
        }

        public class Image
        {
            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("width")]
            public int? Width { get; set; }

            [JsonProperty("height")]
            public int? Height { get; set; }

            [JsonProperty("language")]
            public object Language { get; set; }
        }

        public class MovieCredits
        {
            [JsonProperty("cast")]
            public List<Cast> Cast { get; set; }

            [JsonProperty("crew")]
            public List<Crew> Crew { get; set; }
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

        public class TvShowCredits
        {
            [JsonProperty("cast")]
            public List<object> Cast { get; set; }

            [JsonProperty("crew")]
            public List<object> Crew { get; set; }
        }


    }
}
