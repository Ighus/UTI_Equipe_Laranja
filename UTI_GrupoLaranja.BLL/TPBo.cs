using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTI_GrupoLaranja.Entities;
using UTI_GrupoLaranja.DAL;

namespace UTI_GrupoLaranja.BLL
{
    public class TPBo
    {
        private TPDao _tp;
        public List<Temp_press> getListTP()
        {
            _tp = new TPDao();

            return _tp.getRandonTP();
        }
    }
}
