

<%@ Page Title="طلب شهادة" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="RequestCertificate.aspx.vb" Inherits="HciProject.RequestCertificate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* General Styles */
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f7f7f7;
            color: #333;
            direction: rtl; 
        }

        /* Center align and spacing for content */
        .main-content {
            max-width: 600px;
            margin: 50px auto;
            padding: 20px;
            background-color: #ffffff;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
            text-align: right; /* Align text to the right */
        }

        /* Welcome message */
        .welcome-message {
            font-size: 1.8rem;
            font-weight: 700;
            color: #4A7C59; /* Dark green */
            text-align: center;
            margin-bottom: 20px;
        }

        /* Checkbox styles */
        .checkbox-container {
            text-align: right;
            margin-bottom: 20px;
        }

        .checkbox-container input {
            margin-left: 10px;
        }

        /* Button Styles */
        .btn-submit {
            background-color: #8FC0A9; /* Light green */
            color: #fff;
            border: none;
            padding: 10px 25px;
            border-radius: 5px;
            cursor: pointer;
            font-size: 1rem;
            transition: background-color 0.3s ease;
            display: block;
            margin: 0 auto;
        }

        .btn-submit:hover {
            background-color: #4A7C59; /* Dark green */
        }

        /* Message label */
        .message-label {
            font-size: 1rem;
            color: #ff0000;
            text-align: center;
            margin-top: 10px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main-content">
        <!-- Welcome message -->
        <div class="welcome-message">
            طلب شهادة امتحان الكفاءة
        </div>

        <div class="checkbox-container">
            <asp:CheckBox 
                ID="CheckBox1" 
                runat="server" 
                Text="أؤكد أنني أكملت بنجاح امتحان الكفاءة" 
                AutoPostBack="true" />
        </div>

        <div>
            <asp:Button 
                ID="Button1" 
                runat="server" 
                Text="إرسال الطلب" 
                CssClass="btn-submit" />
        </div>

        <div>
            <asp:Label 
                ID="Label2" 
                runat="server" 
                CssClass="message-label"></asp:Label>
        </div>
    </div>
</asp:Content>
