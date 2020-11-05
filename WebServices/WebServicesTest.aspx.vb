Imports System.Web.Services.Description
Imports System
Imports System.Web
Imports System.Linq
Imports System.Web.UI



Public Class WebServicesTest
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim webservice As New localhost.WebService1
        Dim a As Integer = Convert.ToInt64(TextBox1.Text)
        Dim b As Integer = Convert.ToInt64(TextBox2.Text)
        Dim c As Integer = webservice.Multiplication(a, b)
        TextBox3.Text = c
    End Sub
End Class