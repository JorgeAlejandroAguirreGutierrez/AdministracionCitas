<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdmEspecialidad.aspx.cs" Inherits="ProyectoBasesDatos2.vistas.AdmEspecialidad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <span>Ingrese una nueva especialidad</span>
        <br />
        <span>Ingrese el id de la especialidad</span>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <span>Ingrese el nombre de la especialidad</span>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
