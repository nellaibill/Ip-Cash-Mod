Public Class Form1

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If (Me.txtUserName.Text = "admin") And (Me.txtPassword.Text = "abhayfearlessbhaskarasun") Then
            Me.Hide()
            DoctorFees.Show()
        Else
            MsgBox("Wrong Username/Password", 1)
            txtUserName.Text = ""
            txtPassword.Text = ""
            txtUserName.Focus()
        End If
    End Sub
End Class
