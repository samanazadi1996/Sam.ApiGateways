using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Person2.Models;
using System.Collections.Generic;
using System.Linq;

namespace Services.Person2.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class PersonController : ControllerBase
    {
        private static readonly List<Person> people = new List<Person>
        {
            new Person(1,"Saman 2","Azadi"),
            new Person(2,"Ali 2","Karimi")
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
