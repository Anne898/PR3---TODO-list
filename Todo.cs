using System;

namespace PR3___TODO_list
{
    /// <summary>
    /// Clase Todo, contiene los atributos de la tarea: descripción y estado
    /// </summary>
    class Todo
    {
        /// <summary>
        /// Descripción de la tarea
        /// </summary>
        public string descripcion;

        /// <summary>
        /// Estado de la tarea: pendiente o terminada (false = pendiente, true = terminada)
        /// </summary>
        public bool estado;

        public override string ToString()
        {
            return descripcion;
        }


    }
}
