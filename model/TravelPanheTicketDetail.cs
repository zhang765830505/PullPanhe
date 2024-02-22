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
    [SugarTable("travel_panhe_ticketdetail")]
    public class TravelPanheTicketDetail
    {
        [SugarColumn(IsPrimaryKey =true,IsIdentity =true)]
        public int idenid { get; set; }

        public long ProductId { get; set; }

        public string? ProductName { get; set; }

        public string? MarketPrice { get; set; }

        public string? SettlePrice { get; set; }

       
        public long ScenicId { get; set; }
    }
}
