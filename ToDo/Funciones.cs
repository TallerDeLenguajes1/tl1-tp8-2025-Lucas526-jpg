// Funciones.cs
using System;
using System.Collections.Generic;
using System.Linq; // Necesario para FirstOrDefault
using ZonaTarea; // Necesario para usar la clase Tarea

namespace ZonaTarea;

    public static class Funciones
    {
        public static void MoverTarea(List<Tarea> origen, List<Tarea> destino, int idTarea)
        {
            // Busca la tarea por su ID en la lista de origen
            Tarea tareaAMover = origen.FirstOrDefault(t => t.TareaID == idTarea);

            if (tareaAMover != null)
            {
                // Si la tarea se encuentra, la remueve de la lista de origen
                origen.Remove(tareaAMover);
                // Y la añade a la lista de destino
                destino.Add(tareaAMover);
                Console.WriteLine($"\n--> Tarea con ID {idTarea} movida con éxito.");
            }
            else
            {
                Console.WriteLine($"\nNo se encontró la tarea con ID {idTarea} en la lista de origen.");
            }
        }
    }
