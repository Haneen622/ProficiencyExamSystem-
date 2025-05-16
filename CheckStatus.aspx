<%@ Page Title="متابعة حالة الطلب" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="CheckStatus.aspx.vb" Inherits="HciProject.CheckStatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .welcome-message {
            font-size: 1.8em;
            font-weight: bold;
            color: #8FC0A9; 
            margin-bottom: 20px;
            text-align: center;
        }
        .grid-style {
        table-layout: fixed;
        word-wrap: break-word;
    }
        .auto-style1 {
            margin-left: 254px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="welcome-message">
        متابعة حالة الطلب</div>
    &nbsp;
    <asp:GridView ID="g"  runat="server" CellPadding="4" GridLines="Horizontal" Width="52%" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CssClass="auto-style1">
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
    </asp:GridView>
</asp:Content>

