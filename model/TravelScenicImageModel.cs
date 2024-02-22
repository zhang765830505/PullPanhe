using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qushuiying
{
    [SugarTable("travel_scenic_image")]
    public class TravelScenicImageModel
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int idenid { get; set; }
        public long travel_scenic_imageid { get; set; }

        public string imageurl { get; set; }

        public long travel_scenicid { get; set; }
    }
}
