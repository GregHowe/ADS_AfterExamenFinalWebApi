using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Estudiante.domain.entity
{
    public class EstudianteMaestria : Estudiante
    {
    
        public override decimal getMontoEstudios()
        {
            return 150;
        }
    }
}
