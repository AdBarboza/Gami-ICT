<%@ Page Title="Registrarse" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="Gami_ICT.Views.Registrar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center"><%: Title %>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </h2>
    <div class="row" style="text-align: center">
        <div class="row">
            <asp:Label ID="LBL_Nombre" runat="server" Text="Nombre:"></asp:Label>
        </div>
        <div class="row">
            <asp:TextBox ID="TXT_Nombre" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="Lbl_correo" runat="server" Text="Correo:"></asp:Label>
        </div>
        <div class="row">
            <asp:TextBox ID="TXT_Correo" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="LBL_Apellido" runat="server" Text="Apellido:"></asp:Label>
        </div>
        <div class="row">
            <asp:TextBox ID="TXT_Apellido" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="LBL_Cedula" runat="server" Text="Cedula:"></asp:Label>
        </div>
        <div class="row">
            <asp:TextBox ID="TXT_Cedula" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="LBL_PASS" runat="server" Text="Contraseña"></asp:Label>
        </div>
        <div class="row">
            <asp:TextBox ID="TXT_Contraseña" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="LBL_Error" runat="server" Text="No se pudo registrar correctamente." Visible="False"></asp:Label>
        </div>
        <div class="row">
            <asp:Button ID="BTN_Registrarse" runat="server" Text="Registrarse" OnClick="BTN_Registrarse_Click" />
        </div>
    </div>
    </asp:Content>
