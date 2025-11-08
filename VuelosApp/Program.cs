// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
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
    Console.WriteLine("11. Generar vuelos aleatorios (prueba)");
    Console.WriteLine("12- Hablar con el Agente IA Virtual (Próximamente)");
    Console.WriteLine(" 10. Salir");
    Console.Write("Seleccione una opción (1-10): ");
    opcion = int.Parse(Console.ReadLine() ?? "1");

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Mostrando vuelos disponibles...");
            VuelosController vuelosController = new VuelosController();
            List<VuelosApp.Models.Vuelos> vuelos = vuelosController.ObtenerVuelosDisponibles();
            MostrarTablaAscii(vuelos);

            break;
        case 2:
            Console.WriteLine("Buscando vuelo por destino...");
            Console.Write("Ingrese el destino: ");
            string destino = Console.ReadLine() ?? "";
            VuelosController vuelosCtrl = new VuelosController();
            List<VuelosApp.Models.Vuelos> vuelosPorDestino = vuelosCtrl.BuscarVuelosPorDestino(destino);
            if (vuelosPorDestino.Count > 0)
            {
                MostrarTablaAscii(vuelosPorDestino);
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

        case 0:
            Console.WriteLine("Saliendo de la aplicación. ¡Gracias por usar VuelosApp!");
            break;


        case 11:
            Console.WriteLine("Generar vuelos aleatorios");
            Console.Write("Ingrese la cantidad de vuelos a generar: ");
            string input = Console.ReadLine() ?? "0";
            if (int.TryParse(input, out int cantidad) && cantidad > 0)
            {
                VuelosController ctrlGen = new VuelosController();
                List<VuelosApp.Models.Vuelos> vuelosGen = ctrlGen.GenerarVuelosAleatorios(cantidad);
                Console.WriteLine($"Se generaron {vuelosGen.Count} vuelos:\n");
                MostrarTablaAscii(vuelosGen);
            }
            else
            {
                Console.WriteLine("Cantidad inválida. Debe ser un número entero mayor que 0.");
            }
            break;

        case 12:
            Console.WriteLine("Funcionalidad de Agente IA Virtual próximamente.");
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 10.");
            break;

    }
    Console.ReadKey();
} while (opcion != 0);

static void MostrarTablaAscii(List<VuelosApp.Models.Vuelos> vuelos)
{
    if (vuelos == null || vuelos.Count == 0)
    {
        Console.WriteLine("No hay vuelos para mostrar.");
        return;
    }

    // Encabezados
    var headers = new[] { "ID", "Origen", "Destino", "Salida", "Llegada", "Aerolínea", "Precio" };

    // Calcula anchos de columna con valores por defecto
    int idW = Math.Max(4, vuelos.Max(v => v.Id.ToString().Length));
    int origenW = Math.Max(6, vuelos.Max(v => v.Origen?.Length ?? 0));
    int destinoW = Math.Max(7, vuelos.Max(v => v.Destino?.Length ?? 0));
    int salidaW = 19; // formato "g"
    int llegadaW = 19;
    int aeroW = Math.Max(8, vuelos.Max(v => v.Aerolinea?.Length ?? 0));
    int precioW = 10;

    // Formato de fila
    string sep = " │ ";
    string fmt = $" {{0,-{idW}}}{sep}{{1,-{origenW}}}{sep}{{2,-{destinoW}}}{sep}{{3,-{salidaW}}}{sep}{{4,-{llegadaW}}}{sep}{{5,-{aeroW}}}{sep}{{6,{precioW}}}";

    int totalWidth = idW + origenW + destinoW + salidaW + llegadaW + aeroW + precioW + (sep.Length * 6);

    // Cabecera
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(new string('═', totalWidth));
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(fmt, headers[0], headers[1], headers[2], headers[3], headers[4], headers[5], headers[6]);
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(new string('═', totalWidth));

    // Filas
    Console.ForegroundColor = ConsoleColor.White;
    foreach (var v in vuelos)
    {
        Console.WriteLine(fmt,
            v.Id,
            v.Origen,
            v.Destino,
            v.FechaSalida.ToString("g"),
            v.FechaLlegada.ToString("g"),
            v.Aerolinea,
            string.Format("${0:N2}", v.Precio));
    }

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(new string('═', totalWidth));
    Console.ResetColor();
}
