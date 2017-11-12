<%@ Page Title="Registrar Hotel" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrar_Hotel.aspx.cs" Inherits="Gami_ICT.Views.Registrar_Hotel" %>

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
            <asp:TextBox ID="TXT_cod" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="Lbl_Tipo" runat="server" Text="Tipo de Habitacion:"></asp:Label>
        </div>
        <div class="row">
            <asp:DropDownList ID="DD_tipoHabitacion" runat="server">
                <asp:ListItem>doble – 2 adultos y 2 menores</asp:ListItem>
                <asp:ListItem>triple – 3 adultos y 1 menor</asp:ListItem>
                <asp:ListItem Value="cuádruple – 4 adultos"></asp:ListItem>
                <asp:ListItem>Junior Suite – doble + salón</asp:ListItem>
                <asp:ListItem>Suite – 2 dobles + baños + salón + hall</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="row">
            <asp:Label ID="LBL_Cantidad" runat="server" Text="Cantidad:"></asp:Label>
        </div>
        <div class="row">
            <asp:TextBox ID="TXT_Cantidad" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="LBL_Tarifa" runat="server" Text="Tarifa:"></asp:Label>
        </div>
        <div class="row">
            <asp:TextBox ID="TXT_Tarifa" runat="server"></asp:TextBox>
        </div>
        <div class="row">
            <asp:Label ID="LBL_Error" runat="server" Text="No se pudo registrar correctamente." Visible="False"></asp:Label>
        </div>
        <div class="row">
            <asp:Button ID="BTN_Registrarse" runat="server" Text="Registrar" OnClick="BTN_Registrarse_Click" />
        </div>
    </div>
    </asp:Content>
