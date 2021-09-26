using Alumnos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Alumnos.Negocio
{
    class NClsAlumnos
    {
        Datos datos = new Datos();

        public List<ClsAlumnos> NListaDeALumnos()
        {
            List<ClsAlumnos> lista = datos.listadeAlumnos();

            return lista;
        }

        public void NAgregarAlumno(ClsAlumnos alumnoNuevo)
        {
            alumnoNuevo.Promedio = 0;
            datos.AgregarAlumnos(alumnoNuevo);
        }
        public void N_EditarAlumno(ClsAlumnos alumnoEditado)
        {
            datos.EditarAlumno(alumnoEditado);
        }


        public void N_eliminarAlumno(ClsAlumnos alumnoEliminado) {
            datos.EliminarAlumno(alumnoEliminado);
        }

    }
    
    
        
    
   
}
