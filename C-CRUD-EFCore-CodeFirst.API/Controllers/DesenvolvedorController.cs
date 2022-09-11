using C_CRUD_EFCore_CodeFirst.Core.Repositorios;
using C_CRUD_EFCore_CodeFirst.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace C_CRUD_EFCore_CodeFirst.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesenvolvedorController : ControllerBase
    {
        private readonly IDesenvolvedorRepository _desenvolvedorRepository;

        public DesenvolvedorController(IDesenvolvedorRepository desenvolvedorRepository)
        {
            _desenvolvedorRepository = desenvolvedorRepository;
        }

        [HttpPost]
        public IActionResult Create(DesenvolvedorViewModel request) 
        {
            try
            {
                return Created(HttpContext.Request.PathBase, _desenvolvedorRepository.Create(request));
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        } 

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] DesenvolvedorViewModel request)
        {
            try
            {
                _desenvolvedorRepository.Update(id, request);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _desenvolvedorRepository.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Read() => Ok(_desenvolvedorRepository.Read());
    }
}
