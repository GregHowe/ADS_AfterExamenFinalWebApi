
namespace ExamenFinal.Estudiante.application
{
    using ExamenFinal.Common.Insfraestructure.Repository;
    using System;
    using System.Collections.Generic;
    using domain.entity;
    using ExamenFinal.Estudiante.domain.servicio;
    using AutoMapper;
    using ExamenFinal.Estudiante.application.dto;
    using ExamenFinal.Common.application;

    public class EstudianteApplicationService : IEstudianteApplicationService
    {
        private readonly IUnitOfWork _iUnitOfWork;
        private readonly IMapper _mapper;
        private readonly EstudianteDomainService estudianteDomainService;

        public EstudianteApplicationService(IUnitOfWork iUnitOfWork, IMapper mapper)
        {
            estudianteDomainService = new EstudianteDomainService();
            _iUnitOfWork = iUnitOfWork;
            _mapper = mapper;
        }

        void validacionGetEstudiante(int idNivelEstudio)
        {
            Notification notification = new Notification();
            if (idNivelEstudio == 0)
            {   
                    notification.addError("idNivelEstudio cannot be null");
            }
            if (notification.hasErrors())
            {
                throw new ArgumentException(notification.errorMessage());
            }
        }

        public List<EstudianteDto> GetEstudiantePorNivel(int idNivelEstudio)
        {
            var result = _iUnitOfWork.Estudiante.getEstudianteByNivelEstudio(idNivelEstudio);
            var resultDto = _mapper.Map<List<EstudianteDto>>(result);
            return resultDto;
        }

        public decimal getMontoStudies(int id)
        {
            validacionGetEstudiante(id);

            decimal result = 0;
            Estudiante student = _iUnitOfWork.Estudiante.getStudentById(id);
            if (student != null)
                result = estudianteDomainService.getAmountStudyByLevel(student);
            return result;
        }


        public List<NivelEstudioDto> getNivelEstudio()
        {
            var result = _iUnitOfWork.Estudiante.getNivelEstudio();
            var resultDto = _mapper.Map<List<NivelEstudioDto>>(result);
            return resultDto;
        }


    }
}
