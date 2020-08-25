using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeopleDatabase.WebAPI.Data;
using PeopleDatabase.WebAPI.Dtos;
using PeopleDatabase.WebAPI.Models;

namespace Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class PeopleController : ControllerBase
  {
    private readonly IPeopleRepository _peopleRepository;
    private readonly IMapper _mapper;

    public PeopleController(IPeopleRepository repository, IMapper mapper)
    {
      _mapper = mapper;
      _peopleRepository = repository;
    }

    [HttpGet]
    public IActionResult Get()
    {
      var people = _peopleRepository.GetAll();

      var peopleToReturn = _mapper.Map<IEnumerable<PersonDto>>(people);

      return Ok(peopleToReturn);
    }

    [HttpGet("{personId}")]
    public IActionResult GetById(int personId)
    {
      var person = _peopleRepository.GetById(personId);

      if (person == null) return NotFound("Person not found");

      var personToReturn = _mapper.Map<PersonDto>(person);

      return Ok(personToReturn);
    }

    [HttpPost()]
    public IActionResult Post(PersonRegisterDto receivedPerson)
    {
      var person = _mapper.Map<Person>(receivedPerson);
      
      if (_peopleRepository.Create(person))
      {
        var personToReturn = _mapper.Map<PersonDto>(person);
        return Ok(personToReturn);
      }

      return BadRequest("There was a problem creating a new person");
    }

    [HttpPut("{personId}")]
    public IActionResult Put(int personId, PersonRegisterDto receivedPerson)
    {
      var personExists = _peopleRepository.GetById(personId);

      if (personExists == null) return NotFound("Person not found");

      var person = _mapper.Map<Person>(receivedPerson);
    
      if (_peopleRepository.Update(person))
      {
        var personToReturn = _mapper.Map<PersonDto>(person);
        return Ok(personToReturn);
      }

      return BadRequest("There was a problem updating this person");
    }

    [HttpDelete("{personId}")]
    public IActionResult Delete(int personId)
    {
      var personToRemove = _peopleRepository.GetById(personId);

      if (personToRemove == null) return NotFound("Person not found");

      if (_peopleRepository.Delete(personToRemove)) return Ok("Person was deleted");

      return BadRequest("There was a problem deleting this person");
    }
  }
}