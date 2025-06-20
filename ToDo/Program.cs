// Program.cs
using System;
using ZonaTarea; // Para acceder a la clase Tarea y al namespace Funciones

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
            Tarea nuevaTarea = new Tarea(i, _ddescripcion, 15 + i);
            tareasPendientes.Add(nuevaTarea); // Agrego la tarea al final de la lista
        }

        // Muestro las tareas pendientes
        Console.WriteLine("--- TAREAS PENDIENTES ---");
        foreach (Tarea item in tareasPendientes)
        {
            item.MostrarDetalles();
        }

        // Muestro la cantidad de tareas pendientes
        Console.WriteLine($"\nTotal de tareas Pendientes en la lista: {tareasPendientes.Count}");
        Console.WriteLine($"Total de tareas Realizadas en la lista: {tareasRealizadas.Count}");

        // Muestro una consola para el usuario
        Console.WriteLine("\n==========Consola==========");
        Console.WriteLine("Ingrese el ID de la Tarea completada para moverla:");
        string entradaUsuario = Console.ReadLine();

        if (int.TryParse(entradaUsuario, out int idTareaMover))
        {
            Console.WriteLine($"Intentando mover la tarea con ID: {idTareaMover}");
            // ¡Aquí es donde usamos la nueva función!
            Funciones.MoverTarea(tareasPendientes, tareasRealizadas, idTareaMover);
        }
        else
        {
            Console.WriteLine("El ID ingresado no es válido.");
        }

        // Muestro la cantidad de tareas pendientes y realizadas después del movimiento
        Console.WriteLine($"\nTotal de tareas Pendientes en la lista: {tareasPendientes.Count}");
        Console.WriteLine($"Total de tareas Realizadas en la lista: {tareasRealizadas.Count}");

        Console.WriteLine("\n--- TAREAS PENDIENTES ACTUALIZADAS ---");
        foreach (Tarea item in tareasPendientes)
        {
            item.MostrarDetalles();
        }

        Console.WriteLine("\n--- TAREAS REALIZADAS ACTUALIZADAS ---");
        foreach (Tarea item in tareasRealizadas)
        {
            item.MostrarDetalles();
        }
    }
}