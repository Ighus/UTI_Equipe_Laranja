<%@ Page Language="C#" Title="Lista de pacientes - UTI Laranja" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Lista.aspx.cs" Inherits="UTI_GrupoLaranja.Lista" %>


<asp:Content ID="Content1" ContentPlaceHolderID="headContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContent" runat="server">

    <form id="form1" runat="server">
        <div class="section no-pad-bot" id="index-banner">
            <div class="container">
                <br>
                <br>
                <h1 class="header center orange-text">Pacientes</h1>
                <table class="responsive-table striped">
                    <thead>
                        <tr>
                            <th>Nome</th>
                            <th>Pressão</th>
                            <th>Temperatura</th>
                            <th>Ações</th>
                        </tr>
                    </thead>

                    <tbody>

                        <!-- INICIO DO LOOP  -->
                        <!-- esse loop seria uma List de pacientes que vai se popular a nossa tablea, no caso seria só um.  -->
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MinhaConexao %>" SelectCommand="SELECT * FROM [paciente]"></asp:SqlDataSource>
                        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
                            <ItemTemplate>
                                <tr>
                                    <td><%#Eval("nome")%></td>
                                    <td><%#Eval("sistolica")%>/<%#Eval("diastolica") %></td>
                                    <td><%#Eval("temperatura")%>º</td>

                                   <td> <asp:Button ID="Button1" runat="server" Text="Aferir dados" OnClick="Button1_Click" CssClass="waves-effect waves-light btn" CommandArgument='<%#Eval("id") + ";" + Eval("nome") + ";" + Eval("temperatura") + ";" 
                                                + Eval("sistolica") + ";" + Eval("diastolica")%>' /></td>

                                    
                                     <!--<td><button class="waves-effect waves-light btn" type="submit" name="action" runat="server" onserverclick="Unnamed_ServerClick" >
                                        Aferir dados
                                        <i class="material-icons left">import_export</i>
                                    </button></td>-->
                                  
                                <!--    <td><a class="waves-effect waves-light btn"><i class="material-icons left">import_export</i>Aferir dados</a></td>-->
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                        <!-- INICIO DO LOOP  -->
                        
                         
                    </tbody>
                </table>

            </div>
        </div>

    </form>
	<br /><br />
	</asp:Content>

    <asp:Content ID="Content3" ContentPlaceHolderID="footerContent" runat="server">
</asp:Content>

