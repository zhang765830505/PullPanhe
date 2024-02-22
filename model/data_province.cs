using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qushuiying.model
{
    [SugarTable("data_province")]
    public class data_province
    {
        public int ProvinceId { get; set; }

        public string ProvinceCode { get; set; }

        public string ProvinceName { get; set; }
    }
}
