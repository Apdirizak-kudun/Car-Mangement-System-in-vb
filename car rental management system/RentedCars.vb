Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class RentedCars
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim cstring As String = "Data Source = localhost; User ID = root; Database = crudvb"
    Dim ds As DataSet
    Dim da As MySqlDataAdapter
    Dim itemcoll(100) As String

    Private Sub RentedCars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCustomerComboBox()
        PopulateCarComboBox()
        Read()
    End Sub

    Private Sub PopulateCustomerComboBox()
        cbName.Items.Clear()

        Try
            conn = New MySqlConnection(cstring)
            conn.Open()

            ' Retrieve the distinct customer names from the database
            Dim queryCustName As String = "SELECT DISTINCT custName FROM customer"
            cmd = New MySqlCommand(queryCustName, conn)
            Dim readerCustName As MySqlDataReader = cmd.ExecuteReader()

            While readerCustName.Read()
                Dim custName As String = readerCustName("custName").ToString()
                cbName.Items.Add(custName)
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

    Private Sub cbName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbName.SelectedIndexChanged
        FetchDataFromDatabase()
    End Sub

    Private Sub FetchDataFromDatabase()
        Dim selectedCustName As String = cbName.SelectedItem.ToString()

        Try
            conn = New MySqlConnection(cstring)
            conn.Open()

            ' Retrieve the data for the selected customer name
            Dim queryData As String = "SELECT custID, custAddress, custPhone FROM customer WHERE custName = @CustName"
            cmd = New MySqlCommand(queryData, conn)
            cmd.Parameters.AddWithValue("@CustName", selectedCustName)

            Dim readerData As MySqlDataReader = cmd.ExecuteReader()

            ' Check if there are rows returned
            If readerData.Read() Then
                ' Retrieve the values from the row
                Dim custAddress As String = readerData("custAddress").ToString()
                Dim custID As String = readerData("custID").ToString()
                Dim custPhone As Decimal = readerData.GetDecimal("custPhone")

                ' Set the values for the other combo boxes
                cbID.Text = custID
                cbAddress.Text = custAddress
                cbPhone.Text = custPhone.ToString()
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

    Private Sub PopulateCarComboBox()
        cbBrand.Items.Clear()

        Try
            conn = New MySqlConnection(cstring)
            conn.Open()

            ' Retrieve the distinct car brands from the database
            Dim queryCarBrand As String = "SELECT DISTINCT brand FROM cars"
            cmd = New MySqlCommand(queryCarBrand, conn)
            Dim readerCarBrand As MySqlDataReader = cmd.ExecuteReader()

            While readerCarBrand.Read()
                Dim brand As String = readerCarBrand("brand").ToString()
                cbBrand.Items.Add(brand)
            End While

            readerCarBrand.Close()
        Catch ex As Exception
            ' Handle exceptions here
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    Private Sub cbBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBrand.SelectedIndexChanged
        FetchCarDataFromDatabase()
    End Sub

    Private Sub FetchCarDataFromDatabase()
        Dim selectedBrand As String = cbBrand.SelectedItem.ToString()

        Try
            conn = New MySqlConnection(cstring)
            conn.Open()

            ' Retrieve the data for the selected car brand
            Dim queryData As String = "SELECT color, fuel, price, availability FROM cars WHERE brand = @Brand"
            cmd = New MySqlCommand(queryData, conn)
            cmd.Parameters.AddWithValue("@Brand", selectedBrand)

            Dim readerData As MySqlDataReader = cmd.ExecuteReader()

            ' Check if there are rows returned
            If readerData.Read() Then
                ' Retrieve the values from the row
                Dim color As String = readerData("color").ToString()
                Dim fuel As String = readerData("fuel").ToString()
                Dim price As Decimal = readerData.GetDecimal("price")
                Dim availability As String = readerData("availability").ToString()

                ' Set the values for the other combo boxes
                cbColor.Text = color
                cbFuel.Text = fuel
                cbPrice.Text = price.ToString()
                cbAvail.Text = availability
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

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            conn = New MySqlConnection(cstring)
            conn.Open()

            ' Retrieve the necessary data from the "customers" and "cars" tables
            Dim selectQuery As String = "SELECT cust.custID, cust.custName, cust.custAddress, cust.custPhone, cars.brand, cars.color, cars.fuel, cars.price, cars.availability " &
            "FROM customer cust " &
            "JOIN cars ON cust.custID = cars.custID"
            cmd = New MySqlCommand(selectQuery, conn)

            ' Execute the select query and retrieve the data
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Retrieve the values from the reader
                Dim custID As Integer = reader.GetInt32(0)
                Dim custName As String = reader.GetString(1)
                Dim custAddress As String = reader.GetString(2)
                Dim custPhone As String = reader.GetString(3)
                Dim carBrand As String = reader.GetString(4)
                Dim carColor As String = reader.GetString(5)
                Dim fuel As String = reader.GetString(6)
                Dim carPrice As Decimal = reader.GetDecimal(7)
                Dim availability As String = reader.GetString(8)

                ' Close the reader after retrieving the values
                reader.Close()

                If cbAvail.Text = "Yes" Then
                    ' Update the availability to "NO" in the "cars" table
                    Dim updateQuery As String = "UPDATE cars SET availability = 'NO' WHERE brand = '" & cbBrand.SelectedItem.ToString & "'"
                    cmd = New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@CarBrand", carBrand)
                    cmd.ExecuteNonQuery()
                End If

                ' Insert the retrieved data into the "rents" table
                Dim insertQuery As String = "INSERT INTO rents (custID, custName, custAddress, custPhone, carBrand, carColor, fuel, carPrice, availability,rentDate,returnDate) " &
                    "VALUES ('" & cbID.Text & "', '" & cbName.SelectedItem.ToString & "', '" & cbAddress.Text & "', '" & cbPhone.Text & "', '" & cbBrand.SelectedItem.ToString & "', '" & cbColor.Text & "', '" & cbFuel.Text & "','" & cbPrice.Text & "', '" & cbAvail.Text & "','" & RentDate.Value.ToString("yyyy-MM-dd HH:mm:ss") & "','" & ReturnDate.Value.ToString("yyyy-MM-dd HH:mm:ss") & "')"
                cmd = New MySqlCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@CustID", custID)
                cmd.Parameters.AddWithValue("@CustName", custName)
                cmd.Parameters.AddWithValue("@CustAddress", custAddress)
                cmd.Parameters.AddWithValue("@CustPhone", custPhone)
                cmd.Parameters.AddWithValue("@CarBrand", carBrand)
                cmd.Parameters.AddWithValue("@CarColor", carColor)
                cmd.Parameters.AddWithValue("@Fuel", fuel)
                cmd.Parameters.AddWithValue("@CarPrice", carPrice)
                cmd.Parameters.AddWithValue("@Availability", availability)

                ' Execute the insert command
                cmd.ExecuteNonQuery()

                ' Display a success message
                MessageBox.Show("The Car is Rented successfully.")
                Read()
            Else
                reader.Close()
                MessageBox.Show("Error Occurred: 'customers' and 'cars' tables.")
                Read()
            End If

        Catch ex As Exception
            ' Handle exceptions here
            MessageBox.Show("Error: " & ex.Message)

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
            Dim sql As String = "SELECT * FROM rents"
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Try
            conn = New MySqlConnection(cstring)
            conn.Open()
            Dim sql As String = "DELETE FROM rents WHERE id = '" & txtSearch.Text & "' "
            cmd = New MySqlCommand(sql, conn)
            Dim a As Integer = cmd.ExecuteNonQuery()
            If a <> 0 Then
                MessageBox.Show("Deleted Successfully!.", "Admin")

                Read()

            Else
                MessageBox.Show("Error Occured, Not Deleted", "Admin")
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
End Class