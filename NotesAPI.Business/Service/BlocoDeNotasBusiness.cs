using AutoMapper;
using NotesAPI.Business.Interface;
using NotesAPI.Business.Models.DTO;
using NotesAPI.Business.Models.ViewModel;
using NotesAPI.Data.Interface;
using NotesAPI.Data.Models.Entities;

namespace NotesAPI.Business.Service
{
    public class BlocoDeNotasBusiness : IBlocoDeNotasBusiness
    {
        private readonly IBlocoDeNotasRepository _blocoDeNotasRepository;
        private readonly IMapper _mapper;

        public BlocoDeNotasBusiness(IBlocoDeNotasRepository blocoDeNotasRepository, IMapper mapper)
        {
            _blocoDeNotasRepository = blocoDeNotasRepository;
            _mapper = mapper;
        }

        public async Task<List<BlocoDeNotasDTO>> GetAllAsync()
        {
            var data = await _blocoDeNotasRepository.GetAllAsync();
            return _mapper.Map<List<BlocoDeNotasDTO>>(data);
        }

        public async Task<BlocoDeNotasDTO> GetAsync(int id)
        {
            var data = await _blocoDeNotasRepository.GetAsync(id);
            return _mapper.Map<BlocoDeNotasDTO>(data);
        }
        public async Task<BlocoDeNotasDTO> AddAsync(AddBlocoDeNotas notas)
        {
            var entity = _mapper.Map<BlocoDeNota>(notas);
            entity = await _blocoDeNotasRepository.AddAsync(entity);

            return _mapper.Map<BlocoDeNotasDTO>(entity);
        }

        public async Task UpdateAsync(UpdateBlocoDeNotas notas)
        {
            var data = await _blocoDeNotasRepository.GetAsync(notas.Id);
            if (data == null)
                return;

            var entity = _mapper.Map(notas, data);
            await _blocoDeNotasRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var nota = await _blocoDeNotasRepository.GetAsync(id);
            if (nota != null)
            {
                await _blocoDeNotasRepository.DeleteAsync(nota);
            }
        }
    }
}