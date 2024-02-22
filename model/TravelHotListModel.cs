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
    /// 
    /// </summary>
    [SugarTable("travel_hotlist")]
    public class TravelHotListModel
    {
        [SugarColumn(IsPrimaryKey =true,IsIdentity =true)]
        public int idenid { get; set; }

        public long Hotlistid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long Locationid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string citycode { get; set; }

        public int Order_num { get; set; }

        public string imageurl { get; set; }


    }
}
