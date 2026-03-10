using System;

namespace ProyectoTareasGithub
{
    internal class Tarea
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Completada { get; set; }

        public Tarea(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Completada = false;
        }

        public override string ToString()
        {
            string estado;

            if (Completada)
                estado = "[Completada]";
            else
                estado = "[Pendiente]";

            return $"{estado} {Nombre} - {Descripcion}";
        }
    }
}