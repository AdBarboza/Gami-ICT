<%@ Page Title="Reservas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerReservas.aspx.cs" Inherits="Gami_ICT.Views.VerReservas" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center"><%: Title %></h2>
    <div class="row" style="text-align: center">
        <div class="row">
            <asp:ListView ID="List_Reservas" runat="server"></asp:ListView>
        </div>
    </div>
    </asp:Content>
