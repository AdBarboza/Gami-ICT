<%@ Page Title="Iniciar Sesión" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Gami_ICT.Views.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center"><%: Title %></h2>
    <div class="row" style="text-align: center">
        <div class="row">
            <asp:Label ID="Lbl_user" runat="server" Text="Usuario:"></asp:Label>
        </div>
        <div class="row">
            &nbsp;<asp:TextBox ID="TXT_user" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="LBL_PASS" runat="server" Text="Contraseña"></asp:Label>
        </div>
        <div class="row">
            &nbsp;<asp:TextBox ID="TXT_Contraseña" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="LBL_Error" runat="server" Text="No se pudo iniciar sesión." Visible="False"></asp:Label>
        </div>
        <div class="row">
            <asp:Button ID="BTN_Logear" runat="server" Text="Logear" OnClick="BTN_Logear_Click" />
        </div>
    </div>
    </asp:Content>
