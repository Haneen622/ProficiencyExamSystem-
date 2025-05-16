<%@ Page Title="الصفحة الرئيسية" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="homeAQAC.aspx.vb" Inherits="HciProject.homeAQAC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            direction: rtl;
            font-family: Arial, sans-serif;
            background-color: #C8D5B9; /* اللون الباهت للخلفية */
            margin: 0;
            padding: 0;
        }
        .container {
            max-width: 1200px;
            margin: 0 auto;
            padding: 20px;
        }
        .welcome-message {
            font-size: 1.8em;
            font-weight: bold;
            color: #8FC0A9; /* الأخضر الداكن للنص */
            margin-bottom: 20px;
            text-align: center;
        }
        .options {
            margin-top: 20px;
            display: flex;
            flex-direction: column;
            gap: 15px;
            align-items: center;
        }
        .options a {
            text-decoration: none;
            color: white;
            background-color: #7BA591; /* الأخضر الداكن للأزرار */
            padding: 10px 20px;
            border-radius: 5px;
            width: 50%;
            text-align: center;
            font-size: 1.2em;
        }
        .options a:hover {
            background-color: #7BA591; /* الأخضر الفاتح عند التمرير */
            transition: 0.3s;
        }
        .logout-btn {
            background-color: red;  /* Red color */
            color: white;
            font-size: 1.2em;
            padding: 10px 20px;
            border-radius: 5px;
            text-align: center;
            width: 50%;
        }
        .logout-btn:hover {
            background-color: darkred;
            transition: 0.3s;
        }
        footer {
            background-color: #7BA591; 
            color: white;
            text-align: center;
            padding: 10px 0;
            margin-top: 30px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <!-- رسالة ترحيب -->
        <div class="welcome-message">
            أهلاً وسهلاً بك في الصفحة الرئيسية!
        </div>

        <!-- قائمة الخيارات -->
        <div class="options" aria-autocomplete="none">
            <asp:HyperLink ID="hlstRequestCertificate" runat="server" NavigateUrl="~/RequestCertificateAQAC.aspx">طلبات شهادة الكفاءة</asp:HyperLink>
            <asp:HyperLink ID="hlstMakeUpExam" runat="server" NavigateUrl="~/RequestMakeUpExamAQAC.aspx">طلبات التقدم لامتحان تعويضي</asp:HyperLink>
            <asp:HyperLink ID="hlstStatusCheck" runat="server" NavigateUrl="~/CheckStatusAQAC.aspx">متابعة حالة الطلب</asp:HyperLink>
            <asp:HyperLink ID="hlstPrintDocs" runat="server" NavigateUrl="~/PrintDocumentsForAQAC.aspx"> طلبات طباعة الشهادات والموافقات</asp:HyperLink>
            <asp:HyperLink ID="hlstExamDate" runat="server" NavigateUrl="~/MakeupExamDate.aspx"> تحديد موعد الامتحان التعويضي</asp:HyperLink>

            <!-- Logout Button -->
            <asp:Button ID="Button1" runat="server" Text="خروج" CssClass="logout-btn" OnClick="btnLogout_Click" />

        </div>
    </div>
</asp:Content>
