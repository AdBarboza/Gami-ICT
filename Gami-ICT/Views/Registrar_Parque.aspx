<%@ Page Title="Registrar Parque/Museo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrar_Parque.aspx.cs" Inherits="Gami_ICT.Views.Registrar_Parque" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center"><%: Title %></h2>
    <div class="row" style="text-align: center">
        <div class="row">
            <asp:Label ID="LBL_Nombre" runat="server" Text="Nombre:"></asp:Label>
        </div>
        <div class="row">
            <asp:TextBox ID="TXT_Nombre" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="Lbl_Tarifa" runat="server" Text="Tarifa:"></asp:Label>
        </div>
        <div class="row">
            <asp:TextBox ID="TXT_Tarifa" runat="server"></asp:TextBox>
            <br />
        </div>
        <div class="row" style="margin-bottom: 9px">
            <asp:Label ID="LBL_Error" runat="server" Text="No se pudo registrar correctamente." Visible="False"></asp:Label>
        </div>
        <div class="row">
            <asp:Button ID="BTN_Registrar" runat="server" Text="Registrar" OnClick="BTN_Registrar_Click"/>
        </div>
    </div>
    </asp:Content>