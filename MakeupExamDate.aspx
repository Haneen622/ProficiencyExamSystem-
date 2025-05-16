

<%@ Page Title="اعلان الامتحان التعويضي" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="MakeupExamDate.aspx.vb" Inherits="HciProject.MakeupExamDate" %>

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

        .form-container {
            background-color: #ffffff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
            margin: 0 auto;
            width: 70%;
        }

        label {
            font-size: 16px;
            margin-bottom: 10px;
            display: block;
        }

        input[type="text"] {
            width: 100%; 
            padding: 8px;
            margin-bottom: 20px;
            border: 2px solid #ccc;
            border-radius: 4px;
            font-size: 14px;
        }

        input[type="text"]:focus {
            border-color: #4CAF50;
        }

        .btn {
            background-color: #8FC0A9;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            font-size: 16px;
            cursor: pointer;
        }

        button:hover {
            background-color: #45a049;
        }

        .message {
            font-size: 16px;
            color: #4CAF50;
            text-align: center;
            margin-top: 20px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>تحديث بيانات الامتحان (لوحة الإدارة)</h2>
    <div class="form-container">
        <label for="txtExamDate">تاريخ الامتحان:</label>
        <input type="text" id="txtExamDate" runat="server" placeholder="14/01/2025" />
        
        <label for="txtExamDay">اليوم:</label>
        <input type="text" id="txtExamDay" runat="server" placeholder="الثلاثاء" />
        
        <label for="txtSession1">الجلسة الأولى:</label>
        <input type="text" id="txtSession1" runat="server" placeholder="4:00-5:30" />
        
        <label for="txtSession2">الجلسة الثانية:</label>
        <input type="text" id="txtSession2" runat="server" placeholder="5:30-7:00" />
        
        <label for="txtLocation">مكان الامتحان:</label>
        <input type="text" id="txtLocation" runat="server" placeholder="مختبر علوم التأهيل 1 وعلوم التأهيل 2/ كلية علوم التأهيل" />
                
        <!-- Add the lblMessage Label here -->
                <asp:Button ID="Button1" runat="server" Text="تحديث " CssClass="btn" />
        <asp:Label ID="lblMessage" runat="server" CssClass="message" Text=""></asp:Label>
    &nbsp;
    </div>
</asp:Content>
