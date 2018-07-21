
namespace ExamenFinal.Estudiante.domain.servicio
{
    using ExamenFinal.Common.application;
    using ExamenFinal.Estudiante.domain.entity;
    
    public class EstudianteDomainService
    {
        public decimal getAmountStudyByLevel(Estudiante estudiante)
        {
            return estudiante.getMontoEstudios();
        }

    }
}
