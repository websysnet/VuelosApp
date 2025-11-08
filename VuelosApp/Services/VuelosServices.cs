namespace VuelosApp.Services
{
    using VuelosApp.Models;
    using VuelosApp.Repositorys;

    public class VuelosServices
    {
        private VuelosRepository vuelosRepository;

        public VuelosServices()
        {
            vuelosRepository = new VuelosRepository();
        }

        public List<Vuelos> RetornarVuelos()
        {
            return vuelosRepository.RetornarVuelos();
        }
        public List<Vuelos> ObtenerVuelosPorDestino(string destino)
        {
            return vuelosRepository.ObtenerVueloPorDestino(destino);
        }

        // Expone el generador de vuelos aleatorios
        public List<Vuelos> GenerarVuelosAleatorios(int cantidad)
        {
            return vuelosRepository.GenerarVuelosAleatorios(cantidad);
        }
    }
}