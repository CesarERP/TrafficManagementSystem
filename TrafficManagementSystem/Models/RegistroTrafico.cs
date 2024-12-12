namespace TrafficManagementSystem.Models
{
    public class RegistroTrafico
    {
        public int IDTráfico { get; set; }
        public DateTime FechaHora { get; set; }
        public int IDVehiculo { get; set; }
        public Vehiculo Vehiculo { get; set; } // Relación con Vehiculo
        public int IDPeaje { get; set; }
        public Peaje Peaje { get; set; } // Relación con Peaje
        public decimal MontoPagado { get; set; }
    }
}
