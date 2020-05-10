using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeerToPeer.Models;
using PeerToPeer.Repositories.Interface;

namespace PeerToPeer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IStudentRepository _studentRepository;

        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }



        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAll()
        {
            IEnumerable<Student> students;
            students = _studentRepository.getAllStudents();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            Student student;
            student = _studentRepository.getStudent(id);
            return Ok(student);
        }

        [HttpPost]
        public ActionResult<Student> CreateStudent(Student student)
        {

            student = _studentRepository.createStudent(student);
            return Ok(student);
        }

        [HttpPut]
        public ActionResult<Student> UpdateStudent(Student student)
        {

            _studentRepository.updateStudent(student);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Student> DeleteStudent(int id)
        {
            _studentRepository.deleteStudent(id);
            return Ok();
        }
    }
}