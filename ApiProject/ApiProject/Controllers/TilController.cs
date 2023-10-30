using ApiProject.model;
using ApiProject.Service;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;

namespace ApiProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TilController
    {
        public TilController()
        {

        }

        TilService service = new TilService();
        [HttpGet]
        public IEnumerable <Til> Get()
        {
            return service.GetData();
        }
        [HttpGet]
        [Route("GetByCity")]
        public IEnumerable<Til>GetById(string city)
        {
            return service.GetData(city);
        }
        [HttpGet]
        [Route("GetLocations")]
        public IEnumerable<string> GetLocations()
        {
            return service.GetLocations();
        }
        [HttpPost]
        public bool Post(Til til)
        {
            return service.Add(til);
        }
    }
}
