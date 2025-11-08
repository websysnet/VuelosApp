namespace VuelosApp.Utils
{
    public static class Tabla
    {
        public static void MostrarTablaAscii(List<VuelosApp.Models.Vuelos> vuelos)
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
    }
}