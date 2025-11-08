namespace VuelosApp.Controllers
{
    using VuelosApp.Models;
    using VuelosApp.Repositorys;

    public class VuelosController
    {
        private VuelosRepository vuelosRepository;

        public VuelosController()
        {
            vuelosRepository = new VuelosRepository();
        }

        public List<Vuelos> ObtenerVuelosDisponibles()
        {
            return vuelosRepository.RetornarVuelos();
        }
    }
}