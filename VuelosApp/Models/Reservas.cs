namespace VuelosApp.Models
{
    public class Reservas
    {
        public int Id { get; set; }
        public int VueloId { get; set; }
        public string NombrePasajero { get; set; }
        public string ApellidoPasajero { get; set; }
        public DateTime FechaReserva { get; set; }

        public Reservas(int id, int vueloId, string nombrePasajero, string apellidoPasajero, DateTime fechaReserva)
        {
            Id = id;
            VueloId = vueloId;
            NombrePasajero = nombrePasajero;
            ApellidoPasajero = apellidoPasajero;
            FechaReserva = fechaReserva;
        }

      
    }
}