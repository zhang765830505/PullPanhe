
using SqlSugar;

namespace qushuiying
{
    /// <summary>
    /// 填表
    /// </summary>
    [SugarTable("scinsert")]
    public class Scinsert
    {
        /// <summary>
        /// Inid 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int? Inid { get; set; }

        /// <summary>
        /// 景区名称 
        /// </summary>
        public string Scname { get; set; }

        /// <summary>
        /// 主图 
        /// </summary>
        public string Scmainurl { get; set; }

        /// <summary>
        /// 地址 
        /// </summary>
        public string Scaddress { get; set; }

        /// <summary>
        /// 坐标 
        /// </summary>
        public string Zuobiao { get; set; }

        /// <summary>
        /// 建议游玩时间 
        /// </summary>
        public string Scplaytime { get; set; }

        /// <summary>
        /// 游玩最佳时间 
        /// </summary>
        public string Scplaygoodtime { get; set; }

        /// <summary>
        /// 开放时间 
        /// </summary>
        public string Scopentime { get; set; }

        /// <summary>
        /// 景区介绍 
        /// </summary>
        public string Scremark { get; set; }

        /// <summary>
        /// 轮播图
        /// </summary>

        public string sccarouselurl { get; set; }

        /// <summary>
        /// 省 
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 更新时间 
        /// </summary>
        public DateTime? UpdateTime { get; set; }

    }
}