using Microsoft.EntityFrameworkCore;
using NotesAPI.Data.Models.Entities;
using NotesAPI.Data.Context;
using NotesAPI.Data.Interface;

namespace NotesAPI.Data.Repository
{
    public class BlocoDeNotasRepository : Repository<BlocoDeNota>, IBlocoDeNotasRepository
    {
        private readonly NotasContext _context;
        public BlocoDeNotasRepository(NotasContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<BlocoDeNota> GetAsync(int id)
        {
            return await _context.BlocoDeNotas.Where(bloco => bloco.Id == id)
                .Include(n => n.BlocoDeNotasItens)
                .FirstOrDefaultAsync();
            
        }
    }
}
