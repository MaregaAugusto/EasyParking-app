using System.Collections.Generic;

namespace EasyParking.DTO
{
    public class Dia
    {
        public Enum.Dia DiaDeLaSemana { get; set; }
        public List<RangoH> Horarios { get; set; } = new List<RangoH>();
    }
}
