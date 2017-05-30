using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTI_GrupoLaranja.Entities
{
    class Historico
    {
        public Int32 id { get; set; }
        public double temperatura { get; set; }
        public int sistolica { get; set; }
        public int diastolica { get; set; }
        public int idPaciente { get; set; }
        public DateTime dataRedistro { get; set; }
    }
}
