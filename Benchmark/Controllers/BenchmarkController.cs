using Microsoft.AspNetCore.Mvc;

namespace Benchmark.Controllers
{
    [ApiController]
    [Route("/")]
    public class BenchmarkController : ControllerBase
    {
        [HttpGet("/")]
        public string Get()
        {
            return "Este es nuestro Benchmark para programacion en tiempo real segundo cuatrimestre 2022, Alumnos: Djirikian Damian y Blasi Ezequiel"
                + " \n la presentacion se va a realizar el dia " + DateTime.Now.ToString();
        }
    }
}