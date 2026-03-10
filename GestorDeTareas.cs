using System;

namespace ProyectoTareasGithub
{
    internal class GestorDeTareas
    {
        private Tarea[] tareas;
        private int contadorTareas;
        private int capacidad;

        public GestorDeTareas(int capacidad)
        {
            this.capacidad = capacidad;
            tareas = new Tarea[capacidad];
            contadorTareas = 0;
        }

        public void AñadirTarea(string nombre, string descripcion)
        {
            if (contadorTareas < capacidad)
            {
                tareas[contadorTareas] = new Tarea(nombre, descripcion);
                contadorTareas++;
                Console.WriteLine("Tarea añadida correctamente.");
            }
            else
            {
                Console.WriteLine("Error: se ha alcanzado el límite de tareas.");
            }
        }

        public void MostrarTareas()
        {
            if (contadorTareas == 0)
            {
                Console.WriteLine("No hay tareas registradas.");
                return;
            }

            Console.WriteLine("\nTareas:");

            for (int i = 0; i < contadorTareas; i++)
            {
                Console.WriteLine($"{i + 1}. {tareas[i]}");
            }
        }

        public void EliminarTarea(int posicion)
        {
            int idx = posicion - 1;

            if (idx < 0 || idx >= contadorTareas)
            {
                Console.WriteLine("Posición no válida.");
                return;
            }

            for (int i = idx; i < contadorTareas - 1; i++)
            {
                tareas[i] = tareas[i + 1];
            }

            tareas[contadorTareas - 1] = null;
            contadorTareas--;

            Console.WriteLine("Tarea eliminada.");
        }

        public void MarcarCompletada(int posicion)
        {
            int idx = posicion - 1;

            if (idx < 0 || idx >= contadorTareas)
            {
                Console.WriteLine("Posición no válida.");
                return;
            }

            tareas[idx].Completada = true;
            Console.WriteLine("Tarea marcada como completada.");
        }
    }
}