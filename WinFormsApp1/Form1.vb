

Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        Dim query As String = "SELECT * FROM account WHERE username = @username AND password = @password"

        Using connection As New MySqlConnection("server=localhost;user id=root;port=3306;password=1234;database=enrollsys")
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                connection.Open()

                Using dataReader As MySqlDataReader = command.ExecuteReader()
                    If dataReader.Read() Then
                        MsgBox("Login Successfully")
                        Me.Hide()
                        Form2.Show()
                    Else
                        MsgBox("Invalid Username or Password")
                    End If
                End Using
            End Using
        End Using


    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub


    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If txtPassword.UseSystemPasswordChar = False Then

            'hide password
            txtPassword.UseSystemPasswordChar = True
        Else
            'show password
            txtPassword.UseSystemPasswordChar = False


        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.UseSystemPasswordChar = True
    End Sub
End Class
