using Microsoft.EntityFrameworkCore;
using NotesAPI.Data.Models.Entities;
using NotesAPI.Data.Context;
using NotesAPI.Data.Interface;

namespace NotesAPI.Data.Repository
{
    public class BlocoDeNotasItensRepository : Repository<BlocoDeNotasIten>, IBlocoDeNotasItensRepository
    {
        private readonly NotasContext _context;
        public BlocoDeNotasItensRepository(NotasContext context) : base(context)
        {
           this._context = context;
        }

        public async Task<BlocoDeNotasIten> GetAsync(int id)
        {
            return await _context.BlocoDeNotasItens.Where(bloco => bloco.Id == id).FirstOrDefaultAsync();

        }
    }
}
