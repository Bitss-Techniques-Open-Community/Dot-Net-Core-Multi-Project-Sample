using data_StudentManagement;
using Microsoft.AspNetCore.Mvc;

namespace ms_StudentManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
       

        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetStudents")]
        public IEnumerable<Student> Get()
        {
            var names = Database.GetStudentNames();

            return names.Select(x => new Student { Name = x });
        }
    }
}