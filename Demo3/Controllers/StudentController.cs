using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo3.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    { 
        
        public IStudentService StudentService { get; }
        public StudentController(IStudentService studentService)
        {
            StudentService = studentService;
        }


        [HttpGet]
        public List<Student> GetAll()
        {
            var res= StudentService.GetAll();
            return res;
        }
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return StudentService.Get(id);
        }


        [HttpPost]
        public void Post( Student student)
        {
            StudentService.Add(student);
        }
        [HttpPut]
        public void Put(Student student)
        {
            StudentService.Update(student);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Student student = StudentService.Get(id);

            StudentService.Delete(student);
        }

    }
}