<%@ Page Title="Registrar Restaurante" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrar_Restaurante.aspx.cs" Inherits="Gami_ICT.Views.Registrar_Restaurante" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center"><%: Title %></h2>
    <div class="row" style="text-align: center">
        <div class="row">
            <asp:Label ID="LBL_Nombre" runat="server" Text="Nombre:"></asp:Label>
        </div>
        <div class="row">
            <asp:TextBox ID="TXT_Nombre" runat="server"></asp:TextBox>
            <br />
            Codigo:<br />
            <asp:TextBox ID="TXT_codigo" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="Lbl_Maximo" runat="server" Text="Maximo de Personas:"></asp:Label>
        </div>
        <div class="row">
            <asp:TextBox ID="TXT_Maximo" runat="server" TextMode="Number"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="LBL_Error" runat="server" Text="No se pudo registrar correctamente." Visible="False"></asp:Label>
        </div>
        <div class="row">
            <asp:Button ID="But_reg" runat="server" Text="Registar" OnClick="But_reg_Click" />
        </div>
    </div>
    </asp:Content>