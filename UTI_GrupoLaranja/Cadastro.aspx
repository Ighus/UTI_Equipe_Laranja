<%@ Page Language="C#" Title="Cadastro de paciente - UTI Laranja" AutoEventWireup="true" MasterPageFile="~/Site.Master"  CodeBehind="Cadastro.aspx.cs" Inherits="UTI_GrupoLaranja.Cadastro" %>
    
<asp:Content ID="Content1" ContentPlaceHolderID="headContent" runat="server">
	<script>
		$(document).ready(function () {
			$('select').material_select();
			$('.datepicker').pickadate({
				selectMonths: true,
				selectYears: 180,
				labelMonthNext: 'Proximo mês',
				labelMonthPrev: 'Mês anterior',
				labelMonthSelect: 'Selecione um mês',
				labelYearSelect: 'Selecione um Ano',
				monthsFull: ['Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho', 'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro'],
				monthsShort: ['Jan', 'Fev', 'Mar', 'Abr', 'Mai', 'Jun', 'Jul', 'Ago', 'Set', 'Out', 'Nov', 'Dez'],
				weekdaysFull: ['Domingo', 'Segunda', 'Terça', 'Quarta', 'Quinta', 'Sexta', 'Sabado'],
				weekdaysShort: ['Dom', 'Seg', 'Ter', 'Qua', 'Qui', 'Sex', 'Sab'],
				weekdaysLetter: ['D', 'S', 'T', 'Q', 'Q', 'S', 'S'],
				today: 'Hoje',
				clear: 'Limpar',
				close: 'Fechar'
			});
		});
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="bodyContent" runat="server">
	<form id="form1" runat="server" method="post" class="col s12">
        <div class="section no-pad-bot" id="index-banner">
            <div class="container">
                <br>
                <br>
                <h1 class="header center orange-text">Novo Paciente</h1>
                <div class="row">
                    <!--  <form class="col s12"> -->
                    <div class="row">
                        <div class="input-field col s12">
                            <i class="material-icons prefix">account_circle</i>
                            <input id="nome" type="text" class="validate" data-length="100" name="nome" required="" minlength="10" required="" aria-required="true">
                            <label for="nome">Nome</label>
                        </div>

                        <div class="input-field col s6">

                            <input type="date" id="dataNascimento" name="dataNascimento" class="datepicker " required="" aria-required="true">
                            <label for="idade">Data Nascimento</label>
                        </div>
                        <div class="input-field col s6">
                            <select class="icons" name="sexo" required="">
                                <option value="" disabled selected>Selecione uma opção</option>
                                <option value="F" data-icon="image/female.png" class="circle">Feminino</option>
                                <option value="M" data-icon="image/man.png" class="circle">Masculino</option>
                            </select>
                            <label>Qual o seu sexo?</label>
                        </div>
                        <h2 class="header center orange-text">Endereço</h2>
                        <div class="input-field col s6">
                            <i class="material-icons prefix">room</i>
                            <input name="cep" type="text" id="cep" value="" size="100" maxlength="100" data-length="100" required="" minlength="7" required="" aria-required="true">
                            <label for="cep">Cep</label>
                        </div>
                        <div class="input-field col s6">

                            <input name="rua" type="text" id="logradouro" size="60" placeholder="Ex: Quadra" data-length="100" required="" required="" aria-required="true" />
                            <label for="logradouro">Rua</label>
                        </div>
                        <div class="input-field col s6">

                            <input name="bairro" type="text" id="bairro" size="40" placeholder="Ex: setor " data-length="100" required="" required="" aria-required="true" />
                            <label for="bairro">Bairro</label>
                        </div>
                        <div class="input-field col s6">

                            <input name="cidade" type="text" id="localidade" size="40" placeholder="Ex: Gama" data-length="100" required="" required="" aria-required="true" />
                            <label for="localidade">Cidade</label>
                        </div>
                        <div class="input-field col s6">

                            <input name="uf" type="text" id="uf" size="2" data-length="2" required="" minlength="2" required="" aria-required="true" placeholder="Ex: DF" />
                            <label for="uf">Cidade</label>

                        </div>
                        <div class="input-field col s6">

                            <input name="casa" type="text" id="casa" size="5" placeholder="Ex: 60" data-length="100" required="" required="" aria-required="true" />
                            <label for="uf">Casa</label>

                        </div>
                        <h2 class="header center orange-text">Dados de Referencia</h2>

                        <div class="input-field col s3">

                            <input name="sistolica" type="number" id="sistolica" size="10" min="0" max="100" required="" aria-required="true" placeholder="Ex: 19" />
                            <label for="sistolica">Presão Ex: 19/10</label>

                        </div>
                        <div class="input-field col s3">


                            <input name="diastolica" type="number" id="diastolica" size="10" min="0" max="100" required="" aria-required="true" placeholder="Ex: 10" />

                        </div>
                        <div class="input-field col s6">

                            <input name="temperatura" type="number" id="temperatura" size="5" size="10" min="0" max="100" required="" aria-required="true" placeholder="Ex: 60" />
                            <label for="temperatura">Temperatura</label>

                        </div>
                    </div>
                    <button class="btn waves-effect waves-light" type="submit" name="action" runat="server" onserverclick="Unnamed_ServerClick">
                        Cadastrar
                                <i class="material-icons right">send</i>
                    </button>
                    <!--  </form> -->
                </div>
            </div>
        </div>


    </form>

</asp:Content>
    
   
        
       <asp:Content ID="Content3" ContentPlaceHolderID="footerContent" runat="server">
		   <script src="js/end-by-cep.js"></script>
</asp:Content>
