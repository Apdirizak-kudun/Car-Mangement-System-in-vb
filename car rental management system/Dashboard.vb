Public Class Dashboard
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        Dim Cars As New Cars()
        Cars.Read()
        Cars.Show()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Hide()
        Dim customers As New customers()
        customers.Read()
        customers.Show()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        admin.Show()


    End Sub

    Private Sub lblUser_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Dim RentedCars As New RentedCars()
        RentedCars.Read()
        RentedCars.Show()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Dim ReturnCars As New ReturnCars()
        'ReturnCars.Read()
        ReturnCars.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub
End Class