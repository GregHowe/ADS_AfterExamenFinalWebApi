
namespace ExamenFinal.Estudiante.application
{
    using ExamenFinal.Estudiante.application.dto;
    using System.Collections.Generic;

    public interface IEstudianteApplicationService
    {

        List<EstudianteDto> GetEstudiantePorNivel(int idNivelEstudio);
        decimal getMontoStudies(int id);
        List<NivelEstudioDto> getNivelEstudio();

    }
}
