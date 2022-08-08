<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PáginaMaestra.Master" CodeBehind="Formulario web3.aspx.vb" Inherits="InterfazCarritoCompras.Formulario_web3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="Formulario" class="Formulario2">
    
    <div id="Creado" class="Padre">
        <div id="Creador" class="Hijo1"> 
            <asp:Label ID="lblCreador" runat="server" Text="Creado por:"></asp:Label></div>
     </div>
        <div id="Nombre1" class="Padre">
            <div id="EtiquetaNombre1" class="Hijo1"> 
                <asp:Label ID="lblNombre1" runat="server" Text="Federick Mora Cerdas"></asp:Label></div>
            </div>

        <div id="Nombre2" class="Padre">
            <div id="EtiquetaNombre2" class="Hijo1"> 
                <asp:Label ID="lblNombre2" runat="server" Text="Byron Sosa Hidalgo "></asp:Label></div>
         </div>

        <div id="Proyecto" class="Padre">
            <div id="EtiquetaProyecto"  class="Hijo1">
                <asp:Label ID="lblTituloProyecto" runat="server" Text="Carrito de compras"></asp:Label></div>
          </div>


        <div id="Ano" class="Padre">
            <div id="EtiquetaAno" class="Hijo1">
                <asp:Label ID="lblAno" runat="server" Text="2022"></asp:Label></div>
         </div>


    <div id="Tutora" class="Padre">
        <div id="EtiquetaTutora" class="Hijo1"> 
            <asp:Label ID="lblTutora" runat="server" Text="Tutora:"></asp:Label></div>
     </div>


        <div id="Profe" class="Padre">
            <div id="EtiquetaProfe" class="Hijo1"> 
             <asp:Label ID="lblProfe" runat="server" Text="Milena Mata Sojo "></asp:Label></div>
        </div>
      
    <div id="Curso" class="Padre">
        <div id="EtiquetaCurso" class="Hijo1">
            <asp:Label ID="lblCurso" runat="server" Text="Programacion II"></asp:Label></div>
    </div>
 </div>
</asp:Content>
