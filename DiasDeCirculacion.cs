using System.Collections.Generic;
namespace ProyectoIntegrador
{
    public class DiasDeCirculacion
    {
        public int UltimoDigitoPlaca
        {
            get; set;
        }
        public List<DiaSemana> Dias
        {
            get; set;
        } = new List<DiaSemana>();


    }
    public enum DiaSemana
    {
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado,
        Domingo

    }


}







/*Programa para ayudar a recordar los dias de circulacion de un vehiculo y fecha de matriculacion*/