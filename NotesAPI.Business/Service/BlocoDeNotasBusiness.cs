using AutoMapper;
using NotesAPI.Business.Interface;
using NotesAPI.Business.Models.DTO;
using NotesAPI.Data.Interface;

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
    }
}
