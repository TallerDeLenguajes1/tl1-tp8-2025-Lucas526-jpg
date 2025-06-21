// Funciones.cs
using System;
using System.Linq; // Necesario para Where

namespace ZonaTarea
{
    public static class Funciones
    {
        // Función para mover tareas
        public static void MoverTarea(List<Tarea> origen, List<Tarea> destino, int idTarea)
        {
            Tarea tareaAMover = origen.FirstOrDefault(t => t.TareaID == idTarea);

            if (tareaAMover != null)
            {
                origen.Remove(tareaAMover);
                destino.Add(tareaAMover);
                Console.WriteLine($"\n--> Tarea con ID {idTarea} movida con exito.");
            }
            else
            {
                Console.WriteLine($"\nNo se encontro la tarea con ID {idTarea} en la lista de origen.");
            }
        }

        //funcion para buscar tareas por descripción
        public static void BuscarTareasPorDescripcion(List<Tarea> listaTareas, string textoBusqueda)
        {
            // Validar que el texto de busqueda no sea nulo o vacio
            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                Console.WriteLine("Ingrese un texto de búsqueda válido.");
                return; // Sale de la funcion si no hay texto para buscar
            }

            // Convertimos el texto de busqueda a minusculas para hacer la busqueda insensible a mayusculas/minusculas
            string busquedaLowerCase = textoBusqueda.ToLower();

            // Usamos LINQ para filtrar las tareas cuyas descripciones contengan el texto de busqueda
            // StringComparison.OrdinalIgnoreCase hace la comparacion insensible a mayusculas/minusculas
            List<Tarea> resultados = listaTareas.Where(t => t.Descripcion.ToLower().Contains(busquedaLowerCase)).ToList();

            Console.WriteLine($"\n--- Resultados de la busqueda para '{textoBusqueda}' ---");

            if (resultados.Any()) // Comprueba si hay elementos en la lista de resultados
            {
                foreach (Tarea tareaEncontrada in resultados)
                {
                    tareaEncontrada.MostrarDetalles();
                }
            }
            else
            {
                Console.WriteLine("No se encontraron tareas con esa descripcion.");
            }
            Console.WriteLine("------------------------------------------");
        }

        public static void consolaUsuario(){
            Console.WriteLine("==========Consola de usuario==========");
            Console.WriteLine();
            Console.WriteLine("Seleccione la opcion correspondiente");
            Console.WriteLine("1. Mostrar todas las Tareas");
            Console.WriteLine("2. Mostrar las Tareas realizadas");
            Console.WriteLine("3. Mover Tareas");
            Console.WriteLine("4. Buscar tareas por descripcion");
            Console.WriteLine("5. Apagar programa");
        }

        public static int opcionElegida()
        {
            int numero;
            string entradaUsuario;
            bool inputValido = false; // Bandera para controlar el bucle

            // Bucle que se ejecuta hasta que se obtenga una entrada válida
            while (!inputValido)
            {
                Console.WriteLine("ingrese un numero:");
                entradaUsuario = Console.ReadLine();

                if (int.TryParse(entradaUsuario, out numero))
                {
                    return numero;      // La entrada es válida, salimos del bucle y devolvemos el número
                }
                else
                {
                    Console.WriteLine("La entrada ingresada no es valida. Intentelo de nuevo.");
                }
            }
            return -1;
        }
    }
}