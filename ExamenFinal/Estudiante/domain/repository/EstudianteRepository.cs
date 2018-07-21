using ExamenFinal.Common.Insfraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Estudiante.domain.repository
{
    using ExamenFinal.Estudiante.domain.entity;

    public class EstudianteRepository : BaseRepository<Estudiante>, IEstudianteRepository
    {
        public EstudianteRepository(DbEstudiantesContext dbContext) : base(dbContext)
        {
        }

        public List<Estudiante> getEstudianteByNivelEstudio(int idNivelEstudio)
        {
            var estudiantes = new List<Estudiante>();
            return base._context.Set<Estudiante>().Where(x => x.IdTipoNivelEstudio == idNivelEstudio || idNivelEstudio == 0).ToList();         
        }

        public Estudiante getStudentById(int idEstudiante)
        {
            return base._context.Set<Estudiante>().Where(x => x.Id == idEstudiante).FirstOrDefault();
        }

        public List<NivelEstudio> getNivelEstudio()
        {
            return base._context.Set<NivelEstudio>().ToList();
        }



    }
}
