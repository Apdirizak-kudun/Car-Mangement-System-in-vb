Imports MySql.Data.MySqlClient
Imports System.Globalization


Public Class ReturnCars
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim cmd2 As MySqlCommand
    Dim cstring As String = "Data Source = localhost; User ID = root; Database = crudvb"
    Dim ds As DataSet
    Dim da As MySqlDataAdapter
    Dim itemcoll(100) As String
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dashboard.Show()

    End Sub

    Private Sub ReturnCars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCustomerComboBox()
        Read()

    End Sub

    Private Sub PopulateCustomerComboBox()
        cbCustName.Items.Clear()

        Try
            conn = New MySqlConnection(cstring)
            conn.Open()

            ' Retrieve the distinct customer names from the database
            Dim queryCustName As String = "SELECT DISTINCT custName FROM rents"
            cmd = New MySqlCommand(queryCustName, conn)
            Dim readerCustName As MySqlDataReader = cmd.ExecuteReader()

            While readerCustName.Read()
                Dim custName As String = readerCustName("custName").ToString()
                cbCustName.Items.Add(custName)
            End While

            readerCustName.Close()
        Catch ex As Exception
            ' Handle exceptions here
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    Private Sub cbCustName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCustName.SelectedIndexChanged
        FetchDataFromDatabase()
    End Sub

    Private Sub FetchDataFromDatabase()
        Dim selectedCustName As String = cbCustName.SelectedItem.ToString()

        Try
            conn = New MySqlConnection(cstring)
            conn.Open()

            ' Retrieve the data for the selected customer name
            Dim queryData As String = "SELECT carBrand, availability, carPrice FROM rents WHERE custName = @CustName"
            cmd = New MySqlCommand(queryData, conn)
            cmd.Parameters.AddWithValue("@CustName", selectedCustName)

            Dim readerData As MySqlDataReader = cmd.ExecuteReader()

            ' Check if there are rows returned
            If readerData.Read() Then
                ' Retrieve the values from the row
                Dim carBrand As String = readerData("carBrand").ToString()
                Dim availability As String = readerData("availability").ToString()
                Dim carPrice As Decimal = readerData.GetDecimal("carPrice")

                ' Set the values for the other combo boxes
                cbCarBrand.Text = carBrand
                cbAvail.Text = availability
                cbCarPrice.Text = carPrice.ToString()
            End If

            readerData.Close()
        Catch ex As Exception
            ' Handle exceptions here
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    Private Sub btnRetrun_Click(sender As Object, e As EventArgs) Handles btnRetrun.Click
        Try
            conn = New MySqlConnection(cstring)
            conn.Open()

            ' Perform the multiplication calculation
            Dim days As Integer = Integer.Parse(txtDays.Text)
            Dim delay As Integer = Integer.Parse(txtDelay.Text)
            Dim fine As Decimal = Decimal.Parse(txtFine.Text)
            Dim carPrice As Decimal = Decimal.Parse(cbCarPrice.Text)
            Dim totalCost As Decimal = (days * carPrice) + (delay * fine)

            ' Insert the data into the "tblreturn" table
            Dim sql As String = "INSERT INTO tblreturn(custName, carBrand, availability, returnDate, days, damage, delay, fine, totalCost) VALUES('" & cbCustName.SelectedItem.ToString & "','" & cbCarBrand.Text & "','" & cbAvail.Text & "','" & returnDat.Value.ToString("yyyy-MM-dd HH:mm:ss") & "','" & txtDays.Text & "','" & cbDamage.SelectedItem.ToString & "','" & txtDelay.Text & "','" & txtFine.Text & "','" & totalCost.ToString & "')"
            cmd = New MySqlCommand(sql, conn)

            ' Set the parameter values
            cmd.Parameters.AddWithValue("@CustName", cbCustName.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@CarBrand", cbCarBrand.Text)
            cmd.Parameters.AddWithValue("@Availability", cbAvail.Text)
            cmd.Parameters.AddWithValue("@ReturnDate", returnDat.Value.ToString("yyyy-MM-dd HH:mm:ss"))
            cmd.Parameters.AddWithValue("@Days", Integer.Parse(txtDays.Text))
            cmd.Parameters.AddWithValue("@Damage", cbDamage.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Delay", Integer.Parse(txtDelay.Text))
            cmd.Parameters.AddWithValue("@Fine", Decimal.Parse(txtFine.Text))
            cmd.Parameters.AddWithValue("@TotalCost", totalCost)

            ' Execute the command
            cmd.ExecuteNonQuery()

            ' Update the availability in the "cars" table if availability is "Yes"
            If cbAvail.Text = "Yes" Then
                Dim updateSql As String = "UPDATE cars SET availability = 'Yes' WHERE Brand = '" & cbCarBrand.Text & "'"
                Dim updateCmd As New MySqlCommand(updateSql, conn)
                updateCmd.Parameters.AddWithValue("@Brand", cbCarBrand.Text)
                updateCmd.ExecuteNonQuery()
            End If

            ' Show a success message
            MessageBox.Show("Car Returned successfully.")
            Read()

        Catch ex As Exception
            ' Handle exceptions here
            MessageBox.Show("Error: " & ex.Message)
            Read()

        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub
    Public Sub Read()
        Try
            lstRead.Items.Clear()
            conn = New MySqlConnection(cstring)
            conn.ConnectionString += ";Convert Zero Datetime=True"
            conn.Open()
            Dim sql As String = "SELECT * FROM tblreturn"
            cmd = New MySqlCommand(sql, conn)
            ds = New DataSet
            da = New MySqlDataAdapter(cmd)
            da.Fill(ds, "Tables")


            For r = 0 To ds.Tables(0).Rows.Count - 1
                Dim itemcoll(ds.Tables(0).Columns.Count - 1) As String
                For c = 0 To ds.Tables(0).Columns.Count - 1
                    itemcoll(c) = ds.Tables(0).Rows(r)(c).ToString()
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

    Private Sub txtDelay_TextChanged(sender As Object, e As EventArgs) Handles txtDelay.TextChanged

    End Sub
End Class