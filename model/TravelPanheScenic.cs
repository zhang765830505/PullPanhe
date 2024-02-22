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
    [SugarTable("travel_panhe_scenic")]
    public class TravelPanheScenic
    {
        [SugarColumn(IsPrimaryKey =true,IsIdentity =true)]
        public int idenid { get; set; }

        public long Scenicid { get; set; }

        public string? ScenicName { get; set; }

        public string? MainImage { get; set; }

        public string? CityCode { get; set; }

        public string? ProvinceCode { get; set; }

        public string? Address { get; set; }

        public decimal Longitude { get; set; }

        public decimal Latitude { get; set; }

        public int Star { get; set; }

        public decimal CommentScore { get; set; }

        public string? OpenTime { get; set; }

        public string? ThemeGroups { get; set; }

        public string? Images { get; set;}

        public string? ScenicDescription { get; set;}

        public string? Recommend { get; set; }

        public string? BookNotice { get; set; }

        public string? MinPrice { get; set;}
    }
}
