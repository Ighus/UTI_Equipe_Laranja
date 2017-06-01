<%@ Page Language="C#" Title="Historico de presão/temperatura - UTI Laranja" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ListarHistorico.aspx.cs" Inherits="UTI_GrupoLaranja.ListarHistorico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="headContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContent" runat="server">

    <form id="form1" runat="server">

        <div class="section no-pad-bot" id="index-banner">
            <div class="container">
                <br>
                <br>
                <h1 class="header center orange-text">Historico</h1>

                   <div class="input-field center green-text">
					
					<p>Nome: <%= name %></p>
                     
                </div>
				<div class="divider orange"></div>
                <div class="row">


                    <div class="input-field col s6 green-text">
                        <span class="title">Temperatura:</span>
						<p><%= temp %></p>
                    </div>
                    <div class="input-field col s6 green-text">
                        <span class="title">Presão:</span>
						<p><%= sist+"/"+diast %></p>
                    </div>

                </div>
                <table class="responsive-table striped">
                    <thead>
                        <tr>
                            <th class="auto-style1">Horario</th>
                            <th>Presão</th>
                            <th>Temperatura</th>

                        </tr>
                    </thead>

                    <tbody>
                        <!-- INICIO DO LOOP  -->
                        <!-- esse loop seria uma List de pacientes que vai se popular a nossa tablea, no caso seria só um.  -->
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MinhaConexao %>" SelectCommand="Select * from [historico]  ">

                        </asp:SqlDataSource>
                        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
                            <ItemTemplate>
                                <tr class="warning">
                                    <td><%#Eval("data")%></td>
                                    <td><%#Eval("sistolica")%>/<%#Eval("diastolica")%></td>
                                    <td><%#Eval("temperatura")%>º</td>

                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
						

                        <!-- INICIO DO LOOP  -->
                    </tbody>
                </table>

            </div>
        </div>


    </form>
    <br />
    <br />
	</asp:Content>
 <asp:Content ID="Content3" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

