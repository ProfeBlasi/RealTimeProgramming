using Microsoft.AspNetCore.Mvc;

namespace Benchmark.Controllers
{
    [ApiController]
    [Route("/")]
    public class BenchmarkController : ControllerBase
    {
        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            return "Este es nunestro Benchmark para programcion en tiempo real segundo cuatrimestre 2022, Alumnos: Djirikian Damian y Blasi Ezequiel";
        }
    }
}