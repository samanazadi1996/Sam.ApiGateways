using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Person1.Models;
using System.Collections.Generic;
using System.Linq;

namespace Services.Person1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class PersonController : ControllerBase
    {
        private static readonly List<Person> people = new List<Person>
        {
            new Person(1,"Saman 1","Azadi"),
            new Person(2,"Ali 1","Karimi")
        };

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Get/{id}")]
        public Person Get(int id)
        {
            return people.FirstOrDefault(c => c.Id == id);
        }
    }
}
