<%@ Page Title="Metodo Pago" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Metodo_Pago.aspx.cs" Inherits="Gami_ICT.Views.Metodo_Pago" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center"><%: Title %></h2>
    <div class="row" style="text-align: left">
        <div class="row">
            <asp:Label ID="LBL_TT" runat="server" Text="Tipo de Tarjeta:"></asp:Label>
            <asp:TextBox ID="TXT_TT" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="LBL_Numero" runat="server" Text="Numero:"></asp:Label>
            <asp:TextBox ID="TXT_Numero" runat="server" TextMode="Number"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="LBL_Fecha" runat="server" Text="Fecha Vencimiento:"></asp:Label>
            <asp:Calendar ID="Calendar_Venccimineto" runat="server"></asp:Calendar>
        </div>
        <div class="row">
            <asp:Label ID="LBL_Codigo" runat="server" Text="Codigo Seguridad:"></asp:Label>
            <asp:TextBox ID="TXT_Codigo" runat="server" TextMode="Number"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Button ID="BTN_Aceptar" runat="server" Text="Aceptar" OnClick="BTN_Aceptar_Click" />
        </div>
    </div>
    </asp:Content>