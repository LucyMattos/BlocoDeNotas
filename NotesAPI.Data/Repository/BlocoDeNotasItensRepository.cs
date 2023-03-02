using Microsoft.EntityFrameworkCore;
using NotesAPI.Data.Models.Entities;
using NotesAPI.Data.Context;
using NotesAPI.Data.Interface;

namespace NotesAPI.Data.Repository
{
    public class BlocoDeNotasItensRepository : Repository<BlocoDeNotasItens>, IBlocoDeNotasItensRepository
    {
        private readonly NotesContext _context;
        public BlocoDeNotasItensRepository(NotesContext context) : base(context)
        {
           this._context = context;
        }

        public async Task<BlocoDeNotasItens> GetAsync(int id)
        {
            return await _context.BlocoDeNotasItens.Where(bloco => bloco.Id == id).FirstOrDefaultAsync();

        }
    }
}
