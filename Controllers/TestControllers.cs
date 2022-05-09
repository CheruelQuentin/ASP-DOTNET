﻿using Microsoft.AspNetCore.Mvc;
using APIrestFull.Models;
namespace APIrestFull.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestControllers : Controller
    {
        private readonly DatabaseContext Context;

        public TestControllers(DatabaseContext context)
        {
            Context = context;
        }
        [HttpGet(Name = "/getId")]
        public List<int> getId()
        {
            return Context.getId();
        }
    }
}
