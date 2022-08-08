<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PáginaMaestra.Master" CodeBehind="Formulario web2.aspx.vb" Inherits="InterfazCarritoCompras.Formulario_web2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="Titulo" class="DivTitulo1"> 
         <asp:Label ID="lblTituloFormulario" runat="server" Text="Registro clientes " CssClass="Titulo2"></asp:Label>
     </div>
      <div id="Formulario" class="Formulario">

    <div id="Cedula" class="Padre">
        <div id="EtiquetaCedula" class="Hijo">
            <asp:Label ID="lblCedula" runat="server" Text="Cedula:"></asp:Label></div>
        <div id="DatoCedula" class="Hijo">
            <asp:TextBox ID="txtCedula" runat="server" Width="245px"></asp:TextBox></div>
     </div>

     <div id="Nombre" class="Padre">
         <div id="EtiquetaNombre"class="Hijo">
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label></div>
        <div id="DatoNombre" class="Hijo">
            <asp:TextBox ID="txtNombre" runat="server" Width="245px"></asp:TextBox></div>
     </div>
     <div id="Contrasena" class="Padre">
        <div id="EtiquetaContrasena" class="Hijo">
            <asp:Label ID="lblContrasena" runat="server" Text="Contraseña:"></asp:Label></div>
        <div id="DatoContrasena" class="Hijo">
            <asp:TextBox ID="txtContrasena" runat="server" Width="245px"></asp:TextBox></div>
     </div>

  <div id="Telefono "class="Padre">
        <div id="EtiquetaTelefono" class="Hijo">
            <asp:Label ID="lblTelefono" runat="server" Text="Teléfono:"></asp:Label></div>
        <div id="DatoTelefono" class="Hijo">
            <asp:TextBox ID="txtTelefono" runat="server" Width="245px"></asp:TextBox> </div>
    </div>
  <div id="Correo" class="Padre">
        <div id="EtiquetaCorreo" class="Hijo">
            <asp:Label ID="lblCorreo" runat="server" Text="Correo:"></asp:Label></div>
        <div id="DatoCorreo" class="Hijo">
            <asp:TextBox ID="txtCorreo" runat="server" Width="245px"></asp:TextBox></div>
    </div> 
</div>

 <div>
      <div id="Agregar" class="BotonAgregar">
     <asp:Button ID="btnAgregar" runat="server" Text="Agregar" style="height: 28px" /></div>

     <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
 </div> 
</asp:Content>
