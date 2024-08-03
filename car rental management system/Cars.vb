Imports MySql.Data.MySqlClient

Public Class Cars
    Dim conn As MySqlConnection
    Dim cstring As String = "Data Source = Localhost; User ID = root; Database = crudvb"
    Dim cmd As MySqlCommand
    Dim ds As DataSet
    Dim da As MySqlDataAdapter
    Dim itemcoll(100) As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Read()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            conn = New MySqlConnection(cstring)
            conn.Open()
            Dim sql As String = "INSERT INTO cars(brand,year,color,fuel,price,availability) values ('" & txtBrand.Text & "', '" & txtYear.Text & "', '" & txtColor.Text & "','" & txtFuel.Text & "','" & txtPrice.Text & "','" & cbAvailable.SelectedItem.ToString & "') "
            cmd = New MySqlCommand(sql, conn)
            Dim a As Integer = cmd.ExecuteNonQuery()
            If a <> 0 Then
                MessageBox.Show("New Car Registered Successfully!.", "Admin")
                txtYear.Clear()
                txtPrice.Clear()
                txtColor.Clear()
                txtBrand.Clear()
                txtFuel.Clear()
                txtSearch.Clear()
                Read()

            Else
                MessageBox.Show("Error Occured, Not Registered", "Admin")
                txtYear.Clear()
                txtPrice.Clear()
                txtColor.Clear()
                txtBrand.Clear()
                txtFuel.Clear()
                txtSearch.Clear()
                Read()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            conn = New MySqlConnection(cstring)
            conn.Open()
            Dim sql As String = " UPDATE cars SET brand = '" & txtBrand.Text & "', year = '" & txtYear.Text & "', color = '" & txtColor.Text & "', fuel = '" & txtFuel.Text & "', price = '" & txtPrice.Text & "', availability = '" & cbAvailable.SelectedItem.ToString & "' WHERE id = '" & txtSearch.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            Dim a As Integer = cmd.ExecuteNonQuery()
            If a <> 0 Then
                MessageBox.Show("Updated Successfully!.", "Admin")
                txtYear.Clear()
                txtPrice.Clear()
                txtColor.Clear()
                txtBrand.Clear()
                txtFuel.Clear()
                txtSearch.Clear()
                Read()

            Else
                MessageBox.Show("Error Occured, Not Updated", "Admin")
                txtYear.Clear()
                txtPrice.Clear()
                txtColor.Clear()
                txtBrand.Clear()
                txtFuel.Clear()
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
            Dim sql As String = "DELETE FROM cars WHERE id = '" & txtSearch.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            Dim a As Integer = cmd.ExecuteNonQuery()
            If a <> 0 Then
                MessageBox.Show("Deleted Successfully!.", "Admin")
                txtYear.Clear()
                txtPrice.Clear()
                txtColor.Clear()
                txtBrand.Clear()
                txtFuel.Clear()
                txtSearch.Clear()
                Read()

            Else
                MessageBox.Show("Error Occured, Not Deleted", "Admin")
                txtYear.Clear()
                txtPrice.Clear()
                txtColor.Clear()
                txtBrand.Clear()
                txtFuel.Clear()
                txtSearch.Clear()
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
            Dim sql As String = "SELECT * FROM cars"
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Dashboard.Show()


    End Sub
End Class
