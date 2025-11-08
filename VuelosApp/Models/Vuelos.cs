namespace VuelosApp.Models
{
    public class Vuelos
    {
        public int Id { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaLlegada { get; set; }
        public string Aerolinea { get; set; }
        public decimal Precio { get; set; }

        public Vuelos(int id, string origen, string destino, DateTime fechaSalida, DateTime fechaLlegada, string aerolinea, decimal precio)
        {
            Id = id;
            Origen = origen;
            Destino = destino;
            FechaSalida = fechaSalida;
            FechaLlegada = fechaLlegada;
            Aerolinea = aerolinea;
            Precio = precio;
        }
    }   
}