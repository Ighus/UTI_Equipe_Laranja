using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UTI_GrupoLaranja
{
    public partial class Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            string id = btn.CommandArgument;
            Response.Redirect("Index.aspx?id" + id);
            var teste2 = 0;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            //string id = btn.CommandArgument;

            string[] arg = new string[5];
            arg = btn.CommandArgument.ToString().Split(';');



            Session["id"] = arg[0];
            Session["nome"] = arg[1];
            Session["temperatura"] = arg[2];
            Session["sistolica"] = arg[3];
            Session["diastolica"] = arg[4];

           // Session.Add("id", id);

            Response.Redirect("ListarHistorico.aspx");
           
        }

        
    }
}