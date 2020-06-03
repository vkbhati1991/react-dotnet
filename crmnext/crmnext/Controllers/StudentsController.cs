using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using APP.Generators;
using APP.Messages;
using IDAL.IStudent;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MODEL.Student;

namespace APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudent _student;

        public StudentsController(IStudent student)
        {
            _student = student;
        }

        [HttpGet]
        public ActionResult GetAllUsers()
        {
            List<Student> students = _student.GetAllStudents();

            object studentListing = StudentListInfo.GetStudentListInfo(students);

            return Ok(studentListing);
        }

        [HttpPost]
        public ActionResult CreateUser(Student student)
        {
            string errorStatus = _student.CreateStudent(student);
            Message message = new Message(errorStatus);

            return Ok(message.ErrorMessage(student.StudentId));
        }

        [HttpDelete]
        public ActionResult DeleteStudent(Student student)
        {
            string errorStatus = _student.DeleteStudent(student);
            Message message = new Message(errorStatus);
            return Ok(message.ErrorMessage(student.StudentId));
        }

        [HttpGet("{StudentId}", Name = "GetStudentById")]
        public ActionResult GetStudentById(int StudentId)
        {
            Student student = _student.GetStudentById(StudentId);

            return Ok(student);
        }

    }
}