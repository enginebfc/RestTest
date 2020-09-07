using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HiController
    {
        public HiController()
        {

        }

        [HttpGet]
        public HiModel Get(int id)
        {
            return new HiModel { Id = id, Name = "Some name" };
        }

        [HttpPost]
        public int Create(HiModel request)
        {
            return 1;
        }
    }
}
