using Microsoft.AspNetCore.Mvc;
using ReRideWebAPI.Models;
using ReRideWebAPI.Services.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReRideWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService StudentService;

       
        public StudentController(IStudentService StudentService)
        {
            this.StudentService = StudentService;
        }
       
        [HttpGet("{id}")]
        public string Get(int id)
        {
            // code to fetch data from db 

            return "value";
        }

       
        [HttpPost]
        public void Post(Student  newStudent)
        {
            // post

            StudentService.Add(newStudent);
        }

    }
}
