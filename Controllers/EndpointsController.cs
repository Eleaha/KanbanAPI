using Microsoft.AspNetCore.Mvc;

namespace KanbanAPI.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class EndpointsController : ControllerBase
    {
        [HttpGet(Name = "GetEndpoints")]

        public string Get()
        {
            string endpointsFilePath = "./endpoints.json";
            string endpoints = System.IO.File.ReadAllText(endpointsFilePath);
            return endpoints;
        }
    }
}