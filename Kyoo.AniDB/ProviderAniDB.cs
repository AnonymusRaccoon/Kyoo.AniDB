using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using Kyoo.Controllers;
using Kyoo.Models;

namespace Kyoo.AniDB
{
    public class ProviderAniDB : IPlugin, IMetadataProvider
    {
        string IMetadataProvider.Name => "AniDB";
        string IPlugin.Name => "AniDB Provider";

        private readonly IHttpClientFactory _clientFactory;

        public ProviderAniDB(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public Task<Collection> GetCollectionFromName(string name)
        {
            return Task.FromResult<Collection>(null);
        }

        public async Task<Show> GetShowByID(string id)
        {
            // HttpClient client = _clientFactory.CreateClient();
            // client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",await GetToken());
            // HttpResponseMessage response = await client.GetAsync("https://api.thetvdb.com/search/series?name=" + HttpUtility.UrlEncode(showName));
            //
            // response.EnsureSuccessStatusCode();
            // dynamic data = await response.Content.ReadAsAsync<ExpandoObject>();
            // data = data.data[0];
            //
            // Show show = new Show(-1,
            //     Utility.ToSlug(showName),
            //     data.seriesName,
            //     ((List<object>)data.aliases).OfType<string>(),
            //     null,
            //     data.overview,
            //     null,
            //     null,
            //     GetStatus(data.status),
            //     GetYear(data.firstAired),
            //     null,
            //     $"{((IMetadataProvider)this).Name}={data.id}");
            // await GetImages(show);
            // return show;
        }

        public async Task<Show> GetShowFromName(string showName)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<People>> GetPeople(Show show)
        {
            throw new NotImplementedException();
        }

        public Task<Season> GetSeason(Show show, long seasonNumber)
        {
            return Task.FromResult<Season>(null);
        }

        public async Task<Episode> GetEpisode(Show show, long seasonNumber, long episodeNumber, long absoluteNumber)
        {
            throw new NotImplementedException();
        }
    }
}