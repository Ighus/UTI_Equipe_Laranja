using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UTI_GrupoLaranja.Entities
{
    public class Paciente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime idade { get; set; }
        public char sexo { get; set; }
        public double temperatura { get; set; }
        public int sistolica { get; set; }
        public int diastolica { get; set; }

        public Endereco endereco = new Endereco();   
        
        
    }
}
