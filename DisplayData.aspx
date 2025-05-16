<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="DisplayData.aspx.vb" Inherits="HciProject.DisplayData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
            text-align: center;
        }

        table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }

        th, td {
            border: 1px solid #ddd;
            padding: 8px;
            text-align: center;
        }

        th {
            background-color: #8FC0A9;
            color: white;
        }

        .print-button {
            margin-top: 20px;
            background-color: #8FC0A9;
            color: white;
            border: none;
            padding: 10px 20px;
            cursor: pointer;
            font-size: 16px;
            border-radius: 5px;
        }

        .certificate-container {
            background-color: #f9f5dc;
            border: 10px solid #000;
            padding: 20px;
            margin: 20px auto;
            text-align: center;
            width: 80%;
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
    </style>

    <script>
        function printCertificate() {
            const certificate = document.querySelector('.certificate-container');
            const printWindow = window.open('', '_blank');
            printWindow.document.write(`
                <html>
                <head>
                    <title>طباعة البيانات</title>
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

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="certificate-container">
        <asp:Label ID="PageTitleLabel" runat="server" Font-Size="Large" Font-Bold="True"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True" CssClass="table" />
        <button type="button" class="print-button" onclick="printCertificate()">طباعة</button>
    </div>
</asp:Content>
