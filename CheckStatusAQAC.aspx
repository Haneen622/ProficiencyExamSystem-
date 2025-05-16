<%@ Page Title="متابعة حالة الطلب" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="CheckStatusAQAC.aspx.vb" Inherits="HciProject.CheckStatusAQAC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">


        .welcome-message {
            font-size: 1.8em;
            font-weight: bold;
            color: #8FC0A9; 
            margin-bottom: 20px;
            text-align: center;
        }
         .auto-style1 {
            margin-left: 254px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="welcome-message">
        متابعة حالة الطلب</div>
    <asp:GridView ID="g" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="52%" CssClass="auto-style1">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
</asp:Content>
