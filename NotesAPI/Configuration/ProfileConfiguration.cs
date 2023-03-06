﻿using AutoMapper;
using NotesAPI.Business.Models.DTO;
using NotesAPI.Data.Models.Entities;

namespace NotesAPI.Configuration
{
    public class ProfileConfiguration : Profile
    {
        public ProfileConfiguration()
        {
            CreateMap<BlocoDeNota, BlocoDeNotasDTO>().ReverseMap();
            CreateMap<BlocoDeNotasIten, BlocoDeNotasItensDTO>().ReverseMap();
          
        }
    }
}
