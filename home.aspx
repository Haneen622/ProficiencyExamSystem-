<%@ Page Title="الصفحة الرئيسية" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="home.aspx.vb" Inherits="HciProject.home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            direction: rtl;
            font-family: Arial, sans-serif;
            background-color: #C8D5B9;
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
            color: #8FC0A9;
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
            background-color: #7BA591;
            transition: 0.3s;
        }
        .logout-btn {
            background-color: red; 
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
        <div class="welcome-message">
            أهلاً وسهلاً بك في الصفحة الرئيسية!
        </div>

        <div class="options">
            <asp:HyperLink ID="hlRequestCertificate" runat="server" NavigateUrl="~/RequestCertificate.aspx">طلب شهادة الكفاءة</asp:HyperLink>
            <asp:HyperLink ID="hlMakeUpExam" runat="server" NavigateUrl="~/RequestMakeUpExam.aspx">طلب امتحان تعويضي</asp:HyperLink>
            <asp:HyperLink ID="hlStatusCheck" runat="server" NavigateUrl="~/CheckStatus.aspx">متابعة حالة الطلب</asp:HyperLink>
            <asp:HyperLink ID="hlPrintDocs" runat="server" NavigateUrl="~/PrintDocuments.aspx">طباعة الشهادات والموافقات</asp:HyperLink>
            <asp:HyperLink ID="hlmakeupExamDateStudent" runat="server" NavigateUrl="~/MakeupExamDateForStudent.aspx">موعد الامتحان التعويضي</asp:HyperLink>
            <asp:HyperLink ID="hlStudentData" runat="server" NavigateUrl="~/StudentData.aspx">بيانات الطالب</asp:HyperLink>
            <asp:Button ID="Button1" runat="server" Text="خروج" CssClass="logout-btn" OnClick="btnLogout_Click" />
            

        </div>
    </div>

  
</asp:Content>
