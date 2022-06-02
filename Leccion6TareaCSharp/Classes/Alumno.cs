using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion6TareaCSharp.Classes
{
    public  class Alumno
    {
        public string Carne { get; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public int ClaseAsignada { get; set; }
        public Alumno() : this("N/A", "N/A", "N/A", DateTime.Parse("1/1/1"), 1) 
        {
        }


        public Alumno(string carne, string nombre, string apellido, DateTime fechaNac, int claseAsignada)
        {
            this.Carne = carne;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNac = fechaNac;
            this.ClaseAsignada = claseAsignada;

        }
        public override string ToString()
        {

            return $"Carne: {Carne}, Nombre: {Nombre}, Apellido{Apellido} Fecha Nacimiento: {FechaNac} Clase Asignada:{ClaseAsignada}";
        }
    }
}
