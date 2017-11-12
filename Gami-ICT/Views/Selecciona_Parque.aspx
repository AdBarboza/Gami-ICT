<%@ Page Title="Generar Paquete" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Selecciona_Parque.aspx.cs" Inherits="Gami_ICT.Views.Selecciona_Parque" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center"><%: Title %></h2>
    <div class="row" >
        <div class="row">
            <asp:Label ID="LBL_Fecha" runat="server" Text="Fecha:"></asp:Label>
            <asp:Calendar ID="Calendar" runat="server"></asp:Calendar>
        </div>
        <div class="row">
            <asp:Label ID="LBL_Cantidad" runat="server" Text="Cantidad:"></asp:Label>
            <asp:TextBox ID="TXT_cantidad" runat="server" TextMode="Number"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Button ID="BTN_Aceptar" runat="server" Text="Aceptar" OnClick="BTN_Aceptar_Click" />
        </div>
    </div>
    </asp:Content>