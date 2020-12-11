using System;
using System.Collections.Generic;

namespace PR3___TODO_list
{
    /// <summary>
    /// Clase TodoList, se encarga de toda la funcionalidad de la lista de tareas:
    /// agregar tarea, eliminar tarea (pendiente o terminada), marcar tarea como terminada
    /// consultar tareas (pendientes, terminadas o todas las tareas)
    /// </summary>
    class TodoList
    {
        /// <summary>
        /// Lista de tareas
        /// </summary>
        /// <typeparam name="Todo"></typeparam>
        public List<Todo> listaTareas = new List<Todo>();

        /// <summary>
        /// Método para agregar una tarea (la agrega como pendiente)
        /// </summary>
        /// <param name="descripcionTarea"></param>
        public void AgregarTarea(string descripcionTarea)
        {
            Todo tarea = new Todo();
            tarea.descripcion = descripcionTarea;
            tarea.estado = false; //false = pendiente, true = terminada
            listaTareas.Add(tarea);

        }
        /// <summary>
        /// Marcar tarea (TODO) como terminada
        /// </summary>
        public void MarcarTerminada()
        {
            for (int i = listaTareas.Count - 1; i >= 0; i--)
            {
                if (listaTareas[i].estado == false)
                {
                    listaTareas[i].estado = true;
                    break;
                }
            }
        }

        /// <summary>
        /// Consulta todas las tareas pedientes
        /// </summary>
        /// <returns>Descripción de la tarea</returns>
        public string ConsultarPendientes()
        {
            foreach (Todo tarea in listaTareas)
            {
                if (tarea.estado == false)
                {

                    return tarea.descripcion;

                }


            }

            return null;

        }

        /// <summary>
        /// Consulta todas las tareas terminadas
        /// </summary>
        /// <returns>Descripción de la tarea</returns>
        public string ConsultarTerminados() // Consultar quehaceres (TODOs) terminados
        {
            foreach (Todo tarea in listaTareas)
            {
                if (tarea.estado == true)
                {
                    return tarea.descripcion;
                }

            }
            return null;

        }
        /// <summary>
        /// Consulta todas las tareas (terminadas y pendientes)
        /// </summary>
        /// <returns>Descripción de la tarea</returns>
        public string ConsultarTareas() //Consultar todos los quehaceres (TODOs) pendientes y terminados
        {
            foreach (Todo tarea in listaTareas)
            {

                return tarea.descripcion;

            }

            return null;
        }
        /// <summary>
        /// Borra la tarea pendiente
        /// </summary>
        public void BorrarPendiente()
        {

            for (int i = listaTareas.Count - 1; i >= 0; i--)
            {
                if (listaTareas[i].estado == false)
                {
                    listaTareas.Remove(listaTareas[i]);
                    break;
                }
            }
        }

        /// <summary>
        /// Borra la tarea terminada
        /// </summary>
        public void BorrarTerminado()
        {
            //listaTareas.RemoveAll(x => x.estado == true);

            for (int i = listaTareas.Count - 1; i >= 0; i--)
            {
                if (listaTareas[i].estado == true)
                {
                    listaTareas.Remove(listaTareas[i]);
                    break;
                }
            }

        }


    }
}
