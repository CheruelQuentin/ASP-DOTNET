using Microsoft.AspNetCore.Mvc;
using APIrestFull.Models;
namespace APIrestFull.Controllers
{
    public class TestControllers : Controller
    {
        private readonly DatabaseContext Context;

        public TestControllers(DatabaseContext context)
        {
            Context = context;
        }
        [Route("/getConso")]
        [HttpGet]
        public List<Conso> getConso()
        {
            return Context.getConso();
        }
        [Route("/getCommande")]
        [HttpGet]
        public List<Commande> getCommande()
        {
            return Context.getCommande();
        }

        
        [Route("/getContenir")]
        [HttpGet]
        public List<Contenir> getContenir()
        {
            return Context.getContenir();
        }
        
        [Route("/insertConso")]
        [HttpPost]
        public int insertConso(string nom)
        {
            return Context.insertConso(nom);
        }
    }
}
