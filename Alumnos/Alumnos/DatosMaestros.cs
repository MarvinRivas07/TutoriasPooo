using Alumnos.Entidades;
using Maestros.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Alumnos
{
    class DatosMaestros
    {
        List<ClsMaestros> ListaMaestros = new List<ClsMaestros>();

        public List<ClsMaestros> ListaProfesores()
        {
            if (ListaMaestros.Count != 0)
            {
                return ListaMaestros;
            }
            else
            {
                ListaMaestros.Add(new ClsMaestros(1, "Katia", "Ardon", 20));
                ListaMaestros.Add(new ClsMaestros(2, "Jonathan", "Castro", 21));
                ListaMaestros.Add(new ClsMaestros(3, "Josue", "Cardoza", 29));
                ListaMaestros.Add(new ClsMaestros(4, "Alonso", "Mejia", 29));
                ListaMaestros.Add(new ClsMaestros(5, "Miguel", "Ramirez", 27));
                ListaMaestros.Add(new ClsMaestros(6, "Lorena", "Martinez", 23));
                ListaMaestros.Add(new ClsMaestros(7, "Julia", "Ramirez", 22));

                return ListaMaestros;


            }
        }
    }
}
