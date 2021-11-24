using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo3.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    public interface IStudentService
    {
        List<Student> GetAll();
        Student Get(int id);

        void Add(Student student);
        void Update(Student student);

        void Delete(Student student);
    }
    public class StudentService : IStudentService
    {
        List<Student> students;
        public StudentService()
        {
            students = new List<Student>()
            {
                new Student(){Id=1,Name="amir",Surname="amiri"},
                new Student(){Id=2,Name="reza",Surname="rezaii"}
            };
        }
        public void Add(Student student)
        {
            students.Add(student);
        }

        public void Delete(Student student)
        {
            students.Remove(student);
        }

        public Student Get(int id)
        {
            return students.Single(a => a.Id == id);
        }

        public List<Student> GetAll()
        {
            return students;
        }

        public void Update(Student student)
        {
            int index = students.FindIndex(a => a.Id == student.Id);
            students[index] = student;
        }
    }
}
