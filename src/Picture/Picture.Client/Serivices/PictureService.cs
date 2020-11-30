using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Picture.Shared;

namespace Picture.Client.Serivices
{
    public class PictureService : IPictureService
    {
        private readonly HttpClient _httpClient;

        public PictureService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Picture360<PictureItem360>> Get360PicNews(int start, int count)
        {
            return await _httpClient.GetFromJsonAsync<Picture360<PictureItem360>>(
                $"Picture/Get360New/{start}/{count}");

        }

        public async Task<Picture360<TagItem360>> Get360Tags()
        { 
            return await _httpClient.GetFromJsonAsync<Picture360<TagItem360>>(
                $"Picture/Get360Tags");
        } 
        public async Task<Picture360<PictureItem360>> Get360PicsByTag(string cid, int start, int count)
        {
            return await _httpClient.GetFromJsonAsync<Picture360<PictureItem360>>(
               $"Picture/Get360PicsByTag/{cid}/{start}/{count}");
        }

        public Task<PictureBing> GetBingPic(string cid, int start, int count)
        {
            throw new System.NotImplementedException();
        }
    }
}