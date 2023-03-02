using Microsoft.EntityFrameworkCore;
using NotesAPI.Business.Models.Entities;
using NotesAPI.Data.Context;
using NotesAPI.Data.Interface;

namespace NotesAPI.Data.Repository
{
    public class BlocoDeNotasRepository : Repository<BlocoDeNotas>, IBlocoDeNotasRepository
    {
        private readonly NotesContext context;
        public BlocoDeNotasRepository(NotesContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<List<BlocoDeNotas>> GetAllAsync()
        {
            return await context.BlocoDeNotas.ToListAsync();
        }

        public async Task<BlocoDeNotas> GetAsync(int id)
        {
            return await context.BlocoDeNotas.Where(bloco => bloco.Id == id).FirstOrDefaultAsync();
            
        }
    }
}
