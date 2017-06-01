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
        private List<Temp_press> aux;
        public void teste(int id)
        {

            _tpb = new TPBo();

            aux = _tpb.getListTP();

            HistoricoBo hist = new HistoricoBo();
            Historico hi = new Historico();

            int linhasAfetadas = hist.contarRegistro(id);
            int resto = linhasAfetadas % 2;
            if (resto == 0 || ( linhasAfetadas < 3 && resto!= 0))
            {
                hi.temperatura = getTemperatura(-1);
                hi.sistolica = getSistolica(-1);
                hi.diastolica = getDiastolica(-1);
                hi.idPaciente = id;
            }
            else if(linhasAfetadas > 1)
            {
                hi.temperatura = getTemperatura(1);
                hi.sistolica = getSistolica(1);
                hi.diastolica = getDiastolica(1);
                hi.idPaciente = id;
            }

            hist.inserirNovoHistorico(hi);
        }

        

          public double getTemperatura(int temp)
          {
              Random randNum = new Random();
              if (temp < 0)
              {
                  return aux[randNum.Next(0, 14)].temperatura;                  
              }
              return aux[randNum.Next(15, 62)].temperatura; 
              
          }

          public int getSistolica(int sis)
          {
              Random randNum = new Random();
              if (sis < 0)
              {
                  return aux[randNum.Next(0, 4)].pressao1;
              }
              return aux[randNum.Next(5, 12)].pressao1;

          }

          public int getDiastolica(int dis)
          {
              Random randNum = new Random();
              if (dis < 0)
              {
                  return aux[randNum.Next(0, 4)].pressao2;
              }
              return aux[randNum.Next(5, 12)].pressao2;

          }

    }
}
