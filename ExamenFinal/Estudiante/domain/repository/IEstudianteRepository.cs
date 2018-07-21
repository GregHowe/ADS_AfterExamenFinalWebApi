namespace ExamenFinal.Estudiante.domain.repository
{
    using ExamenFinal.Common.Insfraestructure.Repository;
    using ExamenFinal.Estudiante.domain.entity;
    using System.Collections.Generic;

    public interface IEstudianteRepository : IBaseRepository<Estudiante>
    {
         List<Estudiante> getEstudianteByNivelEstudio(int idNivelEstudio);
        Estudiante getStudentById(int idNivelEstudio);
        List<NivelEstudio> getNivelEstudio();
    }
}
