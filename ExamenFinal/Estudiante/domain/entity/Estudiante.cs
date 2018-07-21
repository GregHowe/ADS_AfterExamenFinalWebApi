
namespace ExamenFinal.Estudiante.domain.entity
{
    public abstract class Estudiante
    {
        public  int Id
        {
            get;
            set;
        }
        public  string Nombre
        {
            get;
            set;
        }
        public  string Apellido
        {
            get;
            set;
        }
        public  int IdTipoNivelEstudio
        {
            get;
            set;
        }

        public  string Codigo
        {
            get;
            set;
        }
        public  bool IsActive
        {
            get;
            set;
        }
        public abstract decimal getMontoEstudios();
        
        public void ActivarEstudiante()
        {
            this.IsActive = true;
        }

        public void DesactivarEstudiante()
        {
            this.IsActive = false;
        }

        public bool hasIdentity()
        {
            return !string.IsNullOrWhiteSpace(this.Codigo);
        }


    }
}
