using Microsoft.AspNetCore.Mvc;
using NotesAPI.Business.Interface;
using NotesAPI.Business.Models.DTO;
using NotesAPI.Business.Models.ViewModel;
using NotesAPI.Business.Service;

namespace NotesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlocoDeNotasItensController : ControllerBase
    {
        private readonly IBlocoDeNotasItensBusiness _blocoDeNotasItensBusiness;

        public BlocoDeNotasItensController(IBlocoDeNotasItensBusiness blocoDeNotasItensBusiness)
        {
            this._blocoDeNotasItensBusiness = blocoDeNotasItensBusiness;
        }

        [HttpGet()]
        public async Task<ActionResult<List<BlocoDeNotasItensDTO>>> GetAll()
        {
            var data = await _blocoDeNotasItensBusiness.GetAllAsync();
            if (data == null)
                return NoContent();

            return Ok(data);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<BlocoDeNotasItensDTO>> GetbyId(int id)
        {
            var data = await _blocoDeNotasItensBusiness.GetAsync(id);
            if (data == null)
                return NoContent();

            return Ok(data);
        }

        [HttpPost]
        public async Task<ActionResult<BlocoDeNotasItensDTO>> Add(AddBlocoDeNotasItens item)
        {
            var data = await _blocoDeNotasItensBusiness.AddAsync(item);
            return Ok(data);
        }

        [HttpPut]
        public async Task<ActionResult<BlocoDeNotasItensDTO>> Update(UpdateBlocoDeNotasItens item)
        {
            await _blocoDeNotasItensBusiness.UpdateAsync(item);
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
