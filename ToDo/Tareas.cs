namespace ZonaTarea;

public class Tarea {   

    private int _tareaID;
    private string _descripcion;
    private int _duracion;
    public int TareaID { get => _tareaID; set => _tareaID=value; }   
    public string Descripcion { get => _descripcion; set=>_descripcion=value; }   
    public int Duracion { 
        get{ return _duracion ;} 
        set{
        if (value>=10 && value<=100)
        {
            _duracion =value;
        }
        }
    }
        //CONSTRUCTOR
        // Este es un constructor con parámetros.
        // Su nombre es SIEMPRE igual al de la clase (Tarea).
        // NO tiene tipo de retorno (ni siquiera 'void').
        // Recibe los valores que queremos usar para inicializar las propiedades del nuevo objeto.
        public Tarea(int idDeLaTarea, string textoDeLaDescripcion, int tiempoDeDuracion)
        {
            // Dentro del constructor, asignamos los valores recibidos
            // a las propiedades del objeto que se está creando.
            // Al asignar a 'TareaID', 'Descripcion' y 'Duracion',se ejecutan los 'setters' de esas propiedades.
            TareaID = idDeLaTarea;
            Descripcion = textoDeLaDescripcion;
            Duracion = tiempoDeDuracion;
        }
    
        // Método auxiliar para mostrar los detalles de la tarea
        public void MostrarDetalles()
        {
            Console.WriteLine($"ID: {TareaID}, Descripción: {Descripcion}, Duración: {Duracion} min.");
        }
}