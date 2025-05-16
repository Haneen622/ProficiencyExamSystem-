<%@ Page Title="طباعة الوثائق" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="PrintDocumentsForFollow.aspx.vb" Inherits="HciProject.PrintDocumentsForFollow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            direction: rtl; /* Sets the text direction to right-to-left */
            margin: 0;
            padding: 0;
        }

        /* Table-like layout using div */
        .table-container {
            display: table;
            width: 100%;
            margin-top: 50px;
            text-align: center;
        }

        /* Rows in table */
        .table-row {
            display: table-row;
        }

        /* Cells in the row */
        .table-cell {
            display: table-cell;
            padding: 10px;
            vertical-align: middle; /* Vertically centers the text and buttons */
        }

        /* Button styling */
        .custom-button {
            background-color: #8FC0A9;
            color: white;
            padding: 12px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-size: 16px;
        }

        .custom-button:hover {
            background-color: #7a9e91;
        }

        /* Label text styling */
        .custom-label {
            font-size: 22px;
            display: block;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="table-container">
        <!-- First row with Label 1 and Button 1 -->
        <div class="table-row">
            <div class="table-cell">
                <asp:Label ID="Label1" runat="server" Text="طباعة اسماء الطلبة المتغيبين" CssClass="custom-label" />
            </div>
            <div class="table-cell">
                <asp:Button ID="Button1" runat="server" Text="طباعة" OnClick="Button1_Click" CssClass="custom-button" />
            </div>
        </div>

        <!-- Second row with Label 2 and Button 2 -->
        <div class="table-row">
            <div class="table-cell">
                <asp:Label ID="Label2" runat="server" Text="طباعة اسماء الطلبة المتقدمين للامتحان" CssClass="custom-label" />
            </div>
            <div class="table-cell">
                <asp:Button ID="Button2" runat="server" Text="طباعة" OnClick="Button2_Click" CssClass="custom-button" />
            </div>
        </div>

        <!-- Third row with Label 3 and Button 3 -->
        <div class="table-row">
            <div class="table-cell">
                <asp:Label ID="Label3" runat="server" Text="طباعة طلبات الامتحان التعويضي والشهادات" CssClass="custom-label" />
            </div>
            <div class="table-cell">
                <asp:Button ID="Button3" runat="server" Text="طباعة" OnClick="Button3_Click" CssClass="custom-button" />
            </div>
        </div>
    </div>
</asp:Content>