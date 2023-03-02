using Microsoft.EntityFrameworkCore;
using NotesAPI.Business.Models.Entities;
using NotesAPI.Data.Context;
using NotesAPI.Data.Interface;

namespace NotesAPI.Data.Repository
{
    public class BlocoDeNotasItensRepository : Repository<BlocoDeNotasItens>, IBlocoDeNotasItensRepository
    {
        private readonly NotesContext context;
        public BlocoDeNotasItensRepository(NotesContext context) : base(context)
        {
           this.context = context;
        }

        public async Task<BlocoDeNotasItens> GetAsync(int id)
        {
            return await context.BlocoDeNotasItens.Where(bloco => bloco.Id == id).FirstOrDefaultAsync();

        }
    }
}
