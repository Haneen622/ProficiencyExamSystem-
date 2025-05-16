'Imports System.Data.SqlClient

'Public Class PrintDocumentsForAQAC
'    Inherits System.Web.UI.Page

'    Dim obj As New DbOp()

'    ' This will run when a button is clicked to trigger a specific document to be printed
'    Protected Sub Button1_Click(sender As Object, e As EventArgs)
'        Response.Redirect("DisplayData.aspx?type=absent")
'    End Sub

'    Protected Sub Button2_Click(sender As Object, e As EventArgs)
'        Response.Redirect("DisplayData.aspx?type=attendees")
'    End Sub

'    Protected Sub Button3_Click(sender As Object, e As EventArgs)
'        Response.Redirect("DisplayData.aspx?type=requests")
'    End Sub

'    Dim filePath As String = "C:\Users\CW\OneDrive\Desktop\Universty\Hci\HciProject"

'End Class
Public Class PrintDocumentsForAQAC
    Inherits System.Web.UI.Page

    Dim obj As New DbOp()

    ' This will run when a button is clicked to trigger a specific document to be printed
    Protected Sub Button1_Click(sender As Object, e As EventArgs)
        Response.Redirect("DisplayData.aspx?type=absent")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs)
        Response.Redirect("DisplayData.aspx?type=attendees")
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs)
        Response.Redirect("DisplayData.aspx?type=requests")
    End Sub

End Class
