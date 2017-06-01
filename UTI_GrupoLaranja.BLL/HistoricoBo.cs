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
    public class HistoricoBo
    {
        private HistoricoDao _historico;

        public int contarRegistro(int id)
        {

            _historico = new HistoricoDao();

            var linhasAfetadas = _historico.countRegistro(id);

             return linhasAfetadas;

        }

        public void inserirNovoHistorico(Historico his)
        {

            _historico = new HistoricoDao();

            _historico.inserirHistorico(his);

          

            // return 0;

        }
    }
}
