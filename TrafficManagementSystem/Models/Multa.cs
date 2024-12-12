namespace TrafficManagementSystem.Models
{
    public class Multa
    {
        public int IDMulta { get; set; }
        public int IDVehiculo { get; set; }
        public Vehiculo Vehiculo { get; set; } // Relación con Vehiculo
        public int IDConductor { get; set; }
        public Conductor Conductor { get; set; } // Relación con Conductor
        public DateTime FechaHora { get; set; }
        public string Descripción { get; set; }
        public decimal MontoMulta { get; set; }
        public bool Pagado { get; set; }
    }
}
