using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTI_GrupoLaranja.Entities
{
    public class Endereco
    {
        public string cep { get; set; }
        public string rua { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string casa { get; set; }
        public int idPaciente { get; set; }


    }
}
