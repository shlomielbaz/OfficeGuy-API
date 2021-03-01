namespace OG.Domain.entities
{
    public class Customer
    {
        public long? ID { get; set; }
        public bool? NoVAT { get; set; }
        public string Folder { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string CompanyNumber { get; set; }
        public string ExternalIdentifier { get; set; }
        public enums.SearchModeType SearchMode { get; set; }
    }
}
