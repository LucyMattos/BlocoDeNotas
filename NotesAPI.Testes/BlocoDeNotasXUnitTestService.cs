using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NotesAPI.Business.Interface;
using NotesAPI.Business.Models.DTO;
using NotesAPI.Business.Models.ViewModel;
using NotesAPI.Business.Service;
using NotesAPI.Configuration;
using NotesAPI.Data.Context;
using NotesAPI.Data.Interface;
using NotesAPI.Data.Repository;
using System.Text.Json;
using Xunit;

namespace NotesAPI.Testes
{
    public class BlocoDeNotasXUnitTestService
    {
        private IBlocoDeNotasBusiness _blocoDeNotasBusiness;
        private IBlocoDeNotasRepository _blocoDeNotasRepository;
        private IMapper _mapper;

        public static DbContextOptions<NotasContext> Options { get; }

        public static string connectionString = "Server=(localdb)\\mssqllocaldb;Database=NotasDb";

        static BlocoDeNotasXUnitTestService()
        {
            Options = new DbContextOptionsBuilder<NotasContext>().UseSqlServer(connectionString).Options;
        }

        public BlocoDeNotasXUnitTestService()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ProfileConfiguration());
            });
            _mapper = config.CreateMapper();

            var context = new NotasContext(Options);

            _blocoDeNotasRepository = new BlocoDeNotasRepository(context);
            _blocoDeNotasBusiness = new BlocoDeNotasBusiness(_blocoDeNotasRepository, _mapper);

        }

        //TESTES UNITÁRIOS

        [Fact]
        public async void GetAll_Return_OkResult()
        {
            //Arrange
            var service = new BlocoDeNotasBusiness(_blocoDeNotasRepository, _mapper);

            // Act
            var data = await service.GetAllAsync();

            // Assert 
            Assert.IsType<List<BlocoDeNotasDTO>>(data);
        }

        [Fact]
        public async void GetById_Return_OkResult()
        {
            var service = new BlocoDeNotasBusiness(_blocoDeNotasRepository, _mapper);
            var notaID = 1;

            var data = await service.GetAsync(notaID);

            Assert.IsType<BlocoDeNotasDTO>(data);
        }

        [Fact]
        public async void Post_Return_OKResult()
        {
            var service = new BlocoDeNotasBusiness(_blocoDeNotasRepository, _mapper);
            var novaNota = new AddBlocoDeNotas { titulo = "Teste de POST" };

            var data = await service.AddAsync(novaNota);

            Assert.IsType<BlocoDeNotasDTO>(data);
        }

        [Fact]
        public async void Put_Return_OKResult()
        {
            //Arrange
            var service = new BlocoDeNotasBusiness(_blocoDeNotasRepository, _mapper);
            var notaId = 1002;

            //Act
            var data = await service.GetAsync(notaId);

            var atualizarNota = new UpdateBlocoDeNotas { Id = notaId, Titulo = "Atualizando nota no teste unitário de PUT" };

            var updateDto = _mapper.Map(atualizarNota, data);

            var update = await service.UpdateAsync(_mapper.Map<UpdateBlocoDeNotas>(updateDto));

            //Assert
            Assert.Equal(JsonSerializer.Serialize(updateDto), JsonSerializer.Serialize(update));
        }

        [Fact]
        public async void Put_Return_NotFound()
        {
            //Arrange
            var service = new BlocoDeNotasBusiness(_blocoDeNotasRepository, _mapper);
            var notaId = 999;

            //Act
            var data = await service.GetAsync(notaId);

            var atualizarNota = new UpdateBlocoDeNotas { Id = notaId, Titulo = "Atualizando nota com teste unitário" };

            var updateDto = _mapper.Map(atualizarNota, data);

            var update = await service.UpdateAsync(_mapper.Map<UpdateBlocoDeNotas>(updateDto));

            //Assert
            Assert.NotEqual(JsonSerializer.Serialize(updateDto), JsonSerializer.Serialize(update));
        }
    }
}
