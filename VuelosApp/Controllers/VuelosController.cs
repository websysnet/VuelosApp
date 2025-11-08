namespace VuelosApp.Controllers
{
    using VuelosApp.Models;
    using VuelosApp.Services;

    public class VuelosController
    {
        private VuelosServices vuelosServices;

        public VuelosController()
        {
            vuelosServices = new VuelosServices();
        }

        public List<Vuelos> ObtenerVuelosDisponibles()
        {
            return vuelosServices.RetornarVuelos();
        }

        public List<Vuelos> BuscarVuelosPorDestino(string destino)
        {
            return vuelosServices.ObtenerVuelosPorDestino(destino);
        }
    }
}