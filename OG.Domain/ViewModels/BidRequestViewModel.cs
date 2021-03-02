namespace OG.Domain.ViewModels
{
    public class BidRequestViewModel
    {
        public string CustomerName { get; set; }
        public long CompanyID { get; set; }
        public decimal UnitPrice { get; set; }
        public string ItemName { get; set; }
        public string APIKey { get; set; }
    }
}