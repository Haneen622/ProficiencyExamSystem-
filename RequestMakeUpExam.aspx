

<%@ Page Title="طلب امتحان تعويضي" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="RequestMakeUpExam.aspx.vb" Inherits="HciProject.RequestMakeUpExam" %>
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
            text-align: center;
        }
        .btn-submit {
            background-color: #8FC0A9;
            color: white;
            padding: 8px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-size: 16px;
        }
        .info-text {
            font-size: 1.2em;
            color: #FF5733;
            text-align: center;
            margin-top: 10px;
            display: block;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="welcome-message">
        طلب امتحان تعويضي
    </div>
    <div class="auto-style1">
        <div style="text-align: center;">
            <br />
            <div style="text-align: center;">
                <asp:Button ID="Button1" runat="server" Text="إرسال الطلب" CssClass="btn-submit" />
            </div>
            <br />
            <asp:Label ID="Label2" runat="server" Text="يرجى ملاحظة أن فقط الطلاب الذين تغيبوا عن الامتحان الأصلي يُسمح لهم بتقديم طلب امتحان تعويضي." CssClass="info-text" />
            <br />
            <br />
        </div>
    </div>
</asp:Content>
