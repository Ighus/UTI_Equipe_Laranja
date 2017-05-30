using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTI_GrupoLaranja.Entities;
using UTI_GrupoLaranja.DAL;


namespace UTI_GrupoLaranja.BLL
{
    public class EnderecoBo
    {
        private EnderecoDao _endereco;

        public void inserirEndereco(Paciente pac)
        {

            _endereco = new EnderecoDao();

            var linhasAfetadas = _endereco.inserirEndereco(pac);

        }
    }
}
