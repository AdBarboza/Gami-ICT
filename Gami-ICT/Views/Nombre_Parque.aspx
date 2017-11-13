<%@ Page Title="Nombre Parque" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Nombre_Parque.aspx.cs" Inherits="Gami_ICT.Views.Nombre_Parque" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <div class="row">
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    <div class="row">
        <asp:Button ID="BTN_Cargas_Parques" runat="server" Text="Cargar Parques/Museos" OnClick="BTN_Cargas_Parques_Click"  />
    </div>
    </asp:Content>
