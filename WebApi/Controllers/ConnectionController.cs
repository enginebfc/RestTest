using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConnectionController
    {
        public ConnectionController()
        {

        }

        [HttpGet]
        public HiModel GetHi(int id)
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
