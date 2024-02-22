using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qushuiying.model
{
    [SugarTable("data_city")]
    public class data_city
    {
        public int CityId { get; set; }

        public string CityCode { get; set; }

        public string CityName { get; set; }

        public string ProvinceCode { get; set; }
    }
}
