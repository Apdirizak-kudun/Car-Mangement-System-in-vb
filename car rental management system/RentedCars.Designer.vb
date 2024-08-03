<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentedCars
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstRead = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbID = New System.Windows.Forms.ComboBox()
        Me.cbName = New System.Windows.Forms.ComboBox()
        Me.cbAddress = New System.Windows.Forms.ComboBox()
        Me.cbBrand = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbColor = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbFuel = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbPrice = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbAvail = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.cbPhone = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Car Brand"
        Me.ColumnHeader8.Width = 90
        '
        'lstRead
        '
        Me.lstRead.BackColor = System.Drawing.Color.Chartreuse
        Me.lstRead.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader4, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader1})
        Me.lstRead.HideSelection = False
        Me.lstRead.Location = New System.Drawing.Point(16, 337)
        Me.lstRead.Margin = New System.Windows.Forms.Padding(4)
        Me.lstRead.Name = "lstRead"
        Me.lstRead.Size = New System.Drawing.Size(1223, 260)
        Me.lstRead.TabIndex = 39
        Me.lstRead.UseCompatibleStateImageBehavior = False
        Me.lstRead.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "S/No"
        Me.ColumnHeader2.Width = 48
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cust ID"
        Me.ColumnHeader3.Width = 76
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Cust Name"
        Me.ColumnHeader5.Width = 102
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Cust Address"
        Me.ColumnHeader6.Width = 97
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Cust Phone"
        Me.ColumnHeader7.Width = 92
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Color"
        Me.ColumnHeader4.Width = 52
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Fuel Type"
        Me.ColumnHeader9.Width = 98
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Price"
        Me.ColumnHeader10.Width = 62
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Availability"
        Me.ColumnHeader11.Width = 84
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Rent Date"
        Me.ColumnHeader12.Width = 129
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Retrun Date"
        Me.ColumnHeader1.Width = 102
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Black
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(749, 608)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(235, 47)
        Me.btnCancel.TabIndex = 35
        Me.btnCancel.Text = "Back To Home"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(1219, 278)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(67, 34)
        Me.txtSearch.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(1109, 279)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 29)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Search"
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.Color.Black
        Me.btnInsert.Location = New System.Drawing.Point(468, 608)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(224, 47)
        Me.btnInsert.TabIndex = 24
        Me.btnInsert.Text = "Rent Now"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(11, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 29)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Cust ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(448, -5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 67)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Car Rent"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(152, 101)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 29)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Cust Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(309, 101)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 29)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Cust Address"
        '
        'cbID
        '
        Me.cbID.FormattingEnabled = True
        Me.cbID.Location = New System.Drawing.Point(16, 148)
        Me.cbID.Margin = New System.Windows.Forms.Padding(4)
        Me.cbID.Name = "cbID"
        Me.cbID.Size = New System.Drawing.Size(124, 24)
        Me.cbID.TabIndex = 42
        '
        'cbName
        '
        Me.cbName.FormattingEnabled = True
        Me.cbName.Location = New System.Drawing.Point(160, 148)
        Me.cbName.Margin = New System.Windows.Forms.Padding(4)
        Me.cbName.Name = "cbName"
        Me.cbName.Size = New System.Drawing.Size(143, 24)
        Me.cbName.TabIndex = 43
        '
        'cbAddress
        '
        Me.cbAddress.FormattingEnabled = True
        Me.cbAddress.Location = New System.Drawing.Point(319, 148)
        Me.cbAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAddress.Name = "cbAddress"
        Me.cbAddress.Size = New System.Drawing.Size(172, 24)
        Me.cbAddress.TabIndex = 44
        '
        'cbBrand
        '
        Me.cbBrand.FormattingEnabled = True
        Me.cbBrand.Location = New System.Drawing.Point(724, 148)
        Me.cbBrand.Margin = New System.Windows.Forms.Padding(4)
        Me.cbBrand.Name = "cbBrand"
        Me.cbBrand.Size = New System.Drawing.Size(172, 24)
        Me.cbBrand.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(719, 101)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 29)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Car Brand"
        '
        'cbColor
        '
        Me.cbColor.FormattingEnabled = True
        Me.cbColor.Location = New System.Drawing.Point(920, 148)
        Me.cbColor.Margin = New System.Windows.Forms.Padding(4)
        Me.cbColor.Name = "cbColor"
        Me.cbColor.Size = New System.Drawing.Size(172, 24)
        Me.cbColor.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(915, 101)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 29)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Car Color"
        '
        'cbFuel
        '
        Me.cbFuel.FormattingEnabled = True
        Me.cbFuel.Location = New System.Drawing.Point(1113, 148)
        Me.cbFuel.Margin = New System.Windows.Forms.Padding(4)
        Me.cbFuel.Name = "cbFuel"
        Me.cbFuel.Size = New System.Drawing.Size(172, 24)
        Me.cbFuel.TabIndex = 50
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(1108, 101)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 29)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Fuel Type"
        '
        'cbPrice
        '
        Me.cbPrice.FormattingEnabled = True
        Me.cbPrice.Location = New System.Drawing.Point(16, 278)
        Me.cbPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPrice.Name = "cbPrice"
        Me.cbPrice.Size = New System.Drawing.Size(172, 24)
        Me.cbPrice.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(38, 232)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 29)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Car Price"
        '
        'cbAvail
        '
        Me.cbAvail.FormattingEnabled = True
        Me.cbAvail.Location = New System.Drawing.Point(220, 278)
        Me.cbAvail.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAvail.Name = "cbAvail"
        Me.cbAvail.Size = New System.Drawing.Size(172, 24)
        Me.cbAvail.TabIndex = 54
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(237, 232)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 29)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Availability"
        '
        'RentDate
        '
        Me.RentDate.Location = New System.Drawing.Point(415, 278)
        Me.RentDate.Margin = New System.Windows.Forms.Padding(4)
        Me.RentDate.Name = "RentDate"
        Me.RentDate.Size = New System.Drawing.Size(307, 22)
        Me.RentDate.TabIndex = 56
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(463, 232)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 29)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Rent Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(794, 232)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(151, 29)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Return Date"
        '
        'ReturnDate
        '
        Me.ReturnDate.Location = New System.Drawing.Point(749, 279)
        Me.ReturnDate.Margin = New System.Windows.Forms.Padding(4)
        Me.ReturnDate.Name = "ReturnDate"
        Me.ReturnDate.Size = New System.Drawing.Size(319, 22)
        Me.ReturnDate.TabIndex = 59
        '
        'cbPhone
        '
        Me.cbPhone.FormattingEnabled = True
        Me.cbPhone.Location = New System.Drawing.Point(519, 148)
        Me.cbPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPhone.Name = "cbPhone"
        Me.cbPhone.Size = New System.Drawing.Size(172, 24)
        Me.cbPhone.TabIndex = 61
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(513, 101)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 29)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Cust Phone"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(549, 304)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(204, 29)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = " list of Rent Car"
        '
        'RentedCars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1328, 667)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbPhone)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ReturnDate)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.RentDate)
        Me.Controls.Add(Me.cbAvail)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbPrice)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbFuel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbColor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbBrand)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbAddress)
        Me.Controls.Add(Me.cbName)
        Me.Controls.Add(Me.cbID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstRead)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RentedCars"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RentedCars"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents lstRead As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbID As ComboBox
    Friend WithEvents cbName As ComboBox
    Friend WithEvents cbAddress As ComboBox
    Friend WithEvents cbBrand As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbColor As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbFuel As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbPrice As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbAvail As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents RentDate As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ReturnDate As DateTimePicker
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents cbPhone As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
