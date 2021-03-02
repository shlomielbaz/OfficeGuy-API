using OG.Domain.DTOs;
using OG.Domain.ViewModels;

namespace OG.Domain.Types
{
    public interface IBidService
    {
        Response<BidResponseDTO> Get(BidRequestViewModel bid);
    }
}
