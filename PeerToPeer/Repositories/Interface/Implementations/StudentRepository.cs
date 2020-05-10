using PeerToPeer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeerToPeer.Repositories.Interface.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        private PeerToPeerContext context;
        public StudentRepository(PeerToPeerContext context)
        {
            this.context = context;
        }
        public List<Student> getAllStudents()
        {
            List<Student> students = context.Students.ToList();
            return students;
        }
        public Student getStudent(int id)
        {
            Student student;
            IEnumerable<Student> students = context.Students.Where(x => x.Id == id);
            student = students.FirstOrDefault();

            return student;

        }

        public Student updateStudent(Student student)
        {
            // Student updatedStudent = context.Students.Where(x => x.Id == student.Id).FirstOrDefault();
            context.Update(student);
            context.SaveChanges();

            return student;


        }

        public Student deleteStudent(int id)
        {
            Student student;
            student = context.Students.Where(x => x.Id == id).FirstOrDefault();
            student.isDeleted = true;
            context.SaveChanges();

            return student;

        }
        public Student createStudent(Student student)
        {
            Student newStudent = student;
            context.Students.Add(student);
            context.SaveChanges();
            return newStudent;
        }
    }
}
