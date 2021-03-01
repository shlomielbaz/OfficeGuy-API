using OG.Domain.enums;

namespace OG.Domain.entities
{
    public class DocumentItemDetails
    {
        public long? ID { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public CurrencyType Currency { get; set; }
        public double? Cost { get; set; }
        public string ExternalIdentifier { get; set; }
        public string SKU { get; set; }
        public SearchModeType SearchMode { get; set; }
        public string Properties { get; set; }
    }
}
