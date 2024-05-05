using Academy.DAL.DataContext;
using Academy.DAL.Entities;
using Academy.DAL;
using Academy.DAL.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Academy.BLL.Dtos.Student;

namespace Academy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        private readonly IRepositoryAsync<Student> _studentRepository;

        public StudentsController(IRepositoryAsync<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()

        {
             var result =  _studentRepository.GetAllAsync();

            var studentDtos = new List<StudentDto>();

            //foreach (var student in result)
            //{
            //    studentDtos.Add(new StudentDto
            //    { Id = student.Id, Name = student.Name });
            //}

            return Ok(studentDtos);
        }

        [HttpPost]

        public async Task Post(Student student)
        {
            await _studentRepository.AddAsync(student);
        }
    }
}
