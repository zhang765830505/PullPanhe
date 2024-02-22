using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qushuiying
{
    /// <summary>
    /// 景区表
    /// </summary>
    [SugarTable("travel_scenic_spots")]
    public class TravelScenicSpotsModel
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int idenid { get; set; }

        public long spotsid { get; set; }

        /// <summary>
        /// 通用表id
        /// </summary>

        public long location_id { get; set; }

        /// <summary>
        /// 开放时间
        /// </summary>
        public string opening_hours { get; set; }

        /// <summary>
        /// 建议游玩时间
        /// </summary>
        public string suggest_time { get; set; }

        /// <summary>
        /// 最佳时间
        /// </summary>
        public string optimum_time { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string phone_number { get; set; }

        /// <summary>
        /// 官方网站
        /// </summary>
        public string website { get; set; }

        /// <summary>
        /// 0:未审，1：已审，2驳回，3：拒绝， 4：禁用
        /// </summary>
        public int status { get; set; }

        /// <summary>
        /// 是否签署协议 0否，1是
        /// </summary>
        public int agreement_signed { get; set; }

        /// <summary>
        /// 保证金金额
        /// </summary>
        public decimal deposit_amount { get; set; }

        /// <summary>
        /// 是否缴纳保证金 0否 1是
        /// </summary>
        public int deposit_paid { get; set; }

        /// <summary>
        /// 营业执照文件路径
        /// </summary>
        public string business_license { get; set; }

        /// <summary>
        /// 旅游经营许可证文件路径
        /// </summary>
        public string tourism_license { get; set; }

        /// <summary>
        /// 消防安全许可证文件路径
        /// </summary>
        public string fire_safety_license { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime create_time { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime update_time { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        public long stores_id { get; set; }
    }
}
