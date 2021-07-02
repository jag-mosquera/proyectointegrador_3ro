using System;

namespace ProyectoIntegrador
{
    class Matricula
    {
        public int MatriculaId { get; set; }
        public string NumeroMatricula { get;set; }
        public DateTime FechaEmisiónMatricula { get; set; }
        public DateTime FechaCaducidadMatricula { get; set; }
        public List<string> NumeroMatriculas
        {
            get; set;
        }= new List<string>();
    }
}