<%@ Page Title="Cerrar Sesion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CerrarSesion.aspx.cs" Inherits="Gami_ICT.Views.CerrarSesion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center"><%: Title %></h2>
    <h4 style="text-align: center">¿Desea cerrar sesion?</h4>
    <div class="row" style="text-align: center">
        <div class="row">
            <asp:Button ID="BTN_Cerrar" runat="server" Text="Cerrar sesión" OnClick="BTN_Cerrar_Click"  />
        </div>
    </div>
    </asp:Content>