<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Gami_ICT._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p>&nbsp;</p>
        <asp:Panel ID="Panel1" runat="server" BackColor="White" Height="482px">
            <table style="width: 100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td style="width: 269px">
                        <asp:TextBox ID="TB_email" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TB_password" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td style="width: 269px">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td style="width: 269px">
                        <asp:Label ID="LB_prueba" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
    </div>

    </asp:Content>
