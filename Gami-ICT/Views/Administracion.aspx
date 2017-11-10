<%@ Page Title="Administracion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Administracion.aspx.cs" Inherits="Gami_ICT.Views.Administracion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center"><%: Title %></h2>
    <div class="row">
        <asp:Button ID="BTN_Reserva" runat="server" Text="Ver Reservas" OnClick="BTN_Reserva_Click" />
    </div>
    <div class="row">
        <asp:Button ID="BTN_Restaurante" runat="server" Text="Registrar Restaurante" OnClick="BTN_Restaurante_Click" />
    </div>
    <div class="row">
        <asp:Button ID="BTN_Parque" runat="server" Text="Registrar Parque" OnClick="BTN_Parque_Click" />
    </div>
    <div class="row">
        <asp:Button ID="BTN_Hotel" runat="server" Text="Registrar Hotel" OnClick="BTN_Hotel_Click" />
    </div>
    </asp:Content>