Imports System.Text.RegularExpressions
Imports Newtonsoft.Json

Public Class Form1
    Dim PATH As String = "C:\Users\Jopolo Camcam\Desktop\FormatSaveForms"

    Class formInput
        Public name As String
        Public age As Int32
        Public address As String
    End Class

    Private Sub TextAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextAge.KeyPress

    End Sub

    Private Sub TextAge_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextAge.TextChanged

    End Sub

    Private Sub SaveTxt_Click(sender As Object, e As EventArgs) Handles SaveTxt.Click

    End Sub

    Private Sub SaveXml_Click(sender As Object, e As EventArgs) Handles SaveXml.Click

    End Sub

    Private Sub SaveJson_Click(sender As Object, e As EventArgs) Handles SaveJson.Click

    End Sub
End Class
