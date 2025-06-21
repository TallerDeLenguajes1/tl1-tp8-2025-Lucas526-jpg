// Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using ZonaTarea;

class Program
{
    static void Main()
    {
        // Creo listas de tareas vacias
        List<Tarea> tareasPendientes = new List<Tarea>();
        List<Tarea> tareasRealizadas = new List<Tarea>();

        // Creo tareas según iteraciones y las añado al final a cada una a la lista
        for (int i = 0; i < 8; i++)
        {
            string _ddescripcion = "Completado";
            if (i % 2 == 0)
            {
                _ddescripcion = "Finalizado";
            }
            Tarea nuevaTarea = new Tarea(i, _ddescripcion + " Tarea " + i, 15 + i); // Añadimos algo más a la descripción
            tareasPendientes.Add(nuevaTarea);
        }
        bool bandera=true;
        int opcionElegida;
        do
        {
            Funciones.consolaUsuario();
            opcionElegida = Funciones.opcionElegida();
            switch (opcionElegida)
            {
                case 1:
                if (tareasPendientes.Count>0)
                {
                    // Muestro las tareas pendientes
                    Console.WriteLine("--- TAREAS PENDIENTES ---");
                    foreach (Tarea item in tareasPendientes)
                    {
                        item.MostrarDetalles();
                    }
                }
                if (tareasRealizadas.Count>0)
                {
                    // Muestro las tareas pendientes
                    Console.WriteLine("--- TAREAS REALIZADAS ---");
                    foreach (Tarea item in tareasRealizadas)
                    {
                        item.MostrarDetalles();
                    }
                }
                break;

                case 2:
                    // Muestro las tareas pendientes
                    Console.WriteLine("--- TAREAS REALIZADAS ---");
                    foreach (Tarea item in tareasRealizadas)
                    {
                        item.MostrarDetalles();
                    }
                break;

                case 3:
                    Console.WriteLine("\n==========Consola==========");
                    Console.WriteLine("Ingrese el ID de la Tarea completada para moverla:");
                    string entradaUsuario = Console.ReadLine();

                    if (int.TryParse(entradaUsuario, out int idTareaMover))
                    {
                        Console.WriteLine($"Intentando mover la tarea con ID: {idTareaMover}");
                        Funciones.MoverTarea(tareasPendientes, tareasRealizadas, idTareaMover);
                    }
                    else
                    {
                        Console.WriteLine("El ID ingresado no es válido.");
                    }
                break;

                case 4:
                    //buscar por descripcion
                    Console.WriteLine("\n==========Buscador de Tareas==========");
                    Console.WriteLine("Ingrese un texto para buscar en las descripciones de tareas pendientes:");
                    string textoBusqueda = Console.ReadLine();

                    // Llamamos a la nueva función para buscar y mostrar las tareas
                    Funciones.BuscarTareasPorDescripcion(tareasPendientes, textoBusqueda);
                break;

                case 5:
                    bandera=false;
                break;
                
                default:
                    Console.WriteLine("Ingresa un numero valido");
                break;
            }
        } while (bandera);
    }
}