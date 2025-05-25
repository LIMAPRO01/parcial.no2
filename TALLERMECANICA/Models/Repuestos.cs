namespace TALLERMECANICA.Models
{
    public class Repuestos
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        internal static void Add(Repuestos newRepuesto)
        {
            throw new NotImplementedException();
        }
    }
}
