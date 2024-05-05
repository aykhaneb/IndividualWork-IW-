using Academy.DAL.DataContext;
using Academy.DAL.Entities;
using Academy.DAL;
using Academy.DAL.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            var result = await _studentRepository.GetAllAsync();

            return Ok(result);
        }
    }
}
