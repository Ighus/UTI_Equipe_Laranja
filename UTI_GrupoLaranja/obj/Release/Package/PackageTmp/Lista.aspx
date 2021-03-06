﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="UTI_GrupoLaranja.Lista" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1.0" />
    <title>Projeto UTI - GRUPO LARANJA</title>

    <!-- CSS  -->
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link href="css/materialize.css" type="text/css" rel="stylesheet" media="screen,projection" />
    <link href="css/style.css" type="text/css" rel="stylesheet" media="screen,projection" />
</head>
<body>

    <nav>
        <div class="nav-wrapper orange">
            <a href="#!" class="brand-logo">Projeto UTI</a>
            <ul class="right hide-on-med-and-down">
                <li><a class="dropdown-button" href="#!" data-activates="dropdown1">Menu Principal<i class="material-icons right">arrow_drop_down</i></a>
                    <ul id="dropdown1" class="dropdown-content ">
                        <li><a href="badges.html"><i class="material-icons">group</i>Pacientes</a></li>
                        <li><a href="badges.html"><i class="material-icons">face</i>Cadastro</a></li>
                    </ul>
                </li>

            </ul>
        </div>
    </nav>


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
    <div class="section">
    </div>

    <!-- INICIO FOOTER  -->
    <footer class="page-footer orange">
        <div class="container">
            <div class="row">
                <div class="col l6 s12">
                    <h5 class="white-text">Projeto</h5>
                    <p class="grey-text text-lighten-4">Micro explicação</p>


                </div>
                <div class="col l3 s12">
                    <h5 class="white-text">Membros</h5>
                    <ul>
                        <li><a class="white-text" href="#!">Pedro (Gerente)</a></li>
                        <li><a class="white-text" href="#!">Igor</a></li>
                        <li><a class="white-text" href="#!">Danilo</a></li>
                        <li><a class="white-text" href="#!"></a></li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="footer-copyright">
            <div class="container">
                Front-end: Materialize  back-end: C#
            </div>
        </div>
    </footer>


    <!--  Scripts-->
    <script src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script src="js/materialize.js"></script>
    <script src="js/init.js"></script>

</body>
</html>
