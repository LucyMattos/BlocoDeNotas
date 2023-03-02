using AutoMapper;
using NotesAPI.Business.Interface;
using NotesAPI.Business.Models.DTO;
using NotesAPI.Data.Interface;

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
    }
}
