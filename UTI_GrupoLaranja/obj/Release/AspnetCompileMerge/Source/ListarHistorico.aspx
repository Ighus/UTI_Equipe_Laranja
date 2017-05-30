<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarHistorico.aspx.cs" Inherits="UTI_GrupoLaranja.ListarHistorico" %>

<!DOCTYPE html>

<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1.0" />
    <title>Projeto UTI - GRUPO LARANJA</title>

    <!-- CSS  -->
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link href="css/materialize.css" type="text/css" rel="stylesheet" media="screen,projection" />
    <link href="css/style.css" type="text/css" rel="stylesheet" media="screen,projection" />
    <style type="text/css">
        .auto-style1 {
            width: 903px;
        }
    </style>
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
                <h1 class="header center orange-text">Historico</h1>
                <div class="input-field center green-text">
                    <i class="material-icons prefix">account_circle</i>
                    <input id="nome" type="text" name="nome" style="font-size: 40px" runat="server" placeholder="" class="validate" disabled="true">
                    <label for="icon_prefix">Nome: </label>
                </div>
                <div class="row">


                    <div class="input-field col s6 green-text">
                        <input id="Temperatura" type="text" name="temperatura" style="font-size: 20px" runat="server" class="validate" disabled="true">
                        <label for="Temperatura">Temperadura:</label>
                    </div>
                    <div class="input-field col s6 green-text">
                        <input id="presao" type="text" class="validate" name="pressao" style="font-size: 20px" runat="server" disabled="true">
                        <label for="presao">Presão: </label>
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
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MinhaConexao %>" SelectCommand="SELECT * FROM [historico]"></asp:SqlDataSource>
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
