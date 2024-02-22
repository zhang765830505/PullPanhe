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
    /// 通用地点表
    /// </summary>
    [SugarTable("travel_common_locations")]
    public class TravelCommonLocationsModel
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int idenid { get; set; }
        public long Commonid { get; set; }

        /// <summary>
        /// 地点名称
        /// </summary>
        public string? Common_name { get; set; }

        /// <summary>
        /// 地点描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 地点地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 0未审，1审核中，2失败，3成功，4下架
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 0:景区,1:酒店,2:美食
        /// </summary>
        public int Location_type { get; set; }

        /// <summary>
        /// 经维度
        /// </summary>
        public string LongiLatitude { get; set; }

        /// <summary>
        /// 封面地址
        /// </summary>
        public string Image_url { get; set; }

        /// <summary>
        /// 是否付费推广
        /// </summary>
        public string Is_paid_promotion { get; set; }

        /// <summary>
        /// 点赞数量
        /// </summary>
        public int Likes { get; set; }

        /// <summary>
        /// 所在市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Create_time { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime Update_time { get; set; }

        /// <summary>
        /// 所属用户
        /// </summary>
        public long Userid { get; set; }

        /// <summary>
        /// 注册地
        /// </summary>
        public int? Domicile { get; set; }

        /// <summary>
        /// 营业执照编号
        /// </summary>
        public string CompanyCardNo { get; set; }


        /// <summary>
        /// 营业执照照片
        /// </summary>
        public string LicenseImageUrl { get; set; }

        /// <summary>
        /// 营业执照开始时间
        /// </summary>
        public DateTime? LicenseStart { get; set; }

        /// <summary>
        /// 营业执照结束时间
        /// </summary>
        public DateTime? LicenseEnd { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// 注册资金
        /// </summary>
        public decimal RegisteredCapital { get; set; }

        /// <summary>
        /// 经营范围
        /// </summary>
        public string BusinessScope { get; set; }

        /// <summary>
        /// 最低金额
        /// </summary>
        public decimal MinPrice { get; set; }
    }

}
