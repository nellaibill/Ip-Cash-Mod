Public Class Form1

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If (Me.txtUserName.Text = "user") And (Me.txtPassword.Text = "user") Then
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
