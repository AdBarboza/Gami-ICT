<%@ Page Title="Nombre Parque" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Nombre_Parque.aspx.cs" Inherits="Gami_ICT.Views.Nombre_Parque" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </h2>
    <div class="row">
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:TemplateField HeaderText="Paquete" ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Select" Text="Select"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <div class="row">
    </div>
    </asp:Content>
