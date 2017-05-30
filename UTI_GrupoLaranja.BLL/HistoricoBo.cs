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
    class HistoricoBo
    {
        private HistoricoDao _historico;

        public void contarRegistro(int id)
        {

            _historico = new HistoricoDao();

            

            var linhasAfetadas = _historico.countRegistro(id);


            int resto = linhasAfetadas % 2;
            if (resto == 0 && linhasAfetadas > 1)
            {
                
            }
            else
            {
                
            } 

            // return 0;

        }
    }
}
