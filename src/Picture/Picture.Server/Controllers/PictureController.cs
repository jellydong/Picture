using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Picture.Shared;

namespace Picture.Server.Controllers
{

    /// <summary>
    /// 
    /// tags http://cdn.apc.360.cn/index.php?c=WallPaper&a=getAllCategoriesV2&from=360chrome
    /// new  http://wallpaper.apc.360.cn/index.php?c=WallPaper&a=getAppsByOrder&order=create_time&start=【0开始】&count=【加载数】&from=360chrome
    /// 专区  http://wallpaper.apc.360.cn/index.php?c=WallPaper&a=getAppsByCategory&cid=【分类ID】&start=【0开始】&count=【加载数】&from=360chrome
    /// Bing http://cn.bing.com/HPImageArchive.aspx?format=js&idx=【0开始】&n=【加载数】
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class PictureController : ControllerBase
    {

        private readonly ILogger<PictureController> _logger;

        public PictureController(ILogger<PictureController> logger)
        {
            _logger = logger;
        }
         
        [HttpGet("Get360New/{start}/{count}")]
        public async Task<Picture360<PictureItem360>> Get360New(int start, int count)
        {
            HttpClient httpClient = new HttpClient();

            var imgs = httpClient.GetFromJsonAsync<Picture360<PictureItem360>>(
                $"http://wallpaper.apc.360.cn/index.php?c=WallPaper&a=getAppsByOrder&order=create_time&start={start}&count={count}&from=360chrome");
            return await imgs;
        }

        [HttpGet("Get360Tags")]
        public async Task<Picture360<TagItem360>> Get360Tags()
        {
            HttpClient httpClient = new HttpClient();

            var tags = httpClient.GetFromJsonAsync<Picture360<TagItem360>>(
                $"http://wallpaper.apc.360.cn/index.php?c=WallPaper&a=getAllCategoriesV2&from=360chrome");
            return await tags;
        }
        [HttpGet("Get360PicsByTag/{cid}/{start}/{count}")]
        public async Task<Picture360<PictureItem360>> Get360PicsByTag(int cid, int start, int count)
        {
            HttpClient httpClient = new HttpClient();

            var imgs = httpClient.GetFromJsonAsync<Picture360<PictureItem360>>(
                $"http://wallpaper.apc.360.cn/index.php?c=WallPaper&a=getAppsByCategory&order=create_time&cid={cid}&start={start}&count={count}&from=360chrome");
            return await imgs;
        }
    }
}
