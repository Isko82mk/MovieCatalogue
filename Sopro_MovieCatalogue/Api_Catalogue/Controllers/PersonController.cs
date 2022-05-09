using Microsoft.AspNetCore.Mvc;
using Model;
using Model.PersonDTO;
using Services.Interfaces;
using System.Collections.Generic;

namespace Api_Catalogue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }


        [HttpGet("getall")]
        public ActionResult<IEnumerable<GetPersonDTO>> GetAll()
        {
            return Ok(_personService.GetAll());
        }

        [HttpGet("getbyid")]
        public ActionResult<GetPersonDTO> GetById(int id)
        {
            return _personService.GetById(id);
        }

        [HttpPost("add")]
        public ActionResult<Person> Add([FromBody] AddPersonDto newPerson)
        {
            return _personService.Add(newPerson);

        }

        [HttpPut("update")]
        public ActionResult<Person> Update(UpdatePersonDto person)
        {
            return _personService.Update(person);
        }

        [HttpDelete("delete")]
        public ActionResult<bool> Delete(int id) => _personService.Delete(id);



    }
}
