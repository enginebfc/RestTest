using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestTest.Interfaces;
using System.Threading.Tasks;
using WebApi.Models;

namespace RestTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HiController
    {
        private readonly IHiRepository hiRepository;

        public HiController(IHiRepository hiRepository)
        {
            this.hiRepository = hiRepository;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<HiModel> Get(int id)
        {
            return hiRepository.Get(id);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<int> Create(HiModel request)
        {
            if(request.Id > 20)
                return new BadRequestResult();

            return hiRepository.Add(request);
        }
    }
}
