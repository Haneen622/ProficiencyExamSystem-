

<%@ Page Title="طباعة الشهادات" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="PrintDocuments.aspx.vb" Inherits="HciProject.PrintDocuments" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            direction: rtl; /* Set the page direction to right-to-left */
            text-align: right; /* Align text to the right */
            font-family: 'Tahoma', Arial, sans-serif; /* Use a readable Arabic-friendly font */
        }
    
       .btn-submit:disabled {
            background-color: #ccc;
            cursor: not-allowed;
        }
          .btn-submit {
                background-color: #8FC0A9;
                color: white;
                padding: 12px 20px;
                border: none;
                border-radius: 5px;
                cursor: pointer;
                font-size: 16px;
                position: relative;
                top: -50%;
                left: -45%;
                margin-top: 30px;

        }
        .info-message {
            font-size: 1.2em;
            color: #333;
            margin-bottom: 15px;
            display: block;
            text-align :center 
        }
         .welcome-message {
            font-size: 1.8em;
            font-weight: bold;
            color: #8FC0A9; /* الأخضر الداكن للنص */
            margin-bottom: 20px;
            text-align: center;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="welcome-message">طباعة الشهادات</h2>
    <asp:Label ID="lblMessage" runat="server" Text="يجب عليك إكمال الامتحان لطباعة الشهادة." CssClass="info-message"></asp:Label>
    
    <!-- عرض الزر للطباعة فقط إذا كان الامتحان مكتمل -->
    <%--OnClick="btnPrintCertificate_Click"--%>
    <asp:Button ID="btnPrintCertificate" runat="server" Text="طباعة الشهادة" CssClass="btn-submit"  Enabled="False" />
    
</asp:Content>
