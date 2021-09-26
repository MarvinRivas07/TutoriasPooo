using Maestros.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos.Negocio
{
    class NClsMaestros
    {// aqui se crea el listado
        DatosMaestros datos = new DatosMaestros();

        public List<ClsMaestros> NListaMaestros()
        {
            List<ClsMaestros> listado = datos.ListaProfesores();

            return listado;
        }
    }
}
