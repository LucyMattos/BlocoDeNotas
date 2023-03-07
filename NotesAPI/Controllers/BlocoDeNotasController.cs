using Microsoft.AspNetCore.Mvc;
using NotesAPI.Business.Interface;
using NotesAPI.Business.Models.DTO;
using NotesAPI.Business.Models.ViewModel;
using NotesAPI.Business.Service;
using Swashbuckle.AspNetCore.Annotations;

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
        [SwaggerOperation(Description = "Busca todas as anotações.")]
        public async Task<ActionResult<List<BlocoDeNotasDTO>>> GetAll()
        {
            var data = await _blocoDeNotasBusiness.GetAllAsync();
            if (data == null)
                return NoContent();

            return Ok(data);
        }


        [HttpGet("{id:int}")]
        [SwaggerOperation(Description = "Busca apenas uma anotação.")]
        public async Task<ActionResult<BlocoDeNotasDTO>> GetById(int id)
        {
            var data = await _blocoDeNotasBusiness.GetAsync(id);
            if (data == null)
                return NoContent();
            return Ok(data);
        }

        [HttpPost]
        [SwaggerOperation(Description = "Cria uma nova anotação.")]
        public async Task<ActionResult<BlocoDeNotasDTO>> Add(AddBlocoDeNotas notas)
        {
            var data = await _blocoDeNotasBusiness.AddAsync(notas);
            return Ok(data);
        }

        [HttpPut]
        [SwaggerOperation(Description = "Atualiza uma anotação já existente.")]
        public async Task<ActionResult<BlocoDeNotasDTO>> Update(UpdateBlocoDeNotas notas)
        {
            await _blocoDeNotasBusiness.UpdateAsync(notas);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        [SwaggerOperation(Description = "Exclui uma anotação.")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await _blocoDeNotasBusiness.DeleteAsync(id);
            return Ok();
        }

    }
}
