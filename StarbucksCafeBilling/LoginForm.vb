Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = BtnLogin

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Enter username & password")
            Exit Sub
        End If

        Try
            DB.Open()

            ' ========================
            ' 1. CHECK OWNER LOGIN
            ' ========================
            If username = "owner" And password = "456789" Then

                SessionManager.LoggedInUser = username

                DB.Close()

                MessageBox.Show("Owner Login Successful")

                Me.Hide()

                DashboardForm.Show()

                Exit Sub

            End If

            ' ========================
            ' 2. CHECK DATABASE LOGIN
            ' ========================
            Dim cmd As New MySqlCommand(
                "SELECT role FROM users WHERE username=@u AND password=@p LIMIT 1",
                DB.conn
            )

            cmd.Parameters.AddWithValue("@u", username)
            cmd.Parameters.AddWithValue("@p", password)

            Dim roleObj As Object = cmd.ExecuteScalar()

            DB.Close()

            If roleObj Is Nothing OrElse roleObj Is DBNull.Value Then

                MessageBox.Show("Invalid Username or Password")

                txtUsername.Clear()
                txtPassword.Clear()
                txtUsername.Focus()

                Exit Sub
            End If

            Dim role As String = roleObj.ToString().ToLower()

            SessionManager.LoggedInUser = username

            MessageBox.Show("Login Successful (" & role & ")")

            Me.Hide()

            If role = "owner" Then
                DashboardForm.Show()
            ElseIf role = "admin" Then
                StarbucksBilling.Show()
            Else
                MessageBox.Show("Unknown role in database")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub
End Class