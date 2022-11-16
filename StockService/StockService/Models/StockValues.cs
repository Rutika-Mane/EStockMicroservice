using System;

namespace StockService.Models
{
    public class StockValues
    {
        public string CompanyID { get; set; }
        public decimal StockPrice { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedTime { get; set; }
    }
}
