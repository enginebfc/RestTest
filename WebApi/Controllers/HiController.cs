using Microsoft.AspNetCore.Mvc;
using RestTest.Interfaces;
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
        public HiModel Get(int id)
        {
            return hiRepository.Get(id);
        }

        [HttpPost]
        public int Create(HiModel request)
        {
            return hiRepository.Add(request);
        }
    }
}
