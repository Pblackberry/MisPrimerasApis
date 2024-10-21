namespace MisPrimerasApis.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Boolean EstaInscrito { get; set; }
    }
}
