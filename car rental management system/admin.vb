Imports MySql.Data.MySqlClient

Public Class admin
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim cstring As String = "Data Source = Localhost; User ID = root; Database = crudvb "
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            conn = New MySqlConnection(cstring)
            conn.Open()
            Dim sql As String = "SELECT * FROM admin WHERE username = '" & txtUsername.Text & "' AND password = '" & txtPassword.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() <> 0 Then
                Dashboard.Show()
                Me.Hide()
                txtUsername.Clear()
                txtPassword.Clear()

            Else
                MessageBox.Show("Error Occured, Invalid Username or Password!.")
                txtUsername.Clear()
                txtPassword.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()

        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class