using System;
namespace EjercicioClase
{
    public class SuperHeroe
    {
        public string nombre { get; set; }
        public string identidadSecreta { get; set; }
        public string ciudad { get; set; }
        public bool puedeVolar { get; set; }
        public SuperPoder SuperPoder { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Identidad Secreta: {identidadSecreta}");
            Console.WriteLine($"Ciudad: {ciudad}");
            Console.WriteLine($"Puede volar: {puedeVolar}");
            Console.WriteLine($"Super poder: {SuperPoder.nombre}");
            Console.WriteLine($"Descripcion: {SuperPoder.descripcion}");
            Console.WriteLine($"Nivel: {SuperPoder.nivel}");
        }
    }

}

