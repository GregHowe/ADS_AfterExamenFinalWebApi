using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Estudiante.domain.entity
{
    public class EstudianteDoctorado : Estudiante
    {
        public override decimal getMontoEstudios()
        {
            return 200;
        }
    }
}
