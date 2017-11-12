<%@ Page Title="Pago Exitoso" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pago_Exitoso.aspx.cs" Inherits="Gami_ICT.Views.Pago_Exitoso" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center"><%: Title %>.</h2>
    <div style="text-align: center">
         <asp:Button ID="BTN_Continuar" runat="server" Text="Continuar" OnClick="BTN_Continuar_Click" />
    </div>
   
</asp:Content>
