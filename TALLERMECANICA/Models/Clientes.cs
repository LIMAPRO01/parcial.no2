namespace TALLERMECANICA.Models
{
    public class Clientes
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        internal static void Add(Clientes newCliente)
        {
            throw new NotImplementedException();
        }
    }
}
