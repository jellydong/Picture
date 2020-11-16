using System.Collections.Generic;

namespace Picture.Shared
{
    public class PictureBing
    {
        /// <summary>
        /// 
        /// </summary>
        public List<PictureItemBing> images { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public BingTooltips tooltips { get; set; }
    }
    public class PictureItemBing
    {
        /// <summary>
        /// 
        /// </summary>
        public string startdate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fullstartdate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string enddate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string urlbase { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string copyright { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string copyrightlink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string quiz { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string wp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string hsh { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int drk { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int top { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int bot { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> hs { get; set; }
    }

    public class BingTooltips
    {
        /// <summary>
        ///
        /// </summary>
        public string loading { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string previous { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string next { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string walle { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string walls { get; set; }
    }
}