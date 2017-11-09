<%@ Page Title="Registrarse" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="Gami_ICT.Views.Registrar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center"><%: Title %>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </h2>
    <div class="row" style="text-align: center">
        <div class="row">
            <asp:Label ID="Lbl_user" runat="server" Text="Usuario:"></asp:Label>
        </div>
        <div class="row">
            <input id="TXT_User" type="text" />
        </div>
        <div class="row">
            <asp:Label ID="LBL_PASS" runat="server" Text="Contraseña"></asp:Label>
        </div>
        <div class="row">
            <input id="TXT_Contraseña" type="text" />
        </div>
        <div class="row">
            <asp:Label ID="LBL_Error" runat="server" Text="No se pudo iniciar sesión." Visible="False"></asp:Label>
        </div>
        <div class="row">
            <asp:Button ID="BTN_Registrarse" runat="server" Text="Registrarse" OnClick="BTN_Registrarse_Click" />
        </div>
    </div>
    </asp:Content>
