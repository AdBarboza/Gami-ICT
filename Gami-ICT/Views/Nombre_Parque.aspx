<%@ Page Title="Nombre Parque" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Nombre_Parque.aspx.cs" Inherits="Gami_ICT.Views.Nombre_Parque" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center"><%: Title %></h2>
    <div class="row">
        <asp:ListView ID="List_Parques" runat="server"></asp:ListView>
    </div>
    <div class="row">
        <asp:Button ID="BTN_Cargas_Parques" runat="server" Text="Cargar Parques/Museos" OnClick="BTN_Cargas_Parques_Click"  />
    </div>
    </asp:Content>
