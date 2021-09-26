using Alumnos.Entidades;
using Alumnos.Negocio;
using Maestros.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    class Program
    {
        static void Main(string[] args)
        { // Hay que agregar los objetos por que si no da error el forich
            NClsAlumnos negocios = new NClsAlumnos();
            NClsMaestros negocio = new NClsMaestros();
            List<ClsAlumnos> listado = negocios.NListaDeALumnos();
            List<ClsMaestros> listados = negocio.NListaMaestros();
            ClsAlumnos alumno = new ClsAlumnos();
            ClsMaestros maestro = new ClsMaestros();
            int opcion = 1;

            while (opcion!=0)
            {
                Console.WriteLine("**********MENU**********" +
                    "\n1- Ver lista de alumnos " +
                    "\n2 - Agregar un nuevo alumno"+
                    "\n3 - Editar un alumno existente. "+
                    "\n4 - Eliminar un alumno existente"+
                    "\n5 - Ver lista de maestros"+
                    "\n0 - Salir del sistema");
                opcion = int.Parse(Console.ReadLine());
                alumno = new ClsAlumnos();


                switch (opcion)

                {
                    case 1:
                        Console.WriteLine("********LISTA DE ALUMNOS*********");
                        foreach (ClsAlumnos item in listado)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n\n\n");
                        break;
                    case 2:
                        Console.WriteLine("********REGISTRANDO NUEVO ALUMNO*********");
                        ClsAlumnos nuevoid = listado[listado.Count - 1];
                        alumno.Id = (nuevoid.Id + 1);
                        Console.WriteLine("Nombres:");
                        alumno.Nombre = Console.ReadLine();
                        Console.WriteLine("Apellidos");
                        alumno.Apellidos = Console.ReadLine();
                        Console.WriteLine("Edad");
                        alumno.Edad = int.Parse(Console.ReadLine());

                        negocios.NAgregarAlumno(alumno);

                        Console.WriteLine("\n\n\n");
                        break;
                    case 3:
                        Console.WriteLine("********EDITANDO ALUMNO*********");
                        Console.WriteLine("ID:");
                        alumno.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nombres:");
                        alumno.Nombre = Console.ReadLine();
                        Console.WriteLine("Apellido:");
                        alumno.Apellidos=Console.ReadLine();
                        Console.WriteLine("Edad:");
                        alumno.Edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Promedio:");
                        alumno.Promedio = double.Parse(Console.ReadLine());

                        negocios.N_EditarAlumno(alumno);

                        break;
                    case 4:
                        Console.WriteLine("********ELIMINANDO ALUMNO*********");
                        Console.WriteLine("ID:");
                        alumno.Id = int.Parse(Console.ReadLine());
                        negocios.N_eliminarAlumno(alumno);
                        break;
                    case 5:
                        Console.WriteLine("********LISTA DE MAESTROS*********");
                        foreach (ClsMaestros item in listados )
                        {
                            Console.WriteLine(item);
                        }
                         Console.WriteLine("\n\n\n");
                        break;


                    case 0:
                        Console.WriteLine("Adios");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
