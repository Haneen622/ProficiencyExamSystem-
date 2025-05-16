

<%@ Page Title="إعلان موعد الامتحان التعويضي" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="MakeupExamDateForStudent.aspx.vb" Inherits="HciProject.MakeupExamDateForStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            background-color: #8FC0A9; /* Light greenish background */
            font-family: 'Arial', sans-serif;
            direction: rtl;
            text-align: right;
        }

        h2 {
            color: #ffffff;
            text-align: center;
            margin-top: 20px;
        }

        .announcement-container {
            background-color: #ffffff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
            margin: 0 auto;
            width: 70%;
        }

        .announcement-text {
            font-size: 16px;
            line-height: 1.8;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>إعلان الامتحان</h2>

    <div class="announcement-container">
        <!-- Add the lblAnnouncement here -->
        <asp:Label ID="lblAnnouncement" runat="server" CssClass="announcement-text"></asp:Label>
    </div>
</asp:Content>

