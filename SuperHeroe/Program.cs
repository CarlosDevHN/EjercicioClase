using System;

namespace EjercicioClase
{
    class Program
    {
        static void Main(string[] args)
        {

            SuperPoder superFuerza = new SuperPoder
            {
                nombre = "Super Fuerza",
                descripcion = "Capacidad de levantar objetos muy pesados",
                nivel = 5
            };

            SuperPoder visionRayosX = new SuperPoder
            {
                nombre = "Visión de Rayos X",
                descripcion = "Capacidad de ver a través de objetos",
                nivel = 3
            };

            SuperPoder vuelo = new SuperPoder
            {
                nombre = "Vuelo",
                descripcion = "Capacidad de volar a gran velocidad",
                nivel = 4
            };

            SuperHeroe superman = new SuperHeroe
            {
                nombre = "Superman",
                identidadSecreta = "Clark Kent",
                ciudad = "Metrópolis",
                puedeVolar = true,
                SuperPoder = superFuerza
            };

            SuperHeroe batman = new SuperHeroe
            {
                nombre = "Batman",
                identidadSecreta = "Bruce Wayne",
                ciudad = "Gotham",
                puedeVolar = false,
                SuperPoder = visionRayosX
            };

            SuperHeroe flash = new SuperHeroe
            {
                nombre = "Flash",
                identidadSecreta = "Barry Allen",
                ciudad = "Central City",
                puedeVolar = false,
                SuperPoder = vuelo
            };

            Console.WriteLine("Listado de Super Heroe:");
            superman.MostrarInformacion();
            Console.WriteLine();
            batman.MostrarInformacion();
            Console.WriteLine();
            flash.MostrarInformacion();
            Console.ReadLine();
        }
    }
}
