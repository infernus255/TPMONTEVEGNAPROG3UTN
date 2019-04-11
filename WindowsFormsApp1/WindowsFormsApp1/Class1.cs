using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNac { get; set; }
        public string Sexo { get; set; }
        public string EstiloMus { get; set; }
        public string Color { get; set; }
        public int Edad { get; set; }
        public Persona(string nombre, string apellido, string fechaNac, string sexo, string estiloMus, string color, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechaNac;
            Sexo = sexo;
            EstiloMus = estiloMus;
            Color = color;
            Edad = edad;
            
        }

        public Persona()
        {
        }
    }
}
