<%@ Page Title="Paquete Turístico" Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Paquete_Especifico.aspx.cs" Inherits="Gami_ICT.Views.Parq_Musep_Especifico" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center"><%: Title %></h2>
    
    <div class="columns">
        <div class="col-md-2">
            <div class ="row">
                <asp:Button ID="BTN_Parques" runat="server" Text="Parques Nacionales/Museos" Width="260px" />
            </div>
            <div class ="row">
                <asp:Button ID="BTN_Hoteles" runat="server" Text="Hoteles" Width="260px" />
            </div>
            <div class ="row">
                <asp:Button ID="BTN_Restaurante" runat="server" Text="Restaurantes" Width="260px" />
            </div>
        </div>
        
        <div class="col-md-2">
            <asp:GridView ID="Grid1" runat="server"></asp:GridView>
        </div>
    </div>

    <div>
        <table style="width: 100%;">
            <tr>
                <td>Destino</td>
                <td>Desde</td>
                <td>Hasta</td>
                <td>Personas</td>
                <td>Monto Total</td>
                <td>Opciones</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
            <asp:Label ID="LBL_Total" runat="server" Text="Total: "></asp:Label>
            <asp:Label ID="LBL_Total_Calculo" runat="server" Text="2000"></asp:Label>
            <asp:Button ID="BTN_Reservar" runat="server" Text="Reservar" OnClick="BTN_Reservar_Click" />
        </div>
    </div>
    </asp:Content>