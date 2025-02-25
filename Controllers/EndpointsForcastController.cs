using Microsoft.AspNetCore.Mvc;

namespace KanbanAPI.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class EndpointsController : Controller
    {
        [HttpGet(Name = "GetEndpoints")]

        public string Get()
        {
            string endpoints = System.IO.File.ReadAllText("./endpoints.json");
            return endpoints;
        }
    }
}