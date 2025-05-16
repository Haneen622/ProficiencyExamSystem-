

<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="CertificatePage.aspx.vb" Inherits="HciProject.CertificatePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            margin: 0;
            padding: 0;
            background-color: #f0f0f0; 
            font-family: 'Tahoma', Arial, sans-serif;
        }

        .certificate-container {
            width: 80%;
            margin: 20px auto;
            padding: 20px;
            border: 10px solid #000;
            box-shadow: 0 0 15px rgba(0, 0, 0, 0.3);
            background-color: #f9f5dc; 
            text-align: center;
        }

        .certificate-header {
            font-size: 32px;
            font-weight: bold;
            margin-bottom: 20px;
        }

        .certificate-content {
            font-size: 20px;
            direction: rtl;
            text-align: center; 
            line-height: 1.8;
            margin-top: 20px;
        }

        .certificate-footer {
            margin-top: 50px;
            text-align: left;
        }

        .manager-signature {
            font-size: 18px;
            font-style: italic;
        }

        .print-button-container {
            text-align: center;
            margin-top: 30px;
        }

        .print-button {
             background-color: #8FC0A9;
                color: white;
                padding: 12px 20px;
                border: none;
                border-radius: 5px;
                cursor: pointer;
                font-size: 16px;
        }

        .print-button:hover {
            background-color: #45a049; 
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="certificate-container">
        <div class="certificate-header">شهادة اجتياز امتحان الكفاءة</div>
        <div class="certificate-content">
            <p>بسم الله الرحمن الرحيم</p>
            <p>تشهد هيئة اعتماد مؤسسات التعليم العالي وضمان جودتها</p>
            <p>أن الطالب/ة: <asp:Label ID="lblStudentName" runat="server"></asp:Label></p>
            <p>من كلية: <asp:Label ID="lblCollege" runat="server"></asp:Label></p>
            <p>تخصص: <asp:Label ID="lblMajor" runat="server"></asp:Label></p>
            <p>قد اجتاز/ت امتحان الكفاءة بنجاح.</p>
        </div>
        <div class="certificate-footer">
            <p class="manager-signature">توقيع الرئيس</p>
                        <p class="manager-signature">ظافر الصرايرة </p>

        </div>
    </div>

    <!-- Print Button Section -->
    <div class="print-button-container">
        <button class="print-button" onclick="printCertificate()">طباعة الشهادة</button>
    </div>

    <script>
        function printCertificate() {
            const certificate = document.querySelector('.certificate-container'); 
            const printWindow = window.open('', '_blank'); 
            printWindow.document.write(`
                <html>
                <head>
                    <title>طباعة الشهادة</title>
                    <style>
                        body {
                            font-family: 'Tahoma', Arial, sans-serif;
                            text-align: center;
                            margin: 0;
                            padding: 20px;
                            background-color: #f9f5dc; /* Same background as the certificate */
                        }
                        .certificate-container {
                            border: 10px solid #000;
                            padding: 20px;
                            width: 80%;
                            margin: auto;
                        }
                        .certificate-header {
                            font-size: 32px;
                            font-weight: bold;
                            text-decoration: underline;
                            margin-bottom: 20px;
                        }
                        .certificate-content {
                            font-size: 20px;
                            line-height: 1.8;
                            text-align: center;
                            direction: rtl;
                            margin-top: 20px;
                        }
                        .certificate-footer {
                            margin-top: 50px;
                            text-align: left;
                        }
                        .manager-signature {
                            font-size: 18px;
                            font-style: italic;
                        }
                    </style>
                </head>
                <body>${certificate.outerHTML}</body>
                </html>
            `);
            printWindow.document.close();
            printWindow.print();
        }
    </script>
</asp:Content>

