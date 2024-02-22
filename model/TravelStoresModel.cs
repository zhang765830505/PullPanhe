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
    /// 店铺表
    /// </summary>
    [SugarTable("travel_stores")]
    public class TravelStoresModel
    {
        [SugarColumn(IsPrimaryKey =true,IsIdentity =true)]
        public int idenid { get; set; }

        public long Storesid { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        public string Stores_name { get; set; }

        /// <summary>
        /// 店铺描述
        /// </summary>
        public string Stores_description { get; set; }

        /// <summary>
        /// 店铺类型，如：酒店，景区，导游，app自己
        /// </summary>
        public int Stores_type { get; set; }
    }
}
