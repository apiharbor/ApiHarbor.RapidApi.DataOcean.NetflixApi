using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ApiHarbor.RapidApi.DataOcean.NetflixApi.Common;
using ApiHarbor.RapidApi.DataOcean.NetflixApi.Infrastructure;
using ApiHarbor.RapidApi.DataOcean.NetflixApi.Infrastructure.Implementations;
using ApiHarbor.RapidApi.DataOcean.NetflixApi.Requests;
using ApiHarbor.RapidApi.DataOcean.NetflixApi.Responses;

namespace ApiHarbor.RapidApi.DataOcean.NetflixApi
{
    public class NetflixApiClient
    {
        private readonly IWebClient _webClient;
        private readonly ILogger _logger;
        private readonly Dictionary<string, string> _headers;
        private const string RapidApiBaseUrl = "https://netflix99.p.rapidapi.com/v1";

        public NetflixApiClient(string rapidApiKey, IWebClient webClient, ILogger logger)
        {
            _webClient = webClient;
            _logger = logger;
            _headers = GetRapidApiHeaders(rapidApiKey);
        }

        public NetflixApiClient(string rapidApiKey, IWebClient webClient) : this(rapidApiKey, webClient, new DefaultLogger())
        {
        }

        public NetflixApiClient(string rapidApiKey) : this(rapidApiKey, new DefaultWebClient(), new DefaultLogger())
        {
        }

        private static Dictionary<string, string> GetRapidApiHeaders(string rapidApiKey)
        {
            return new Dictionary<string, string>()
            {
                { "X-RapidAPI-Key", rapidApiKey },
                { "X-RapidAPI-Host", "netflix99.p.rapidapi.com" }
            };
        }

        public async Task<SearchTitlesResponse.Root> SearchTitles(string query, Genre genre = Genre.All, Order order = Order.Trending,
            TitleType titleType = TitleType.All, Country country = Country.US, Language language = Language.en, int? releaseYearFrom = null,
            int? releaseYearTo = null, double? minRating = null, double? maxRating = null, string nextPageToken = null)
        {
            return await SearchTitles(new SearchTitlesRequest()
            {
                Country = country,
                Genre = genre,
                Language = language,
                MaxRating = maxRating,
                MinRating = minRating,
                NextPageToken = nextPageToken,
                Order = order,
                Query = query,
                ReleaseYearFrom = releaseYearFrom,
                ReleaseYearTo = releaseYearTo,
                TitleType = titleType
            });
        }

        public async Task<SearchTitlesResponse.Root> SearchTitles(SearchTitlesRequest request)
        {
            var url = $"{RapidApiBaseUrl}/search/titles?{request.ToQueryParams()}";
            return await SearchTitlesByUrl(url);
        }

        public async Task<SearchTitlesResponse.Root> SearchTitlesByUrl(string url)
        {
            try
            {
                var json = await _webClient.ReadAsStringAsync(url, _headers);
                return SearchTitlesResponse.Create(json);
            }
            catch (Exception ex)
            {
                _logger.Error(url, ex);
                throw;
            }
        }

        public async Task<TitleDetailsResponse.Root> TitleDetails(string id)
        {
            var url = $"{RapidApiBaseUrl}/title/details?id={id}";
            try
            {
                var json = await _webClient.ReadAsStringAsync(url, _headers);
                return TitleDetailsResponse.Create(json);
            }
            catch (Exception ex)
            {
                _logger.Error(url, ex);
                throw;
            }
        }

        public async Task<TitleMediaResponse.Root> TitleMedia(string id)
        {
            var url = $"{RapidApiBaseUrl}/title/media?id={id}";
            try
            {
                var json = await _webClient.ReadAsStringAsync(url, _headers);
                return TitleMediaResponse.Create(json);
            }
            catch (Exception ex)
            {
                _logger.Error(url, ex);
                throw;
            }
        }
        public async Task<TitleCreditsResponse.Root> TitleCredits(string id)
        {
            var url = $"{RapidApiBaseUrl}/title/credits?id={id}";
            try
            {
                var json = await _webClient.ReadAsStringAsync(url, _headers);
                return TitleCreditsResponse.Create(json);
            }
            catch (Exception ex)
            {
                _logger.Error(url, ex);
                throw;
            }
        }   
        
        public async Task<TitleSimilarResponse.Root> TitleSimilar(string id)
        {
            var url = $"{RapidApiBaseUrl}/title/similar?id={id}";
            try
            {
                var json = await _webClient.ReadAsStringAsync(url, _headers);
                return TitleSimilarResponse.Create(json);
            }
            catch (Exception ex)
            {
                _logger.Error(url, ex);
                throw;
            }
        } 
        
        public async Task<PersonDetailsResponse.Root> PersonDetails(string id)
        {
            var url = $"{RapidApiBaseUrl}/person/details?id={id}";
            try
            {
                var json = await _webClient.ReadAsStringAsync(url, _headers);
                return PersonDetailsResponse.Create(json);
            }
            catch (Exception ex)
            {
                _logger.Error(url, ex);
                throw;
            }
        }

        public async Task<TitleListsResponse.Root> TitleLists(Genre genre = Genre.All, Order order = Order.Trending,
            TitleType titleType = TitleType.All, Country country = Country.US, Language language = Language.en, int? releaseYearFrom = null,
            int? releaseYearTo = null, double? minRating = null, double? maxRating = null, string nextPageToken = null)
        {
            return await TitleLists(new TitlesListRequest()
            {
                Country = country,
                Genre = genre,
                Language = language,
                MaxRating = maxRating,
                MinRating = minRating,
                NextPageToken = nextPageToken,
                Order = order,
                ReleaseYearFrom = releaseYearFrom,
                ReleaseYearTo = releaseYearTo,
                TitleType = titleType
            });
        }

        public async Task<TitleListsResponse.Root> TitleLists(TitlesListRequest request)
        {
            var url = $"{RapidApiBaseUrl}/list/titles?{request.ToQueryParams()}";
            return await TitleListsByUrl(url);
        }

        public async Task<TitleListsResponse.Root> TitleListsByUrl(string url)
        {
            try
            {
                var json = await _webClient.ReadAsStringAsync(url, _headers);
                return TitleListsResponse.Create(json);
            }
            catch (Exception ex)
            {
                _logger.Error(url, ex);
                throw;
            }
        }
    }
}
