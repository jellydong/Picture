using System.Collections.Generic;

namespace Picture.Shared
{
    /// <summary>
    /// 360图片返回类
    /// </summary>
    public class Picture360<T>
    {

        /// <summary>
        /// 
        /// </summary>
        public string errno { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string errmsg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string consume { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string total { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<T> data { get; set; }
    }

    public class PictureItem360
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string class_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string resolution { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url_mobile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url_thumb { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url_mid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string download_times { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string imgcut { get; set; }
        /// <summary>
        ///  
        /// </summary>
        public string tag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string create_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string update_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ad_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ad_img { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ad_pos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ad_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ext_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ext_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string utag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tempdata { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> rdata { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string img_1600_900 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string img_1440_900 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string img_1366_768 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string img_1280_800 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string img_1280_1024 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string img_1024_768 { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class TagItem360
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string order_num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string create_time { get; set; }
    }
}