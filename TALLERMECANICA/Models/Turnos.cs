namespace TALLERMECANICA.Models
{
    public class Turnos
    {
        public int Id { get; set; }
        public string turno { get; set; }
        public string dia { get; set; }

        internal static void Add(Turnos newTurno)
        {
            throw new NotImplementedException();
        }
    }
}
