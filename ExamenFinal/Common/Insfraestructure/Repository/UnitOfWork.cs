using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Common.Insfraestructure.Repository
{
    using ExamenFinal.Estudiante.domain.repository;

    public class UnitOfWork : IUnitOfWork
    {
        protected readonly DbEstudiantesContext _context;

        public UnitOfWork(DbEstudiantesContext context)
        {
            _context = context;
            Estudiante = new EstudianteRepository(_context);
        }

        public IEstudianteRepository Estudiante { get; private set; }

        public int Complete()
        {
            return 1;
        }

        public void Dispose()
        {
       
        }
    }
}
