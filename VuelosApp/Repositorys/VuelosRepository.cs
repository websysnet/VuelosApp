namespace VuelosApp.Repositorys
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VuelosApp.Models;
    public class VuelosRepository
    {
        public VuelosRepository()
        {
        }
        public List<Vuelos> RetornarVuelos()
        {
            List<Vuelos> listaVuelos = new List<Vuelos>();
            // Generamos 50 vuelos con algunos destinos repetidos
            listaVuelos.Add(new Vuelos(101, "Buenos Aires", "Madrid", new DateTime(2024, 7, 1, 22, 0, 0), new DateTime(2024, 7, 2, 12, 0, 0), "Iberia", 850.00m));
            listaVuelos.Add(new Vuelos(102, "Ciudad de México", "Los Ángeles", new DateTime(2024, 7, 3, 15, 30, 0), new DateTime(2024, 7, 3, 18, 0, 0), "Aeroméxico", 450.00m));
            listaVuelos.Add(new Vuelos(103, "Lima", "Miami", new DateTime(2024, 7, 5, 10, 0, 0), new DateTime(2024, 7, 5, 16, 0, 0), "American Airlines", 600.00m));
            listaVuelos.Add(new Vuelos(104, "Santiago", "Nueva York", new DateTime(2024, 7, 7, 20, 0, 0), new DateTime(2024, 7, 8, 6, 0, 0), "Delta Airlines", 750.00m));
            listaVuelos.Add(new Vuelos(105, "Buenos Aires", "Madrid", new DateTime(2024, 7, 9, 9, 0, 0), new DateTime(2024, 7, 9, 19, 0, 0), "Iberia", 820.00m));
            listaVuelos.Add(new Vuelos(106, "Lima", "Miami", new DateTime(2024, 7, 10, 6, 0, 0), new DateTime(2024, 7, 10, 12, 0, 0), "LATAM", 590.00m));
            listaVuelos.Add(new Vuelos(107, "Santiago", "Sao Paulo", new DateTime(2024, 7, 11, 13, 0, 0), new DateTime(2024, 7, 11, 15, 30, 0), "LATAM", 200.00m));
            listaVuelos.Add(new Vuelos(108, "Bogotá", "Madrid", new DateTime(2024, 7, 12, 21, 0, 0), new DateTime(2024, 7, 13, 11, 0, 0), "Iberia", 780.00m));
            listaVuelos.Add(new Vuelos(109, "Ciudad de México", "Cancún", new DateTime(2024, 7, 13, 8, 0, 0), new DateTime(2024, 7, 13, 10, 30, 0), "Volaris", 120.00m));
            listaVuelos.Add(new Vuelos(110, "Lima", "Santiago", new DateTime(2024, 7, 14, 7, 0, 0), new DateTime(2024, 7, 14, 9, 0, 0), "LATAM", 150.00m));
            listaVuelos.Add(new Vuelos(111, "Buenos Aires", "Sao Paulo", new DateTime(2024, 7, 15, 12, 0, 0), new DateTime(2024, 7, 15, 14, 0, 0), "Gol", 180.00m));
            listaVuelos.Add(new Vuelos(112, "Madrid", "Nueva York", new DateTime(2024, 7, 16, 11, 0, 0), new DateTime(2024, 7, 16, 15, 0, 0), "Iberia", 920.00m));
            listaVuelos.Add(new Vuelos(113, "Miami", "Los Ángeles", new DateTime(2024, 7, 17, 14, 0, 0), new DateTime(2024, 7, 17, 17, 30, 0), "American Airlines", 320.00m));
            listaVuelos.Add(new Vuelos(114, "Santiago", "Nueva York", new DateTime(2024, 7, 18, 19, 0, 0), new DateTime(2024, 7, 19, 7, 0, 0), "Delta Airlines", 760.00m));
            listaVuelos.Add(new Vuelos(115, "Bogotá", "Miami", new DateTime(2024, 7, 19, 9, 0, 0), new DateTime(2024, 7, 19, 14, 0, 0), "Avianca", 310.00m));
            listaVuelos.Add(new Vuelos(116, "Ciudad de México", "Los Ángeles", new DateTime(2024, 7, 20, 16, 0, 0), new DateTime(2024, 7, 20, 19, 0, 0), "Aeroméxico", 440.00m));
            listaVuelos.Add(new Vuelos(117, "Lima", "Madrid", new DateTime(2024, 7, 21, 23, 0, 0), new DateTime(2024, 7, 22, 11, 0, 0), "Iberia", 810.00m));
            listaVuelos.Add(new Vuelos(118, "Buenos Aires", "Miami", new DateTime(2024, 7, 22, 6, 0, 0), new DateTime(2024, 7, 22, 14, 0, 0), "American Airlines", 680.00m));
            listaVuelos.Add(new Vuelos(119, "Santiago", "Lima", new DateTime(2024, 7, 23, 10, 30, 0), new DateTime(2024, 7, 23, 12, 30, 0), "LATAM", 160.00m));
            listaVuelos.Add(new Vuelos(120, "Madrid", "Buenos Aires", new DateTime(2024, 7, 24, 21, 0, 0), new DateTime(2024, 7, 25, 9, 0, 0), "Iberia", 840.00m));
            listaVuelos.Add(new Vuelos(121, "Miami", "Madrid", new DateTime(2024, 7, 25, 19, 0, 0), new DateTime(2024, 7, 26, 9, 0, 0), "American Airlines", 900.00m));
            listaVuelos.Add(new Vuelos(122, "Los Ángeles", "Ciudad de México", new DateTime(2024, 7, 26, 13, 0, 0), new DateTime(2024, 7, 26, 19, 30, 0), "Aeroméxico", 430.00m));
            listaVuelos.Add(new Vuelos(123, "Bogotá", "Santiago", new DateTime(2024, 7, 27, 7, 0, 0), new DateTime(2024, 7, 27, 12, 0, 0), "Avianca", 350.00m));
            listaVuelos.Add(new Vuelos(124, "Lima", "Ciudad de México", new DateTime(2024, 7, 28, 5, 30, 0), new DateTime(2024, 7, 28, 13, 30, 0), "LATAM", 620.00m));
            listaVuelos.Add(new Vuelos(125, "Sao Paulo", "Buenos Aires", new DateTime(2024, 7, 29, 9, 0, 0), new DateTime(2024, 7, 29, 11, 0, 0), "Gol", 170.00m));
            listaVuelos.Add(new Vuelos(126, "Madrid", "Bogotá", new DateTime(2024, 7, 30, 10, 0, 0), new DateTime(2024, 7, 30, 18, 0, 0), "Iberia", 760.00m));
            listaVuelos.Add(new Vuelos(127, "Nueva York", "Santiago", new DateTime(2024, 7, 31, 22, 0, 0), new DateTime(2024, 8, 1, 10, 0, 0), "Delta Airlines", 780.00m));
            listaVuelos.Add(new Vuelos(128, "Miami", "Lima", new DateTime(2024, 8, 1, 12, 0, 0), new DateTime(2024, 8, 1, 18, 0, 0), "American Airlines", 610.00m));
            listaVuelos.Add(new Vuelos(129, "Los Ángeles", "Miami", new DateTime(2024, 8, 2, 7, 0, 0), new DateTime(2024, 8, 2, 15, 0, 0), "United", 340.00m));
            listaVuelos.Add(new Vuelos(130, "Ciudad de México", "Madrid", new DateTime(2024, 8, 3, 20, 0, 0), new DateTime(2024, 8, 4, 10, 0, 0), "Iberia", 830.00m));
            listaVuelos.Add(new Vuelos(131, "Santiago", "Buenos Aires", new DateTime(2024, 8, 4, 8, 0, 0), new DateTime(2024, 8, 4, 10, 0, 0), "LATAM", 140.00m));
            listaVuelos.Add(new Vuelos(132, "Lima", "Bogotá", new DateTime(2024, 8, 5, 6, 0, 0), new DateTime(2024, 8, 5, 11, 0, 0), "Avianca", 320.00m));
            listaVuelos.Add(new Vuelos(133, "Buenos Aires", "Miami", new DateTime(2024, 8, 6, 16, 0, 0), new DateTime(2024, 8, 7, 1, 0, 0), "American Airlines", 700.00m));
            listaVuelos.Add(new Vuelos(134, "Bogotá", "Ciudad de México", new DateTime(2024, 8, 7, 13, 0, 0), new DateTime(2024, 8, 7, 18, 30, 0), "Aeroméxico", 400.00m));
            listaVuelos.Add(new Vuelos(135, "Madrid", "Los Ángeles", new DateTime(2024, 8, 8, 11, 0, 0), new DateTime(2024, 8, 8, 21, 0, 0), "Iberia", 950.00m));
            listaVuelos.Add(new Vuelos(136, "Miami", "Nueva York", new DateTime(2024, 8, 9, 9, 0, 0), new DateTime(2024, 8, 9, 12, 0, 0), "Delta Airlines", 200.00m));
            listaVuelos.Add(new Vuelos(137, "Ciudad de México", "Bogotá", new DateTime(2024, 8, 10, 7, 30, 0), new DateTime(2024, 8, 10, 13, 0, 0), "VivaAerobus", 380.00m));
            listaVuelos.Add(new Vuelos(138, "Sao Paulo", "Lima", new DateTime(2024, 8, 11, 15, 0, 0), new DateTime(2024, 8, 11, 19, 0, 0), "Gol", 260.00m));
            listaVuelos.Add(new Vuelos(139, "Nueva York", "Madrid", new DateTime(2024, 8, 12, 20, 0, 0), new DateTime(2024, 8, 13, 10, 0, 0), "Iberia", 930.00m));
            listaVuelos.Add(new Vuelos(140, "Los Ángeles", "Ciudad de México", new DateTime(2024, 8, 13, 14, 0, 0), new DateTime(2024, 8, 13, 20, 30, 0), "Aeroméxico", 420.00m));
            listaVuelos.Add(new Vuelos(141, "Miami", "Sao Paulo", new DateTime(2024, 8, 14, 10, 0, 0), new DateTime(2024, 8, 14, 18, 0, 0), "LATAM", 520.00m));
            listaVuelos.Add(new Vuelos(142, "Lima", "Madrid", new DateTime(2024, 8, 15, 22, 0, 0), new DateTime(2024, 8, 16, 10, 0, 0), "Iberia", 800.00m));
            listaVuelos.Add(new Vuelos(143, "Santiago", "Nueva York", new DateTime(2024, 8, 16, 20, 0, 0), new DateTime(2024, 8, 17, 8, 0, 0), "Delta Airlines", 770.00m));
            listaVuelos.Add(new Vuelos(144, "Buenos Aires", "Ciudad de México", new DateTime(2024, 8, 17, 6, 0, 0), new DateTime(2024, 8, 17, 15, 0, 0), "Aeroméxico", 680.00m));
            listaVuelos.Add(new Vuelos(145, "Bogotá", "Madrid", new DateTime(2024, 8, 18, 21, 0, 0), new DateTime(2024, 8, 19, 11, 0, 0), "Iberia", 770.00m));
            listaVuelos.Add(new Vuelos(146, "Miami", "Buenos Aires", new DateTime(2024, 8, 19, 18, 0, 0), new DateTime(2024, 8, 20, 6, 0, 0), "American Airlines", 690.00m));
            listaVuelos.Add(new Vuelos(147, "Lima", "Sao Paulo", new DateTime(2024, 8, 20, 9, 0, 0), new DateTime(2024, 8, 20, 13, 0, 0), "LATAM", 270.00m));
            listaVuelos.Add(new Vuelos(148, "Ciudad de México", "Nueva York", new DateTime(2024, 8, 21, 12, 0, 0), new DateTime(2024, 8, 21, 18, 0, 0), "Aeroméxico", 520.00m));
            listaVuelos.Add(new Vuelos(149, "Madrid", "Lima", new DateTime(2024, 8, 22, 23, 0, 0), new DateTime(2024, 8, 23, 11, 0, 0), "Iberia", 790.00m));
            listaVuelos.Add(new Vuelos(150, "Sao Paulo", "Miami", new DateTime(2024, 8, 23, 16, 0, 0), new DateTime(2024, 8, 23, 22, 0, 0), "Gol", 480.00m));

            return listaVuelos;
        }

        // Genera una lista de vuelos aleatorios. Algunos destinos pueden repetirse (según probabilidades).
        public List<Vuelos> GenerarVuelosAleatorios(int cantidad)
        {
            var rnd = new Random();
            var lista = new List<Vuelos>();

            // Listas base de orígenes, destinos y aerolíneas
            string[] origenes = new[] { "Buenos Aires", "Ciudad de México", "Lima", "Santiago", "Bogotá", "Madrid", "Miami", "Los Ángeles", "Sao Paulo", "Nueva York" };
            string[] destinos = new[] { "Madrid", "Miami", "Los Ángeles", "Nueva York", "Santiago", "Lima", "Bogotá", "Ciudad de México", "Sao Paulo", "Cancún" };
            string[] aerolineas = new[] { "Iberia", "Aeroméxico", "LATAM", "American Airlines", "Delta Airlines", "Avianca", "Gol", "Volaris", "United", "VivaAerobus" };

            // Algunos destinos tendrán mayor probabilidad de repetirse (por ejemplo: Madrid, Miami, Los Ángeles)
            var destinosPesados = new[] { "Madrid", "Miami", "Los Ángeles", "Nueva York", "Santiago" };

            // Empezamos los IDs desde 1000 para diferenciar de la lista de pruebas
            int nextId = 1000;

            for (int i = 0; i < cantidad; i++)
            {
                // Origen aleatorio
                string origen = origenes[rnd.Next(origenes.Length)];

                // Elegir destino: con 60% de probabilidad elegir de destinosPesados (permitir repetición), 40% elegir del conjunto completo
                string destino;
                if (rnd.NextDouble() < 0.6)
                {
                    destino = destinosPesados[rnd.Next(destinosPesados.Length)];
                    // evitar que origen == destino; si ocurre, elegir otro destino distinto
                    if (destino == origen)
                    {
                        destino = destinos.Where(d => d != origen).OrderBy(x => rnd.Next()).First();
                    }
                }
                else
                {
                    destino = destinos[rnd.Next(destinos.Length)];
                    if (destino == origen)
                    {
                        destino = destinos.Where(d => d != origen).OrderBy(x => rnd.Next()).First();
                    }
                }

                // Fecha de salida aleatoria en los próximos 90 días
                DateTime fechaSalida = DateTime.Now.Date.AddDays(rnd.Next(1, 90)).AddHours(rnd.Next(0, 24)).AddMinutes(rnd.Next(0, 60));
                // Duración entre 2 y 14 horas
                DateTime fechaLlegada = fechaSalida.AddHours(rnd.Next(2, 15)).AddMinutes(rnd.Next(0, 60));

                string aerolinea = aerolineas[rnd.Next(aerolineas.Length)];

                // Precio aleatorio entre 100 y 1200, con dos decimales
                decimal precio = Math.Round((decimal)(100 + rnd.NextDouble() * 1100), 2);

                lista.Add(new Vuelos(nextId++, origen, destino, fechaSalida, fechaLlegada, aerolinea, precio));
            }

            return lista;
        }
        public List<Vuelos> ObtenerVueloPorDestino(string destino)
        {
            List<Vuelos> vuelos = RetornarVuelos();
            return vuelos.Where(v => v.Destino.Equals(destino, StringComparison.OrdinalIgnoreCase)).ToList();
        }   
    }
}