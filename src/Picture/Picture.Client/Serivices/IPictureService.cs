using Picture.Shared;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace Picture.Client.Serivices
{
    public interface IPictureService
    {
        /// <summary>
        /// 获取360最新图片
        /// </summary>
        /// <param name="start">开始数</param>
        /// <param name="count">获取记录数</param>
        /// <returns></returns>
        Task<Picture360<PictureItem360>> Get360PicNews(int start, int count);
        /// <summary>
        /// 获取360标签分类
        /// </summary> 
        /// <param name="start"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        Task<Picture360<TagItem360>> Get360Tags();
        /// <summary>
        /// 通过标签分类获取图片
        /// </summary>
        /// <param name="cid"></param>
        /// <param name="start"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        Task<Picture360<PictureItem360>> Get360PicsByTag(string cid, int start, int count);
        /// <summary>
        /// 获取bing图片
        /// </summary>
        /// <param name="cid"></param>
        /// <param name="start"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        Task<PictureBing> GetBingPic(string cid, int start, int count);
    }
}