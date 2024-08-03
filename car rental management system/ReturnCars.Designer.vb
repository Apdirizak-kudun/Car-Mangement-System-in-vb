<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnCars
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCustName = New System.Windows.Forms.ComboBox()
        Me.returnDat = New System.Windows.Forms.DateTimePicker()
        Me.txtFine = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbCarBrand = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbAvail = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRetrun = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lstRead = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDelay = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbCarPrice = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbDamage = New System.Windows.Forms.ComboBox()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(463, -1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 67)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Car Return"
        '
        'cbCustName
        '
        Me.cbCustName.FormattingEnabled = True
        Me.cbCustName.Location = New System.Drawing.Point(51, 160)
        Me.cbCustName.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCustName.Name = "cbCustName"
        Me.cbCustName.Size = New System.Drawing.Size(195, 24)
        Me.cbCustName.TabIndex = 23
        '
        'returnDat
        '
        Me.returnDat.Location = New System.Drawing.Point(1004, 164)
        Me.returnDat.Margin = New System.Windows.Forms.Padding(4)
        Me.returnDat.Name = "returnDat"
        Me.returnDat.Size = New System.Drawing.Size(279, 22)
        Me.returnDat.TabIndex = 26
        '
        'txtFine
        '
        Me.txtFine.Location = New System.Drawing.Point(792, 247)
        Me.txtFine.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFine.Name = "txtFine"
        Me.txtFine.Size = New System.Drawing.Size(195, 22)
        Me.txtFine.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(45, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 25)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Customer Name"
        '
        'cbCarBrand
        '
        Me.cbCarBrand.FormattingEnabled = True
        Me.cbCarBrand.Location = New System.Drawing.Point(301, 160)
        Me.cbCarBrand.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCarBrand.Name = "cbCarBrand"
        Me.cbCarBrand.Size = New System.Drawing.Size(195, 24)
        Me.cbCarBrand.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(296, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 25)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Car Brand"
        '
        'cbAvail
        '
        Me.cbAvail.FormattingEnabled = True
        Me.cbAvail.Location = New System.Drawing.Point(547, 160)
        Me.cbAvail.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAvail.Name = "cbAvail"
        Me.cbAvail.Size = New System.Drawing.Size(195, 24)
        Me.cbAvail.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(541, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 25)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Availability"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(45, 217)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 25)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "How Many Days"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(787, 215)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 25)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Fine"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(1001, 132)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 25)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Return Date"
        '
        'btnRetrun
        '
        Me.btnRetrun.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRetrun.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetrun.ForeColor = System.Drawing.Color.White
        Me.btnRetrun.Location = New System.Drawing.Point(371, 610)
        Me.btnRetrun.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRetrun.Name = "btnRetrun"
        Me.btnRetrun.Size = New System.Drawing.Size(171, 42)
        Me.btnRetrun.TabIndex = 39
        Me.btnRetrun.Text = "Return"
        Me.btnRetrun.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(608, 610)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(171, 42)
        Me.btnBack.TabIndex = 40
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lstRead
        '
        Me.lstRead.BackColor = System.Drawing.Color.Chartreuse
        Me.lstRead.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lstRead.HideSelection = False
        Me.lstRead.Location = New System.Drawing.Point(16, 316)
        Me.lstRead.Margin = New System.Windows.Forms.Padding(4)
        Me.lstRead.Name = "lstRead"
        Me.lstRead.Size = New System.Drawing.Size(1267, 260)
        Me.lstRead.TabIndex = 41
        Me.lstRead.UseCompatibleStateImageBehavior = False
        Me.lstRead.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "S/No"
        Me.ColumnHeader1.Width = 48
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Customer Name"
        Me.ColumnHeader2.Width = 113
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Car Brand"
        Me.ColumnHeader3.Width = 112
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Availability"
        Me.ColumnHeader5.Width = 106
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Return Date"
        Me.ColumnHeader4.Width = 103
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Days"
        Me.ColumnHeader6.Width = 87
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Damage"
        Me.ColumnHeader7.Width = 94
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Delay"
        Me.ColumnHeader8.Width = 78
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Fine"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Total Cost"
        Me.ColumnHeader10.Width = 84
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(541, 215)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 25)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Delay"
        '
        'txtDelay
        '
        Me.txtDelay.Location = New System.Drawing.Point(547, 247)
        Me.txtDelay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDelay.Name = "txtDelay"
        Me.txtDelay.Size = New System.Drawing.Size(195, 22)
        Me.txtDelay.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(768, 132)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 25)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Car Price"
        '
        'cbCarPrice
        '
        Me.cbCarPrice.FormattingEnabled = True
        Me.cbCarPrice.Location = New System.Drawing.Point(773, 160)
        Me.cbCarPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCarPrice.Name = "cbCarPrice"
        Me.cbCarPrice.Size = New System.Drawing.Size(195, 24)
        Me.cbCarPrice.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(296, 217)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 25)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Damage"
        '
        'cbDamage
        '
        Me.cbDamage.FormattingEnabled = True
        Me.cbDamage.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbDamage.Location = New System.Drawing.Point(301, 247)
        Me.cbDamage.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDamage.Name = "cbDamage"
        Me.cbDamage.Size = New System.Drawing.Size(195, 24)
        Me.cbDamage.TabIndex = 47
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(51, 249)
        Me.txtDays.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(195, 22)
        Me.txtDays.TabIndex = 49
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(541, 283)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(228, 29)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = " list of Return Car"
        '
        'ReturnCars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1295, 667)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbDamage)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbCarPrice)
        Me.Controls.Add(Me.txtDelay)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lstRead)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRetrun)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbAvail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbCarBrand)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFine)
        Me.Controls.Add(Me.returnDat)
        Me.Controls.Add(Me.cbCustName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ReturnCars"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReturnCars"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbCustName As ComboBox
    Friend WithEvents returnDat As DateTimePicker
    Friend WithEvents txtFine As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbCarBrand As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbAvail As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnRetrun As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lstRead As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDelay As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbCarPrice As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbDamage As ComboBox
    Friend WithEvents txtDays As TextBox
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents Label14 As Label
End Class
