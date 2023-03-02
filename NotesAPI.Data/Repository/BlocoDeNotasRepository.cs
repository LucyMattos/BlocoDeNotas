using Microsoft.EntityFrameworkCore;
using NotesAPI.Data.Models.Entities;
using NotesAPI.Data.Context;
using NotesAPI.Data.Interface;

namespace NotesAPI.Data.Repository
{
    public class BlocoDeNotasRepository : Repository<BlocoDeNotas>, IBlocoDeNotasRepository
    {
        private readonly NotesContext _context;
        public BlocoDeNotasRepository(NotesContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<BlocoDeNotas> GetAsync(int id)
        {
            return await _context.BlocoDeNotas.Where(bloco => bloco.Id == id).FirstOrDefaultAsync();
            
        }
    }
}
