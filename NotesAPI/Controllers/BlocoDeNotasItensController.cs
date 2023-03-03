using Microsoft.AspNetCore.Mvc;
using NotesAPI.Business.Interface;
using NotesAPI.Business.Models.DTO;
using NotesAPI.Business.Service;

namespace NotesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlocoDeNotasItensController : ControllerBase
    {
        private readonly BlocoDeNotasItensBusiness _blocoDeNotasItensBusiness;

        public BlocoDeNotasItensController(BlocoDeNotasItensBusiness blocoDeNotasItensBusiness)
        {
            this._blocoDeNotasItensBusiness = blocoDeNotasItensBusiness;
        }

        [HttpGet()]
        public async Task<ActionResult<List<BlocoDeNotasItensBusiness>>> GetAll()
        {
            var data = await _blocoDeNotasItensBusiness.GetAllAsync();
            if (data == null)
                return NoContent();

            return Ok(data);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<BlocoDeNotasItensBusiness>> GetbyId(int id)
        {
            var data = await _blocoDeNotasItensBusiness.GetAsync(id);
            if (data == null)
                return NoContent();

            return Ok(data);
        }

        [HttpPost]
        public async Task<ActionResult<BlocoDeNotasItensBusiness>> Add(BlocoDeNotasItensDTO notas)
        {
            var data = await _blocoDeNotasItensBusiness.AddAsync(notas);
            return Ok(data);
        }

        [HttpPut]
        public async Task<ActionResult<BlocoDeNotasItensBusiness>> Update(BlocoDeNotasItensDTO notas)
        {
            await _blocoDeNotasItensBusiness.UpdateAsync(notas);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await _blocoDeNotasItensBusiness.DeleteAsync(id);
            return Ok();
        }
    }
}
