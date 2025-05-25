namespace TALLERMECANICA.Models
{
    public class Taller
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }

        internal static void Add(Taller newTaller)
        {
            throw new NotImplementedException();
        }
    }
}
