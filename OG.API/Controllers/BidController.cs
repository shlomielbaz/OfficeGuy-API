using Microsoft.AspNetCore.Mvc;
using OG.Domain.DTOs;
using OG.Domain.ViewModels;
using OG.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OG.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BidController : ControllerBase
    {
        private BidService service = new BidService();
        // GET: api/<BidController>
        [HttpGet]
        public Response<BidResponseDTO> GetAsync(BidRequestViewModel bid)
        {
            return this.service.getAll(bid);
        }
    }
}
