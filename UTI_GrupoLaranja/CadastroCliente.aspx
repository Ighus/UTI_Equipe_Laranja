<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCliente.aspx.cs" Inherits="UTI_GrupoLaranja.CadastroCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div align="center">
        <asp:TextBox ID="txtNome" placeHolder="Nome" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="txtEnde" placeHolder="Endereço" runat="server"></asp:TextBox><br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Masculino</asp:ListItem>
            <asp:ListItem>Feminino</asp:ListItem>
        </asp:RadioButtonList>
        <asp:TextBox ID="txtNasc" placeHolder="Data de Nascimento" runat="server" TextMode="Date"></asp:TextBox><br />
        <asp:TextBox ID="txtTemp" placeHolder="Temperatura" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtPres" placeHolder="Pressão" runat="server" Style="margin-left: 96px"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="Cadastrar" OnClick="Button1_Click" />
    </div>
</asp:Content>
