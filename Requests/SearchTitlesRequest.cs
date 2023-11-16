using ApiHarbor.RapidApi.DataOcean.NetflixApi.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiHarbor.RapidApi.DataOcean.NetflixApi.Requests
{
    public class SearchTitlesRequest
    {
        public string Query { get; set; }
        public Genre Genre { get; set; } = Genre.All;
        public Order Order { get; set; } = Order.Trending;
        public TitleType TitleType { get; set; } = TitleType.All;
        public Country Country { get; set; } = Country.US;
        public Language Language { get; set; } = Language.en;
        public int? ReleaseYearFrom { get; set; } = null;
        public int? ReleaseYearTo { get; set; } = null;
        public double? MinRating { get; set; } = null;
        public double? MaxRating { get; set; } = null;
        public string NextPageToken { get; set; } = null;

        public string ToQueryParams()
        {
            return string.Join("&", new[]
             {
                $"query={Uri.EscapeDataString(Query)}",
                $"genre={Genre}",
                $"order={Order}",
                $"title_type={TitleType}",
                $"country={Country}",
                $"language={Language}",
                $"release_year_from={ReleaseYearFrom}",
                $"release_year_to={ReleaseYearTo}",
                $"min_rating={MinRating}",
                $"max_rating={MaxRating}",
                $"next_page_token={NextPageToken}",
            });
        }
    }
}
