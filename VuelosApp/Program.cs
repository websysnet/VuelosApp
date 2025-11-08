// See https://aka.ms/new-console-template for more information
using VuelosApp.Controllers;
Console.WriteLine(" Bienvenido a VuelosApp");

int opcion = 0;
do
{
    Console.Clear();
    Console.WriteLine(" Menú de opciones:");
    Console.WriteLine(" 1. Ver vuelos disponibles");
    Console.WriteLine(" 2. Buscar vuelo por destino");
    Console.WriteLine(" 3. Reservar vuelo");
    Console.WriteLine(" 4. Cancelar reserva");
    Console.WriteLine(" 5. Ver mis reservas");
    Console.WriteLine(" 6. Modificar reserva");
    Console.WriteLine(" 7. Ver aerolíneas asociadas");
    Console.WriteLine(" 8. Contactar soporte");
    Console.WriteLine(" 9. Ver promociones");
    Console.WriteLine("11- Hablar con el Agente IA Virtual (Próximamente)");
    Console.WriteLine(" 10. Salir");
    Console.Write("Seleccione una opción (1-10): ");
    opcion = int.Parse(Console.ReadLine() ?? "0");

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Mostrando vuelos disponibles...");
            VuelosController vuelosController = new VuelosController();
            List<VuelosApp.Models.Vuelos> vuelos = vuelosController.ObtenerVuelosDisponibles();
            foreach (var vuelo in vuelos)
            {
                Console.WriteLine($"ID: {vuelo.Id}, Origen: {vuelo.Origen}, Destino: {vuelo.Destino}, Salida: {vuelo.FechaSalida}, Llegada: {vuelo.FechaLlegada}, Aerolínea: {vuelo.Aerolinea}, Precio: ${vuelo.Precio}");
            }

            break;
        case 2:
            Console.WriteLine("Buscando vuelo por destino...");
            Console.Write("Ingrese el destino: ");
            string destino = Console.ReadLine() ?? "";  
            VuelosController vuelosCtrl = new VuelosController();
            List<VuelosApp.Models.Vuelos> vuelosPorDestino = vuelosCtrl.BuscarVuelosPorDestino(destino);
            if (vuelosPorDestino.Count > 0)
            {
                foreach (var vuelo in vuelosPorDestino)
                {
                    Console.WriteLine($"ID: {vuelo.Id}, Origen: {vuelo.Origen}, Destino: {vuelo.Destino}, Salida: {vuelo.FechaSalida}, Llegada: {vuelo.FechaLlegada}, Aerolínea: {vuelo.Aerolinea}, Precio: ${vuelo.Precio}");
                }
            }
            else
            {
                Console.WriteLine("No se encontraron vuelos para el destino especificado.");
            }
            break;
        case 3:
            Console.WriteLine("Reservando vuelo...");
            break;
        case 4:
            Console.WriteLine("Cancelando reserva...");
            break;
        case 5:
            Console.WriteLine("Mostrando mis reservas...");
            break;
        case 6:
            Console.WriteLine("Modificando reserva...");
            break;
        case 7:
            Console.WriteLine("Mostrando aerolíneas asociadas...");
            break;
        case 8:
            Console.WriteLine("Contactando soporte...");
            break;
        case 9:
            Console.WriteLine("Mostrando promociones...");
            break;
        case 10:
            Console.WriteLine("Saliendo de la aplicación. ¡Gracias por usar VuelosApp!");
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 10.");
            break;
    }
    Console.ReadKey();
} while (opcion != 10);
