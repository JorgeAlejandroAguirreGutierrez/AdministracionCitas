﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdmRegistrarPagoMulta.aspx.cs" Inherits="ProyectoBasesDatos2.vistas.AdmRegistrarPagoMulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content="" />
    <meta name="author" content="" />

    <title>EPS SERVICO Pago de Multas</title>

    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet" />

    <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
    <link href="css/ie10-viewport-bug-workaround.css" rel="stylesheet" />

    <!-- Custom styles for this template -->
    <link href="css/dashboard.css" rel="stylesheet" />

    <!-- Just for debugging purposes. Don't actually copy these 2 lines! -->
    <!--[if lt IE 9]><script src="../../assets/js/ie8-responsive-file-warning.js"></script><![endif]-->
    <script src="js/ie-emulation-modes-warning.js"></script>

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="navbar navbar-inverse navbar-fixed-top">
                <div class="container-fluid">
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <asp:Label ID="Label1" runat="server" Text="Nombre" CssClass="navbar-brand"></asp:Label>
                        <a class="navbar-brand" href="#">EPS SERVICO</a>
                    </div>
                    <div id="navbar" class="navbar-collapse collapse">
                        <ul class="nav navbar-nav navbar-right">
                            <li><a href="AdmPrincipal.aspx">Usuarios</a></li>
                            <li><a href="#">Citas</a></li>
                            <li><a href="AdmCopagos.aspx">Copagos</a></li>
                            <li><a href="AdmMultas.aspx">Multas</a></li>
                            <li><a href="#">Consultas</a></li>
                            <li><a href="#">Cerrar Sesion</a></li>
                        </ul>
                        <div class="navbar-form navbar-right">
                            <input type="text" class="form-control" placeholder="Search..." />
                        </div>
                    </div>
                </div>
            </nav>

            <div class="container-fluid">
                <div class="row">
                    <div class="col-sm-3 col-md-2 sidebar">
                        <ul class="nav nav-sidebar">
                            <li><a href="AdmMultas.aspx">Ver Multas</a></li>
                            <li class="active"><a href="AdmRegistrarMulta.aspx">Registrar Multa</a></li>
                            <li><a href="#">Multas Pagadas</a></li>
                            <li><a href="#">Pagar Multa</a></li>
                        </ul>
                        <ul class="nav nav-sidebar">
                            <li><a href="#">Nav item</a></li>
                            <li><a href="#">Nav item again</a></li>
                            <li><a href="#">One more nav</a></li>
                            <li><a href="#">Another nav item</a></li>
                            <li><a href="#">More navigation</a></li>
                        </ul>
                        <%--                        <ul class="nav nav-sidebar">
                            <li><a href="#">Nav item again</a></li>
                            <li><a href="#">One more nav</a></li>
                            <li><a href="#">Another nav item</a></li>
                        </ul>--%>
                    </div>
                    <div class="col-sm-9 col-sm-offset-3 col-md-10 col-md-offset-2 main">
                        <h1 class="page-header">REGISTRAR PAGO DE MULTA</h1>
                        <h2 class="sub-header">Diligencie los campos a continuación</h2>
                        <div class="col-xs-12">
                            <h4>Id multa</h4>
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                            <br />
                            <h4>Fecha</h4>
                            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                            <br />
                            <asp:Button ID="Button1" runat="server" Text="Button" CssClass="btn btn-lg btn-success" OnClick="Button1_Click" />
                        </div>

                    </div>
                </div>
            </div>

            <!-- Bootstrap core JavaScript
    ================================================== -->
            <!-- Placed at the end of the document so the pages load faster -->
            <script src="js/jquery.min.js"></script>
            <script src="js/bootstrap.min.js"></script>
            <!-- Just to make our placeholder images work. Don't actually copy the next line! -->
            <script src="js/holder.min.js"></script>
            <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
            <script src="js/ie10-viewport-bug-workaround.js"></script>
        </div>
    </form>
</body>
</html>