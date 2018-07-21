

namespace ExamenFinal.Automapper
{
    using ExamenFinal.Estudiante.domain.entity;
    using AutoMapper;
    using ExamenFinal.Estudiante.application.dto;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Estudiante, EstudianteDto>().ReverseMap();
        }

    }
}
