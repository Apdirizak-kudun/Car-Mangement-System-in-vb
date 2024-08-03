Imports MySql.Data.MySqlClient

Public Class customers
    Dim conn As MySqlConnection
    Dim cstring As String = "Data Source = Localhost; User ID = root; Database = crudvb"
    Dim cmd As MySqlCommand
    Dim ds As DataSet
    Dim da As MySqlDataAdapter
    Dim itemcoll(100) As String
    Private Sub cbAvailable_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            conn = New MySqlConnection(cstring)
            conn.Open()
            Dim sql As String = "INSERT INTO customer(custName,custAddress,custPhone) values ('" & txtCustName.Text & "', '" & txtCustAdd.Text & "', '" & txtCustPhone.Text & "') "
            cmd = New MySqlCommand(sql, conn)
            Dim a As Integer = cmd.ExecuteNonQuery()
            If a <> 0 Then
                MessageBox.Show("New Customer Registered Successfully!.", "Admin")
                txtCustName.Clear()
                txtCustAdd.Clear()
                txtCustPhone.Clear()
                Read()

            Else
                MessageBox.Show("Error Occured, Not Registered", "Admin")
                txtCustName.Clear()
                txtCustAdd.Clear()
                txtCustPhone.Clear()
                Read()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub
    Public Sub Read()
        Try
            lstRead.Items.Clear()
            conn = New MySqlConnection(cstring)
            conn.Open()
            Dim sql As String = "SELECT * FROM customer"
            cmd = New MySqlCommand(sql, conn)
            ds = New DataSet
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds, "Tables")


            For r = 0 To ds.Tables(0).Rows.Count - 1
                For c = 0 To ds.Tables(0).Columns.Count - 1
                    itemcoll(c) = ds.Tables(0).Rows(r)(c).ToString
                Next
                Dim lstvw As New ListViewItem(itemcoll)
                lstRead.Items.Add(lstvw)
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()

        End Try

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Read()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            conn = New MySqlConnection(cstring)
            conn.Open()
            Dim sql As String = "UPDATE customer set custName ='" & txtCustName.Text & "', custAddress =  '" & txtCustAdd.Text & "', custPhone = '" & txtCustPhone.Text & "'WHERE custID = '" & txtSearch.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            Dim a As Integer = cmd.ExecuteNonQuery()
            If a <> 0 Then
                MessageBox.Show("Customer Updated Successfully!.", "Admin")
                txtCustName.Clear()
                txtCustAdd.Clear()
                txtCustPhone.Clear()
                txtSearch.Clear()
                Read()

            Else
                MessageBox.Show("Error Occured, Not Updated", "Admin")
                txtCustName.Clear()
                txtCustAdd.Clear()
                txtCustPhone.Clear()
                txtSearch.Clear()
                Read()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            conn = New MySqlConnection(cstring)
            conn.Open()
            Dim sql As String = "DELETE FROM customer WHERE custID = '" & txtSearch.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            Dim a As Integer = cmd.ExecuteNonQuery()
            If a <> 0 Then
                MessageBox.Show("Deleted Successfully!.", "Admin")
                txtCustName.Clear()
                txtCustAdd.Clear()
                txtCustPhone.Clear()
                txtSearch.Clear()
                Read()

            Else
                MessageBox.Show("Error Occured, Not Deleted", "Admin")
                txtCustName.Clear()
                txtCustAdd.Clear()
                txtCustPhone.Clear()
                txtSearch.Clear()
                Read()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Dashboard.Show()

    End Sub

    Private Sub lstRead_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRead.SelectedIndexChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtCustAdd_TextChanged(sender As Object, e As EventArgs) Handles txtCustAdd.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtCustName_TextChanged(sender As Object, e As EventArgs) Handles txtCustName.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtCustPhone_TextChanged(sender As Object, e As EventArgs) Handles txtCustPhone.TextChanged

    End Sub
End Class