using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UTI_GrupoLaranja.Entities;
using UTI_GrupoLaranja.BLL;

namespace UTI_GrupoLaranja
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            Paciente pac = new Paciente();
            UsuarioBo bo = new UsuarioBo();
            EnderecoBo ende = new EnderecoBo();
         

            var _data = Request.Form["dataNascimento"];
            pac.nome = Request.Form["nome"];
            pac.sexo = Convert.ToChar(Request.Form["sexo"]);
            pac.idade = Convert.ToDateTime(_data);
            pac.sistolica = Convert.ToInt16(Request.Form["sistolica"]);
            pac.diastolica = Convert.ToInt16(Request.Form["diastolica"]);
            pac.temperatura = Convert.ToDouble(Request.Form["temperatura"]);

            bo.inserirNovoUsuario(pac);


            //Ler endereço dos campos
            pac.endereco.bairro = Request.Form["bairro"];
            pac.endereco.casa = Request.Form["casa"];
            pac.endereco.cep = Request.Form["cep"];
            pac.endereco.cidade = Request.Form["cidade"];
            pac.endereco.rua = Request.Form["rua"];
            pac.endereco.uf = Request.Form["uf"];
            pac.endereco.idPaciente = bo.ultimoCadastrado();
            //Inserir endereço no banco de dados
            ende.inserirEndereco(pac);

            //Response.Redirect();
        }
    }
}