using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.WebAPI.Data;
using SmartSchool.WebAPI.Dtos;
using SmartSchool.WebAPI.Models;

namespace Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class StudentController : ControllerBase
  {
    private readonly IRepository _repository;
    private readonly IMapper _mapper;

    public StudentController(IRepository repository, IMapper mapper)
    {
      _mapper = mapper;
      _repository = repository;
    }

    [HttpGet]
    public IActionResult Get()
    {
      var students = _repository.GetAllStudents(true);

      var studentsToReturn = _mapper.Map<IEnumerable<StudentDto>>(students);

      return Ok(studentsToReturn);
    }

    [HttpGet("{studentId}")]
    public IActionResult GetById(int studentId)
    {
      var student = _repository.GetStudentById(studentId);

      if (student == null) return NotFound("Student not found");

      var studentToReturn = _mapper.Map<StudentDto>(student);

      return Ok(studentToReturn);
    }

    [HttpPost()]
    public IActionResult Post(StudentRegisterDto receivedStudent)
    {
      var student = _mapper.Map<Student>(receivedStudent);
      
      _repository.Add(student);

      if (_repository.SaveChanges())
      {
        var studentToReturn = _mapper.Map<StudentDto>(student);
        return Created($"/api/student/{student.Id}", studentToReturn);
      }

      return BadRequest("There was a problem creating a new student");
    }

    [HttpPut("{studentId}")]
    public IActionResult Put(int studentId, StudentRegisterDto receivedStudent)
    {
      var studentExists = _repository.GetStudentById(studentId);

      if (studentExists == null) return NotFound("Student not found");

      var student = _mapper.Map<Student>(receivedStudent);
    
      _repository.Update(student);

      if (_repository.SaveChanges())
      {
        var studentToReturn = _mapper.Map<StudentDto>(student);
        return Created($"/api/student/{student.Id}", studentToReturn);
      }

      return BadRequest("There was a problem updating this student");
    }

    [HttpPatch("{studentId}")]
    public IActionResult Patch(int studentId, StudentRegisterDto receivedStudent)
    {
      var studentExists = _repository.GetStudentById(studentId);

      if (studentExists == null) return NotFound("Student not found");

      var student = _mapper.Map<Student>(receivedStudent);
    
      _repository.Update(student);

      if (_repository.SaveChanges())
      {
        var studentToReturn = _mapper.Map<StudentDto>(student);
        return Created($"/api/student/{student.Id}", studentToReturn);
      }

      return BadRequest("There was a problem patching this student");
    }

    [HttpDelete("{studentId}")]
    public IActionResult Delete(int studentId)
    {
      var StudentToRemove = _repository.GetStudentById(studentId);

      if (StudentToRemove == null) return NotFound("Student not found");

      _repository.Delete(StudentToRemove);

      if (_repository.SaveChanges()) return Ok("Student was deleted");

      return BadRequest("There was a problem deleting this student");
    }
  }
}