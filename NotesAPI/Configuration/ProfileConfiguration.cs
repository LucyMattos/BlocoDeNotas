using AutoMapper;
using NotesAPI.Business.Models.DTO;
using NotesAPI.Business.Models.ViewModel;
using NotesAPI.Data.Models.Entities;

namespace NotesAPI.Configuration
{
    public class ProfileConfiguration : Profile
    {
        public ProfileConfiguration()
        {
            CreateMap<BlocoDeNota, BlocoDeNotasDTO>().ReverseMap();
            CreateMap<BlocoDeNotasIten, BlocoDeNotasItensDTO>().ReverseMap();

            CreateMap<AddBlocoDeNotasItens, BlocoDeNotasItensDTO>().ReverseMap();
            CreateMap<AddBlocoDeNotasItens, BlocoDeNotasIten>().ReverseMap();
            CreateMap<UpdateBlocoDeNotasItens, BlocoDeNotasItensDTO>().ReverseMap();
            CreateMap<UpdateBlocoDeNotasItens, BlocoDeNotasIten>().ReverseMap();

            CreateMap<AddBlocoDeNotas, BlocoDeNotasDTO>().ReverseMap();
            CreateMap<AddBlocoDeNotas, BlocoDeNota>().ReverseMap();
            CreateMap<UpdateBlocoDeNotas, BlocoDeNotasDTO>().ReverseMap();
            CreateMap<UpdateBlocoDeNotas, BlocoDeNota>().ReverseMap();

           
          
        }
    }
}
