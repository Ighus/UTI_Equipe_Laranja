using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTI_GrupoLaranja.Entities
{
    class Paciente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public DateTime idade { get; set; }
        public char sexo { get; set; }
        public double temperatura { get; set; }
        public double pressao { get; set; }

    }
}
