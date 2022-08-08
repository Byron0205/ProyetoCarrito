<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PáginaMaestra.Master" CodeBehind="Formulario web1.aspx.vb" Inherits="InterfazCarritoCompras.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Productos">
        <div class="Producto">
            <asp:Image ID="camisa1" runat="server" ImageUrl="~/img/CamisaA.png" Height="250px" Width="250px" />
            <div class="texto">
                <asp:Label ID="lblcamisa1Nom" runat="server" Text=""></asp:Label>
                <div class="precio">
                    <asp:Label ID="precio1" runat="server" Text="$"></asp:Label>
                    <asp:Label ID="lblcamisa1Precio" runat="server" Text=""></asp:Label>
                </div>
                
                <asp:Button ID="verMas1" runat="server" Text="Ver más..." />
            </div>
        </div>
        <div class="Producto">
            <asp:Image ID="camisa2" runat="server" ImageUrl="~/img/camisaB.jpg" Height="250px" Width="250px" />
            <div class="texto">
                <asp:Label ID="lblcamisa2Nom" runat="server" Text=""></asp:Label>
                <div class="precio">
                    <asp:Label ID="precio2" runat="server" Text="$"></asp:Label>
                    <asp:Label ID="lblcamisa2Precio" runat="server" Text=""></asp:Label>
                </div>
                
                <asp:Button ID="verMas2" runat="server" Text="Ver más..." />
            </div>
        </div>

    <div class="Producto">
            <asp:Image ID="pantalon1" runat="server" ImageUrl="~/img/pantalonA.jpg" Height="250px" Width="250px" />
        <div class="texto">
            <asp:Label ID="lblpantalon1Nom" runat="server" Text=""></asp:Label>
            <div class="precio">
                <asp:Label ID="precio3" runat="server" Text="$"></asp:Label>
                <asp:Label ID="lblpantalon1Precio" runat="server" Text=""></asp:Label>
            </div>
            
            <asp:Button ID="verMas3" runat="server" Text="Ver más..." />
        </div>
        </div>
        </div>
    <div class="Productos">
    <div class="Producto">
            <asp:Image ID="pantalon2" runat="server" ImageUrl="~/img/pantalonB.jpg" Height="250px" Width="250px" />
        <div class="texto">    
            <asp:Label ID="lblpantalon2Nom" runat="server" Text=""></asp:Label>
            <div class="precio">
                <asp:Label ID="precio4" runat="server" Text="$"></asp:Label>
                <asp:Label ID="lblpantalon2Precio" runat="server" Text=""></asp:Label>
            </div>
            <asp:Button ID="verMas4" runat="server" Text="Ver más..." />
        </div>
    </div>

    <div class="Producto">
            <asp:Image ID="tenis" runat="server" ImageUrl="~/img/tennis.jpg" Height="250px" Width="250px" />
        <div class="texto">    
            <asp:Label ID="lbltenisNom" runat="server" Text=""></asp:Label>
            <div class="precio">
                <asp:Label ID="precio5" runat="server" Text="$"></asp:Label>
                <asp:Label ID="lbltenisPrecio" runat="server" Text=""></asp:Label>
            </div>

            <asp:Button ID="verMas5" runat="server" Text="Ver más..." />
        </div>
    </div>
        </div>
</asp:Content>
