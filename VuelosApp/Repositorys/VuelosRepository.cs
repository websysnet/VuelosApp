namespace VuelosApp.Repositorys
{
    using VuelosApp.Models;
    public class VuelosRepository
    {
        public VuelosRepository()
        {
        }
        public List<Vuelos> RetornarVuelos()
        {
            List<Vuelos> listaVuelos = new List<Vuelos>();
            listaVuelos.Add(new Vuelos(101, "Buenos Aires", "Madrid", new DateTime(2024, 7, 1, 22, 0, 0), new DateTime(2024, 7, 2, 12, 0, 0), "Iberia", 850.00m));
            listaVuelos.Add(new Vuelos(102, "Ciudad de México", "Los Ángeles", new DateTime(2024, 7, 3, 15, 30, 0), new DateTime(2024, 7, 3, 18, 0, 0), "Aeroméxico", 450.00m));
            listaVuelos.Add(new Vuelos(103, "Lima", "Miami", new DateTime(2024, 7, 5, 10, 0, 0), new DateTime(2024, 7, 5, 16, 0, 0), "American Airlines", 600.00m));
            listaVuelos.Add(new Vuelos(104, "Santiago", "Nueva York", new DateTime(2024, 7, 7, 20, 0, 0), new DateTime(2024, 7, 8, 6, 0, 0), "Delta Airlines", 750.00m));
            return listaVuelos;
        }
    }
}