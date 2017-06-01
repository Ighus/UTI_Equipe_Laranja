using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTI_GrupoLaranja.BLL;
using UTI_GrupoLaranja.Entities;

namespace UTI_GrupoLaranja.Terminal
{
    public class AutomatizadorHistorico
    {
        //Recebe id
        //Fazer o if, se for tiver um número impar de registros insere
        //  private List<Temp_press> _tp;
        private TPBo _tpb;
        public void teste(int id, double temp, int sis, int dia)
        {

            _tpb = new TPBo();

            var aux = _tpb.getListTP();

            HistoricoBo hist = new HistoricoBo();

            int linhasAfetadas = hist.contarRegistro(id);
            /*int resto = linhasAfetadas % 2;
            if (resto == 0 || linhasAfetadas > 1)
            {

            }
            else
            {

            }*/

        }



      /*  public void getTemperatura(int temp)
        {
            if (temp < 0)
            {

                Random randNum = new Random();
                randNum.Next();
                return 
            }
        }*/


    }
}
