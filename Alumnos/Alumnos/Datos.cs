using Alumnos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    class Datos
    {
        List<ClsAlumnos> ListaEstudiantes = new List<ClsAlumnos>();

        public List<ClsAlumnos> listadeAlumnos()
        {
            if (ListaEstudiantes.Count != 0)
            {
                return ListaEstudiantes;
            }
            else
            {
                ListaEstudiantes.Add(new ClsAlumnos(1, "Wilfredo", "Morales", 19, 7.4));
                ListaEstudiantes.Add(new ClsAlumnos(2, "Cristian", "Figueroa", 18, 9.9));
                ListaEstudiantes.Add(new ClsAlumnos(3, "Nelson", "Calles", 20, 9.3));
                ListaEstudiantes.Add(new ClsAlumnos(4, "Katia", "Quijada", 18, 9.9));
                ListaEstudiantes.Add(new ClsAlumnos(5, "Kemberly", "Vasquez", 18, 7.5));

                return ListaEstudiantes;
            }

        }
        public void AgregarAlumnos(ClsAlumnos alumnoNuevo)
        {
            ListaEstudiantes.Add(alumnoNuevo);
        }
        public void EditarAlumno(ClsAlumnos alumnoeditando)
        {
            for (int i = 0; i < ListaEstudiantes.Count; i++)
            {
                if (ListaEstudiantes[i].Id == alumnoeditando.Id)
                {
                    ListaEstudiantes[i] = alumnoeditando;
                }
            }
        }
        public void EliminarAlumno(ClsAlumnos alumnoEliminado)
        {
            ListaEstudiantes.RemoveAll(r => r.Id == alumnoEliminado.Id); 
        }
    }
}
