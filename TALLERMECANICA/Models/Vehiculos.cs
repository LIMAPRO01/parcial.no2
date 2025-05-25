namespace TALLERMECANICA.Models
{
    public class Vehiculos
    {
        public int id { get; set; }
        public string marca { get; set; }

        public string modelo { get; set; }

        internal static void Add(Vehiculos newVehiculo)
        {
            throw new NotImplementedException();
        }
    }
}
