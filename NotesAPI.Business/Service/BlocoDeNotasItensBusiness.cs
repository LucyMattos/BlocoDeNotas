using AutoMapper;
using NotesAPI.Business.Interface;
using NotesAPI.Business.Models.DTO;
using NotesAPI.Data.Interface;
using NotesAPI.Data.Models.Entities;

namespace NotesAPI.Business.Service
{
    public class BlocoDeNotasItensBusiness : IBlocoDeNotasItensBusiness
    {
        private readonly IBlocoDeNotasItensRepository _blocoDeNotasItensRepository;
        private readonly IMapper _mapper;

        public BlocoDeNotasItensBusiness(IBlocoDeNotasItensRepository blocoDeNotasItensRepository, IMapper mapper)
        {
            _blocoDeNotasItensRepository = blocoDeNotasItensRepository;
            _mapper = mapper;
        }

        public async Task<List<BlocoDeNotasItensDTO>> GetAllAsync()
        {
            var data = await _blocoDeNotasItensRepository.GetAllAsync();
            return _mapper.Map<List<BlocoDeNotasItensDTO>>(data);
        }

        public async Task<BlocoDeNotasItensDTO> GetAsync(int id)
        {
            var data = await _blocoDeNotasItensRepository.GetAsync(id);
            return _mapper.Map<BlocoDeNotasItensDTO>(data);
     
        }

        public async Task<BlocoDeNotasItensDTO> AddAsync(BlocoDeNotasItensDTO notas)
        {
            var entity = _mapper.Map<BlocoDeNotasIten>(notas);
            entity = await _blocoDeNotasItensRepository.AddAsync(entity);

            return _mapper.Map<BlocoDeNotasItensDTO>(entity);
        }

        public async Task UpdateAsync(BlocoDeNotasItensDTO notas)
        {
            var data = await _blocoDeNotasItensRepository.GetAsync(notas.Id);
            if (data == null)
                return;

            var entity = _mapper.Map(notas, data);
            await _blocoDeNotasItensRepository.UpdateAsync(entity);
        }

        public  async Task DeleteAsync(int id)
        {
            var nota = await _blocoDeNotasItensRepository.GetAsync(id);
            if (nota != null)
            {
                await _blocoDeNotasItensRepository.DeleteAsync(nota);
            }
        }
    }
}
