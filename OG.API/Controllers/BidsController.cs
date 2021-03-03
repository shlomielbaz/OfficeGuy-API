using Microsoft.AspNetCore.Mvc;
using OG.Domain.DTOs;
using OG.Domain.Types;
using OG.Domain.ViewModels;
using OG.Services;

namespace OG.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BidsController : ControllerBase
    {
        private readonly IBidService service;
        public BidsController(IBidService service)
        {
            this.service = service;
        }

        // POST: api/<BidController>
        [HttpGet]
        public string GetAsync()
        {
            return "Welcome to bid's system";
        }

        // POST: api/<BidController>
        [HttpPost]
        public Response<BidResponseDTO> GetAsync(BidRequestViewModel bid)
        {
            return this.service.Get(bid);
        }
    }
}
