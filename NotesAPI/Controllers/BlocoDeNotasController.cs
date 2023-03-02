using Microsoft.AspNetCore.Mvc;
using NotesAPI.Business.Interface;
using NotesAPI.Business.Models.DTO;
using NotesAPI.Business.Service;

namespace NotesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlocoDeNotasController : ControllerBase
    {
        private readonly IBlocoDeNotasBusiness _blocoDeNotasBusiness;

        public BlocoDeNotasController(IBlocoDeNotasBusiness blocoDeNotasBusiness)
        {
            this._blocoDeNotasBusiness = blocoDeNotasBusiness;
        }

        [HttpGet()]
        public async Task<ActionResult<List<BlocoDeNotasBusiness>>> GetAll()
        {
            var data = await _blocoDeNotasBusiness.GetAllAsync();
            if (data == null)
                return NoContent();

            return Ok(data);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<BlocoDeNotasBusiness>> GetById(int id)
        {
            var data = await _blocoDeNotasBusiness.GetAsync(id);
            if (data == null)
                return NoContent();
            return Ok(data);
        }

        [HttpPost]
        public async Task<ActionResult<BlocoDeNotasBusiness>> Add(BlocoDeNotasDTO notas)
        {
            var data = await _blocoDeNotasBusiness.AddAsync(notas);
            return Ok(data);
        }

        [HttpPut]
        public async Task<ActionResult<BlocoDeNotasBusiness>> Update(BlocoDeNotasDTO notas)
        {
            await _blocoDeNotasBusiness.UpdateAsync(notas);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await _blocoDeNotasBusiness.DeleteAsync(id);
            return Ok();
        }

    }
}
