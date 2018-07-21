using ExamenFinal.Estudiante.domain.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Common.Insfraestructure.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IEstudianteRepository Estudiante { get; }
        int Complete();
    }
}
