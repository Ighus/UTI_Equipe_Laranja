using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UTI_GrupoLaranja.Entities;
using UTI_GrupoLaranja.Terminal;

 

namespace UTI_GrupoLaranja
{
    public partial class ListarHistorico : System.Web.UI.Page
    {
        public string name;
        public double temp;
        public int sist;
        public int diast;
        public int _id;
        protected void Page_Load(object sender, EventArgs e)
        {

            _id = Convert.ToInt32(Session["id"].ToString());
            name = Session["nome"].ToString();
            temp = Convert.ToDouble(Session["temperatura"]);
            sist = Convert.ToInt32(Session["sistolica"]);
            diast = Convert.ToInt32(Session["diastolica"]);
            


            AutomatizadorHistorico auto = new AutomatizadorHistorico();
            //auto.teste(_id);


            //metodo

            
        }
    }
}