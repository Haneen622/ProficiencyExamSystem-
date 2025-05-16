

<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/login.Master" CodeBehind="login.aspx.vb" Inherits="HciProject.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        /* General styling for centering and layout management */
        body {
            font-family: Arial, sans-serif;
            background-image: url('Resources/h.jpg'); /* Add the image path here */
            background-size: cover; /* Make sure the image covers the whole screen */
            background-position: center; /* Center the image */
            background-attachment: fixed; /* Ensure the background stays in place when scrolling */
            margin: 0;
            padding: 0;
            
        }

        /* Table styles for centering content */
        .login-container {
            margin: 50px auto;
            width: 500px;
            background-color:white ;
            border-radius: 10px;
            padding: 20px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2); /* Add subtle shadow for depth */
        }

        /* Input textboxes with a smaller width */
        input[type="text"], input[type="password"] {
            width: 300px; /* Reduce width for smaller size */
            padding: 8px;
            margin: 10px 0;
            border: 1px solid #ddd;
            border-radius: 5px;
            font-size: 14px;
            margin-right: 46px;
        }

        /* Buttons with professional styling */
        .btn-submit {
            background-color: #8FC0A9;
            color: white;
            padding: 8px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-size: 16px;
        }

        .btn-submit:hover {
            background-color: #4A7C59; 
        }

        /* Style for the Arabic labels */
        .arabic-label {
            display: inline-block;
            text-align: right;
            font-family: 'Arabic Typesetting';
            font-size: 24px;
            margin-bottom: 5px;
        }

        /* Error message styling */
        .error-message {
            color: #FF0000;
            font-weight: bold;
            text-align: center;
            margin-top: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login-container">
        <!-- User ID input -->
        <div>
            <asp:TextBox ID="usr" runat="server" CssClass="form-control" placeholder="Enter User ID" style="width: 300px;"></asp:TextBox>
            <label for="usr" class="arabic-label">رقم المستخدم</label>
        </div>
        <!-- Password input -->
        <div>
            <asp:TextBox ID="pw" runat="server" CssClass="form-control" TextMode="Password" placeholder="Enter Password" style="width: 300px;"></asp:TextBox>
            <label for="pw" class="arabic-label">كلمة المرور</label>
        </div>

        <!-- Submit button -->
        <div>
            <asp:Button ID="Button1" runat="server" Text="دخول" CssClass="btn-submit" />
        </div>

        <!-- Error message area -->
        <div>
            <asp:Label ID="msg" runat="server" CssClass="error-message"></asp:Label>
        </div>
    </div>
</asp:Content>
