<%@ Page Title="Paquete Turístico" Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Paquete_Especifico.aspx.cs" Inherits="Gami_ICT.Views.Parq_Musep_Especifico" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align: center"><%: Title %>
    </h2>
    <div class="row">
        <asp:Label ID="Label_Hotel" runat="server" Text="Hotel"></asp:Label>
    </div>
    <div class="row">
        <asp:GridView ID="GridView_Hotel" runat="server" OnSelectedIndexChanged="GridView_Hotel_SelectedIndexChanged">
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="Select"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <div class="row">
        <asp:Label ID="LabelFecha_Hotel" runat="server" Text="Seleccione Fecha Inicial"></asp:Label>
    </div>
    <div class="row">
        <asp:Calendar ID="Calendar_Hotel" runat="server" OnSelectionChanged="Calendar_Hotel_SelectionChanged"></asp:Calendar>
    </div>
    <div class="row">
        <asp:Label ID="LabelFecha2_Hotel" runat="server" Text="Seleccione Fecha Final"></asp:Label>
    </div>
    <div class="row">
        <asp:Calendar ID="Calendar2_Hotel" runat="server"></asp:Calendar>
    </div>
    <div class="row">
        <asp:Label ID="LabelTipo_Hotel" runat="server" Text="Seleccione Tipo de Habitacion"></asp:Label>
    </div>
    <div class="row">
            <asp:DropDownList ID="DD_tipoHabitacion" runat="server" >
                <asp:ListItem>doble – 2 adultos y 2 menores</asp:ListItem>
                <asp:ListItem>triple – 3 adultos y 1 menor</asp:ListItem>
                <asp:ListItem Value="cuádruple – 4 adultos"></asp:ListItem>
                <asp:ListItem>Junior Suite – doble + salón</asp:ListItem>
                <asp:ListItem>Suite – 2 dobles + baños + salón + hall</asp:ListItem>
            </asp:DropDownList>
    </div>
    <div class="row">
        <asp:Label ID="LabelCantidad_Hotel" runat="server" Text="Digite la Cantidad de Personas"></asp:Label>
    </div>
    <div class="row">
        <asp:TextBox ID="TextBox_Hotel" runat="server" TextMode="Number"></asp:TextBox>
    </div>
    <div class="row">
        <asp:Button ID="Button_Hotel" runat="server" Text="Agregar" OnClick="Button_Hotel_Click" />
    </div>
    <div class="row">
        <asp:Label ID="Label_Restaurante" runat="server" Text="Restaurante"></asp:Label>
    </div>
    <div class="row">
        <asp:GridView ID="GridView_Restaurante" runat="server" OnSelectedIndexChanged="GridView_Restaurante_SelectedIndexChanged1" Width="201px">
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="Select"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <div class="row">
        <asp:Label ID="LabelFecha_Restaurante" runat="server" Text="Seleccione Fecha"></asp:Label>
    </div>
    <div class="row">
        <asp:Calendar ID="Calendar_Restaurante" runat="server"></asp:Calendar>
    </div>
    <div class="row">
        <asp:Label ID="LabelCantidad_Restaurante" runat="server" Text="Digite la Cantidad de Personas"></asp:Label>
    </div>
    <div class="row">
        <asp:TextBox ID="TextBox_Restaurante" runat="server" TextMode="Number"></asp:TextBox>
    </div>
    <div class="row">
        <asp:Button ID="Button_Restaurante" runat="server" Text="Agregar" OnClick="Button_Restaurante_Click" />
    </div>
    <div class="row">
        <asp:TextBox ID="TextBox_Aceptar" runat="server"></asp:TextBox>
    </div>
    <div class="row">
        <asp:Button ID="Button_EliminarHotel" runat="server" Text="Quitar Hotel" OnClick="Button_EliminarHotel_Click" />
    </div>
    <div class="row">
        <asp:Button ID="Button_EliminarRestaurante" runat="server" Text="Quitar Restaurante" OnClick="Button_EliminarRestaurante_Click" />
    </div>
    <div class="row">
        <asp:Button ID="Button_Aceptar" runat="server" Text="Aceptar" OnClick="Button_Aceptar_Click"/>
    </div>
    </asp:Content>