namespace TrafficManagementSystem.Models
{
    public class Vehiculo
    {
        public int IDVehiculo { get; set; }
        public string Placa { get; set; } // Único
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Color { get; set; }
        public string Propietario { get; set; }
    }
}
