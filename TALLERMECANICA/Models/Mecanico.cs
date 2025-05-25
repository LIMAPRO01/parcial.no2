namespace TALLERMECANICA.Models
{
    public class Mecanico
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }

        internal static void Add(Mecanico newMecanico)
        {
            throw new NotImplementedException();
        }
    }
}
