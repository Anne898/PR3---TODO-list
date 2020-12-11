using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace PR3___TODO_list
{

    [TestFixture]
    class TodoListUnitTests
    {

        [Test]
        [TestCase(TestName = "Consultar Tareas")]
        public void ConsultarTodasTareas()
        {

            TodoList tareasActual = new TodoList();
            tareasActual.AgregarTarea("Tarea 3");
            tareasActual.ConsultarTareas();


            TodoList tareasEsperadas = new TodoList();
            tareasEsperadas.AgregarTarea("Tarea 3");
            tareasEsperadas.ConsultarTareas();

            //Tarea 3
            Assert.AreEqual(tareasEsperadas.ConsultarTareas(), tareasActual.ConsultarTareas());

        }

        [Test]
        [TestCase(TestName = "Marcar como terminada")]
        public void MarcarTerminada()
        {
            TodoList tareasActual1 = new TodoList();

            tareasActual1.AgregarTarea("Tarea 1");
            tareasActual1.MarcarTerminada();
            tareasActual1.MarcarTerminada(); //La tarea ya esta marcada como terminada (no hace nada)

            TodoList tareasEsperadas1 = new TodoList();
            tareasEsperadas1.AgregarTarea("Tarea 1");

            //Tarea 1
            Assert.AreEqual(tareasEsperadas1.ConsultarTareas(), tareasActual1.ConsultarTerminados());


            TodoList tareasActual2 = new TodoList();
            tareasActual2.AgregarTarea("Tarea 2");
            tareasActual2.MarcarTerminada();


            TodoList tareasEsperadas2 = new TodoList();
            tareasEsperadas2.AgregarTarea("Tarea 2");

            //Tarea 2
            Assert.AreEqual(tareasEsperadas2.ConsultarTareas(), tareasActual2.ConsultarTerminados());

        }

        [Test]
        [TestCase(TestName = "Consultar pendiente")]
        public void ConsulatarPendiente()
        {
            TodoList tareasActual = new TodoList();

            tareasActual.AgregarTarea("Tarea 1"); //Tarea terminada
            tareasActual.MarcarTerminada();

            tareasActual.AgregarTarea("Tarea 4");

            tareasActual.AgregarTarea("Tarea 5"); //Tarea terminada
            tareasActual.MarcarTerminada();

            tareasActual.AgregarTarea("Tarea 6"); //Tarea terminada
            tareasActual.MarcarTerminada();


            TodoList tareasEsperadas = new TodoList();
            tareasEsperadas.AgregarTarea("Tarea 4");


            //Tarea 4
            Assert.AreEqual(tareasEsperadas.ConsultarTareas(), tareasActual.ConsultarPendientes());

        }

        [Test]
        [TestCase(TestName = "Eliminar Tarea Pendiente")]
        public void EliminarPendiente()
        {
            TodoList tareasActual1 = new TodoList();

            tareasActual1.AgregarTarea("Tarea 1"); //Elimina tarea de la lista
            tareasActual1.BorrarPendiente();

            tareasActual1.AgregarTarea("Tarea 2");

            tareasActual1.AgregarTarea("Tarea 3"); //Elimina tarea de la lista
            tareasActual1.BorrarPendiente();


            TodoList tareasEsperadas1 = new TodoList();
            tareasEsperadas1.AgregarTarea("Tarea 2");

            Assert.AreEqual(tareasEsperadas1.ConsultarTareas(), tareasActual1.ConsultarTareas());


            TodoList tareasActual2 = new TodoList();

            tareasActual2.AgregarTarea("Tarea 3");
            tareasActual2.BorrarPendiente();

            tareasActual2.AgregarTarea("Tarea 5"); //La tarea esta terminada (no hace nada)
            tareasActual2.MarcarTerminada();
            tareasActual2.BorrarPendiente();

            tareasActual2.AgregarTarea("Tarea 6"); //Elimina tarea de la lista


            TodoList tareasEsperadas2 = new TodoList();
            tareasEsperadas2.AgregarTarea("Tarea 5");
            tareasEsperadas2.AgregarTarea("Tarea 6");

            Assert.AreEqual(tareasEsperadas2.ConsultarTareas(), tareasActual2.ConsultarTareas());
        }

        [Test]
        [TestCase(TestName = "Eliminar Tarea Terminada")]
        public void EliminarTerminada()
        {
            TodoList tareasActual1 = new TodoList();

            tareasActual1.AgregarTarea("Tarea 1");
            tareasActual1.MarcarTerminada();//Elimina tarea de la lista
            tareasActual1.BorrarTerminado();

            tareasActual1.AgregarTarea("Tarea 2");

            tareasActual1.AgregarTarea("Tarea 3"); //Elimina tarea de la lista
            tareasActual1.MarcarTerminada();
            tareasActual1.BorrarTerminado();


            TodoList tareasEsperadas1 = new TodoList();
            tareasEsperadas1.AgregarTarea("Tarea 2");

            Assert.AreEqual(tareasEsperadas1.ConsultarTareas(), tareasActual1.ConsultarTareas());


            TodoList tareasActual2 = new TodoList();

            tareasActual2.AgregarTarea("Tarea 3");
            tareasActual2.MarcarTerminada();
            tareasActual2.BorrarTerminado();

            tareasActual2.AgregarTarea("Tarea 5"); //La tarea esta pendiente (no hace nada)
            tareasActual2.BorrarTerminado();

            tareasActual2.AgregarTarea("Tarea 6"); //Elimina tarea de la lista


            TodoList tareasEsperadas2 = new TodoList();
            tareasEsperadas2.AgregarTarea("Tarea 5");
            tareasEsperadas2.AgregarTarea("Tarea 6");

            Assert.AreEqual(tareasEsperadas2.ConsultarTareas(), tareasActual2.ConsultarTareas());

        }
    }
}
