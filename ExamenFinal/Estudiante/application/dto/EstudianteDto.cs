using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Estudiante.application.dto
{
    public class EstudianteDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido;
        public bool IsActive;
        public  string Codigo;
        public  int IdTipoNivelEstudio { get; set; }

    }
}
