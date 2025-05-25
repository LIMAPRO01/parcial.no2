namespace TALLERMECANICA.Models
{
    public class Facturas
    {
        public int Id { get; set; }

        public string nombreCliente { get; set; }
        public string nombreRepuesto { get; set; }

        internal static void Add(Facturas newFactura)
        {
            throw new NotImplementedException();
        }
    }
}
