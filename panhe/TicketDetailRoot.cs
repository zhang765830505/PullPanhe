using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qushuiying
{
    public class TicketDetailRoot
    {
        public TicketDetailData Data { get; set; }
        public bool Success { get; set; }
        public string Msg { get; set; }
    }

    public class TicketDetailData
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal MarketPrice { get; set; }
        public decimal SettlePrice { get; set; }
        public string DrawTicketAddress { get; set; }
        public int AdvanceDay { get; set; }
        public string AdvanceTime { get; set; }
        public string BookNotice { get; set; }
        public string RefundChangeRule { get; set; }
        public string CostDescription { get; set; }
        public string UseDescription { get; set; }
        public string OtherDescription { get; set; }
        public int MinBuyCount { get; set; }
        public int MaxBuyCount { get; set; }
        public int ContactInfoType { get; set; }
        public int TouristInfoType { get; set; }
        public List<int> SupportCardTypes { get; set; }
        public List<PriceCalendar> PriceCalendar { get; set; }

        public int UnitQuantity { get; set; }

    }

    public class PriceCalendar
    {
        public decimal SettlePrice { get; set; }
        public DateTime Date { get; set; }
    }
}
