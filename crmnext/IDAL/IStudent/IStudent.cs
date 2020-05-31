using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL.Student;

namespace IDAL.IStudent
{
    public interface IStudent
    {
        List<Student> GetAllStudents();

        string CreateStudent(Student student);

        Student GetStudentById(int StudentId);

        string DeleteStudent(Student student);
    }
}
