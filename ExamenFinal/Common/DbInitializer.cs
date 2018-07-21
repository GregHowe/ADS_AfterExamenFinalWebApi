
namespace ExamenFinal.Common
{
    using ExamenFinal.Estudiante.domain.entity;
    using ExamenFinal.Common.Insfraestructure.Repository;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ExamenFinal.Common.Insfraestructure.enumeration;

    public class DbInitializer
    {
        private readonly DbEstudiantesContext _context;

        public DbInitializer(DbEstudiantesContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();

            if (context.Estudiantes.Any())
            {
                return;
            }


            int n = 100;
            for (int i = 1; i < n; i++)
            {
                var newEstudiante = new EstudiantePreGrado { Id = i, Nombre = "Name " + i, Apellido = "Ape " + i, IsActive = true, Codigo = "ABC" + i, IdTipoNivelEstudio = (int)TypeEstudio.Pregrado };
                _context.Estudiantes.Add(newEstudiante);
            }

            n = 200;
            for (int i = 100; i < n; i++)
            {
                var newEstudiante = new EstudianteMaestria { Id = i, Nombre = "Name " + i, Apellido = "Ape " + i, IsActive = true, Codigo = "ABC" + i, IdTipoNivelEstudio = (int)TypeEstudio.Maestria };
                _context.Estudiantes.Add(newEstudiante);
            }

            n = 300;
            for (int i = 200; i < n; i++)
            {
                var newEstudiante = new EstudianteDoctorado {Id = i,  Nombre = "Name " + i, Apellido = "Ape " + i, IsActive = true, Codigo = "ABC" + i, IdTipoNivelEstudio = (int)TypeEstudio.Doctorado };
                _context.Estudiantes.Add(newEstudiante);
            }

            var newNivelEstudio = new NivelEstudio { Id = 1, Nombre = "Pregrado"};
            _context.NivelEstudios.Add(newNivelEstudio);
             newNivelEstudio = new NivelEstudio { Id =2, Nombre = "Maestria" };
            _context.NivelEstudios.Add(newNivelEstudio);
             newNivelEstudio = new NivelEstudio { Id = 3, Nombre = "Doctorado" };
            _context.NivelEstudios.Add(newNivelEstudio);

            _context.SaveChanges();
        }






    }
}
