using System;

namespace ProyectoTareasGithub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestor de Tareas Pendientes (POO)");
            Console.WriteLine("----------------------------------");

            GestorDeTareas gestor = new GestorDeTareas(5);

            while (true)
            {
                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Añadir tarea");
                Console.WriteLine("2. Mostrar tareas");
                Console.WriteLine("3. Eliminar tarea");
                Console.WriteLine("4. Marcar tarea como completada");
                Console.WriteLine("Añado una rama nueva");
                Console.WriteLine("5. Salir");
                Console.Write("Selecciona una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Nombre de la tarea: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Descripción: ");
                        string desc = Console.ReadLine();

                        gestor.AñadirTarea(nombre, desc);
                        break;

                    case "2":
                        gestor.MostrarTareas();
                        break;

                    case "3":
                        Console.Write("Número de tarea a eliminar: ");

                        if (int.TryParse(Console.ReadLine(), out int pos))
                            gestor.EliminarTarea(pos);
                        else
                            Console.WriteLine("Introduce un número válido.");
                        break;

                    case "4":
                        Console.Write("Número de tarea a completar: ");

                        if (int.TryParse(Console.ReadLine(), out int posC))
                            gestor.MarcarCompletada(posC);
                        else
                            Console.WriteLine("Introduce un número válido.");
                        break;

                    case "5":
                        Console.WriteLine("Saliendo del programa...");
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}