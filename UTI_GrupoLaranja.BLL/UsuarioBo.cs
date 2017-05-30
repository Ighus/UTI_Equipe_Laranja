using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTI_GrupoLaranja.DAL;
using UTI_GrupoLaranja.BLL.Exceptions;
using UTI_GrupoLaranja.Entities;

namespace UTI_GrupoLaranja.BLL
{
    public class UsuarioBo
    {
        private ClienteDao _paciente;

        public void inserirNovoUsuario(Paciente pac)
        {

            _paciente = new ClienteDao();

            validaUsuario(pac);

            var linhasAfetadas = _paciente.inserirUsuario(pac);

            if (linhasAfetadas == 0)
            {
                throw new PacienteNaoCadastradoException();
            }

           // return 0;

        }

        public int ultimoCadastrado()
        {
            return _paciente.getLastId();
        }


        public void validaUsuario(Paciente pac)
        {
            if (string.IsNullOrWhiteSpace(pac.nome))
            {
                throw new PacienteInvalidoException();
            }
        }
    }
}
