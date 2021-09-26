using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestros.Entidades
{
    class ClsMaestros
    {
        private int id;
        private string nombre;
        private string apellido;
        private int edad;

       

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public int V1 { get; }
        public string V2 { get; }

        public ClsMaestros() { }
        public ClsMaestros(int id, string nombre, string apellido, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;

        }

       

        public override string ToString()
        {
            return string.Format("Id: {0}, Nombre: {1} {2} Edad: {3}", id, nombre, apellido, edad);
        }


    }   
}
