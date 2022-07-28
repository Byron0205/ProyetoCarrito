<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmIngresoUsuario.aspx.vb" Inherits="InterfazCarritoCompras.frmIngresoUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <style>
        #form1{
            background-color: aqua;
            text-align: center;
        }
        .etiqueta{
            
            margin: 0px 10px 20px 10px;
            font-family:  Arial;
        }
    </style>
    <title></title>
</head>
<body style="width: 276px">
    <form id="form1" runat="server">
        <div>
            <asp:Label CssClass="etiqueta" ID="lblCedula" runat="server" Text="Cedula"></asp:Label>
            <asp:TextBox ID="TxtCedula" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label CssClass="etiqueta" ID="LblNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label CssClass="etiqueta" ID="LblContrasena" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="TxtContraseña" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label CssClass="etiqueta" ID="LblTelefono" runat="server" Text="Telefono"></asp:Label>
            <asp:TextBox ID="TxtTelefono" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label CssClass="etiqueta" ID="LblCorreo" runat="server" Text="Correo"></asp:Label>
            <asp:TextBox ID="TxtCorreo" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="BtnAceptar" runat="server" Text="Aceptar" />
    </form>
</body>
</html>
