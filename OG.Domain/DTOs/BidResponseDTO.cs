using OG.Domain.Types;

namespace OG.Domain.DTOs
{
    public class BidResponseDTO: IResponse
    {
        public long DocumentID { get; set; }
        public long DocumentNumber { get; set; }
        public long CustomerID { get; set; }
        public string DocumentDownloadURL { get; set; }
    }
}