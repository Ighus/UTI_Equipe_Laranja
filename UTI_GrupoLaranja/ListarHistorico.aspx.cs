using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UTI_GrupoLaranja.Entities;
using UTI_GrupoLaranja;
 

namespace UTI_GrupoLaranja
{
    public partial class ListarHistorico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int _id = Convert.ToInt32(Session["id"].ToString());
            string name = Session["nome"].ToString();
            double temp = Convert.ToDouble(Session["temperatura"]);
            int sist = Convert.ToInt32(Session["sistolica"]);
            int diast = Convert.ToInt32(Session["diastolica"]);

            nome.Attributes.Add("placeholder", name);

            //metodo

            
        }
    }
}