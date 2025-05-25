namespace TALLERMECANICA.Models
{
    public class Servicios
    {
        public int id { get; set; }
        public string categoria { get; set; }
        public double precio { get; set; }
        internal static void Add(Servicios newServicio)
        {
            throw new NotImplementedException();
        }
    }
}
