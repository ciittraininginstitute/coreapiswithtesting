using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleCoreApis.Models;
namespace SampleCoreApis.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {

        [HttpGet]
        [Route("api/student")]
        public List<Student> GetAll()
        {
            return GetStudents();
        }
        [HttpGet]
        [Route("api/student/{id}")]
        public Student  GetById(int id)
        {
            return GetStudents().FirstOrDefault(e=>e.StudentId.Equals(id));
        }



        [NonAction]
        public List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student(){ StudentId=1, StudentName="Ajay", Qualification="BE", Percentage=78},
                new Student(){ StudentId=2, StudentName="Divya", Qualification="BSC", Percentage=71},
                new Student(){ StudentId=3, StudentName="Dinesh", Qualification="BA", Percentage=34},
                new Student(){ StudentId=4, StudentName="Amit", Qualification="BE", Percentage=65},
                new Student(){ StudentId=5, StudentName="Vijay", Qualification="BCOM", Percentage=72},
                new Student(){ StudentId=6, StudentName="Jay", Qualification="BSC", Percentage=62},
                new Student(){ StudentId=7, StudentName="Suresh", Qualification="BE", Percentage=56},
                new Student(){ StudentId=8, StudentName="Meenal", Qualification="BBA", Percentage=79},
                new Student(){ StudentId=9, StudentName="Mahesh", Qualification="BCOM", Percentage=79},
                new Student(){ StudentId=10, StudentName="Anita", Qualification="BSC", Percentage=54},
                new Student(){ StudentId=11, StudentName="Jata", Qualification="BA", Percentage=81}
            };
        }
    }
}
