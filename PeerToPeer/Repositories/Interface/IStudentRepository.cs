using PeerToPeer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeerToPeer.Repositories.Interface
{
    public interface IStudentRepository
    {
        Student createStudent(Student student);
        List<Student> getAllStudents();
        Student getStudent(int id);
        Student updateStudent(Student student);

        Student deleteStudent(int id);
    }
}
