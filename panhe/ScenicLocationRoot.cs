using System;
using System.Collections.Generic;


namespace qushuiying
{

    public class ScenicLocationRoot
    {
        public Data Data { get; set; }
        public bool Success { get; set; }
        public string Msg { get; set; }
    }

    public class Data
    {
        public int Count { get; set; }
        public List<ScenicLocation> ScenicList { get; set; }
    }

    public class ScenicLocationDetile
    {
        public ScenicLocation Data { get; set; }
        public bool Success { get; set; }
        public string Msg { get; set; }
    }

    public class ScenicLocation
    {
        public string ScenicId { get; set; }
        public string ScenicName { get; set; }
        public string MainImage { get; set; }
        public string CityName { get; set; }
        public string ProvinceName { get; set; }
        public string Address { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public int Star { get; set; }
        public decimal CommentScore { get; set; }
        public string OpenTime { get; set; }
        public string ThemeGroups { get; set; }
        public string Recommand { get; set; }

        public string BookNotice { get; set; }
        public decimal? StartPrice { get; set; }

        public string? ScenicDescription { get; set; }
        public string[]? Images { get; set; }


        public List<TicketProduct> TicketProducts { get; set; }
    }

    public class TicketProduct
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string MarketPrice { get; set; }
        public string SettlePrice { get; set; }
        public string RefundType { get; set; }
        public string RefundTypeShowText { get; set; }
        public int? AdvanceBookingDays { get; set; }
        public bool IsNeedGetTicket { get; set; }
        public string AdvanceBookingDaysShowText { get; set; }
    }

}
