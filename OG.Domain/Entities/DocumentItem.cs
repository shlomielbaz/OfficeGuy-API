namespace OG.Domain.entities
{
    public class DocumentItem
    {
        public double? Quantity { get; set; }
        public double? UnitPrice { get; set; }
        public double? TotalPrice { get; set; }
        public double? DocumentCurrency_UnitPrice { get; set; }
        public double? DocumentCurrency_TotalPrice { get; set; }
        public string Description { get; set; }
        public DocumentItemDetails? Item { get; set; }
    }
}
