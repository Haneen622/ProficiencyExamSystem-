<%@ Page Title="طلبات الامتحان التعويضي" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="RequestMakeUpExamAQAC.aspx.vb" Inherits="HciProject.RequestMakeUpExamAQAC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .welcome-message {
            font-size: 1.8em;
            font-weight: bold;
            color: #8FC0A9; /* الأخضر الداكن للنص */
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
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="welcome-message">
        طلبات التقدم لامتحان تعويضي
    </div>
    <div class="auto-style1">
        <asp:GridView ID="g" runat="server" DataKeyNames="رقم الطالب" OnRowCommand="g_RowCommand" 
                      CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnReject" runat="server" CommandName="Reject" CommandArgument='<%# Eval("رقم الطالب") %>' 
                                    Text="رفض الطلب" CssClass="btn-submit" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnApprove" runat="server" CommandName="Approve" CommandArgument='<%# Eval("رقم الطالب") %>' 
                                    Text="موافقة الطلب" CssClass="btn-submit" />
                    </ItemTemplate>
                </asp:TemplateField>
              
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    </div>
    <div style="text-align: center;">
        <br />
        <br />
        <br />
    </div>
</asp:Content>
