Imports System.IO
Public Class Frm_Cong
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Khai báo biến
        Dim A As Integer = TextBox1.Text
        Dim B As Integer = TextBox2.Text
        Dim Resul As String = TextBox3.Text
        ' Nhập giá trị vào Buttom Calculate
        TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
    End Sub

    Private Sub Frm_Cong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class