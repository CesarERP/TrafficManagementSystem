namespace TrafficManagementSystem.Models
{
    public class Conductor
    {
        public int IDConductor { get; set; } // Clave primaria
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Licencia { get; set; } // Propiedad única
        public string Dirección { get; set; }
        public string Teléfono { get; set; }
    }

}
