using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NotesAPI.Business.Interface;
using NotesAPI.Business.Service;
using NotesAPI.Configuration;
using NotesAPI.Data.Context;
using NotesAPI.Data.Interface;
using NotesAPI.Data.Repository;

namespace NotesAPI.Testes
{
    public class BlocoDeNotasUnitTestService
    {
        private IBlocoDeNotasBusiness _blocoDeNotasBusiness;
        private IBlocoDeNotasRepository _blocoDeNotasRepository;
        private IMapper mapper;

        //1- propriedade para definir e usar um instancia do contexto
        public static DbContextOptions<NotasContext> Options { get; }

        //2 -para utilizar o banco de dados
        public static string connectionString = "Server=(localdb)\\mssqllocaldb;Database=NotasDb";

        //3 - contrutor para inicializar a propriedade estatica (1 )acima
        static BlocoDeNotasUnitTestService()
        {
            Options = new DbContextOptionsBuilder<NotasContext>().UseSqlServer(connectionString).Options;
        }

        public BlocoDeNotasUnitTestService()
        {
            var config = new MapperConfiguration(cfg =>
            { 
                cfg.AddProfile(new ProfileConfiguration());
            });
            mapper = config.CreateMapper();

            var context = new NotasContext(Options);

            _blocoDeNotasRepository = new BlocoDeNotasRepository (context);
            _blocoDeNotasBusiness = new BlocoDeNotasBusiness (_blocoDeNotasRepository, mapper);

        }
    }
}
