using Microsoft.AspNetCore.Mvc;
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
        [HttpGet(Name = "/getConso")]
        public List<Conso> getConso()
        {
            return Context.getConso();
        }
        [HttpGet(Name = "/getCommande")]
        public List<Commande> getCommande()
        {
            return Context.getCommande();
        }
        [HttpGet(Name = "/getContenir")]
        public List<Contenir> getContenir()
        {
            return Context.getContenir();
        }
    }
}
