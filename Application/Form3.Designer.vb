<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblFrm3Fname = New System.Windows.Forms.Label()
        Me.lblFrm3Lname = New System.Windows.Forms.Label()
        Me.lblFrm3DOB = New System.Windows.Forms.Label()
        Me.lblFrm3Gender = New System.Windows.Forms.Label()
        Me.lblFrm3Address = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalAmountForm3 = New System.Windows.Forms.Label()
        Me.lblFrm3CustomerId = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFrm3Date = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(757, 56)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(24, 16)
        Me.lblId.TabIndex = 33
        Me.lblId.Text = "Id :"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(35, 99)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(69, 16)
        Me.lblFirstName.TabIndex = 23
        Me.lblFirstName.Text = "FirstName"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(35, 127)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(69, 16)
        Me.lblLastName.TabIndex = 24
        Me.lblLastName.Text = "LastName"
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Location = New System.Drawing.Point(35, 155)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(75, 16)
        Me.lblDateOfBirth.TabIndex = 25
        Me.lblDateOfBirth.Text = "DateOfBirth"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(35, 184)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(52, 16)
        Me.lblGender.TabIndex = 26
        Me.lblGender.Text = "Gender"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(35, 212)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(58, 16)
        Me.lblAddress.TabIndex = 27
        Me.lblAddress.Text = "Address"
        '
        'lblFrm3Fname
        '
        Me.lblFrm3Fname.AutoSize = True
        Me.lblFrm3Fname.Location = New System.Drawing.Point(165, 99)
        Me.lblFrm3Fname.Name = "lblFrm3Fname"
        Me.lblFrm3Fname.Size = New System.Drawing.Size(48, 16)
        Me.lblFrm3Fname.TabIndex = 42
        Me.lblFrm3Fname.Text = "Label1"
        '
        'lblFrm3Lname
        '
        Me.lblFrm3Lname.AutoSize = True
        Me.lblFrm3Lname.Location = New System.Drawing.Point(165, 127)
        Me.lblFrm3Lname.Name = "lblFrm3Lname"
        Me.lblFrm3Lname.Size = New System.Drawing.Size(48, 16)
        Me.lblFrm3Lname.TabIndex = 43
        Me.lblFrm3Lname.Text = "Label2"
        '
        'lblFrm3DOB
        '
        Me.lblFrm3DOB.AutoSize = True
        Me.lblFrm3DOB.Location = New System.Drawing.Point(165, 155)
        Me.lblFrm3DOB.Name = "lblFrm3DOB"
        Me.lblFrm3DOB.Size = New System.Drawing.Size(48, 16)
        Me.lblFrm3DOB.TabIndex = 44
        Me.lblFrm3DOB.Text = "Label3"
        '
        'lblFrm3Gender
        '
        Me.lblFrm3Gender.AutoSize = True
        Me.lblFrm3Gender.Location = New System.Drawing.Point(165, 184)
        Me.lblFrm3Gender.Name = "lblFrm3Gender"
        Me.lblFrm3Gender.Size = New System.Drawing.Size(48, 16)
        Me.lblFrm3Gender.TabIndex = 45
        Me.lblFrm3Gender.Text = "Label4"
        '
        'lblFrm3Address
        '
        Me.lblFrm3Address.AutoSize = True
        Me.lblFrm3Address.Location = New System.Drawing.Point(165, 212)
        Me.lblFrm3Address.Name = "lblFrm3Address"
        Me.lblFrm3Address.Size = New System.Drawing.Size(48, 16)
        Me.lblFrm3Address.TabIndex = 46
        Me.lblFrm3Address.Text = "Label5"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(323, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(623, 319)
        Me.DataGridView1.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(639, 463)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Total Amount"
        '
        'lblTotalAmountForm3
        '
        Me.lblTotalAmountForm3.AutoSize = True
        Me.lblTotalAmountForm3.Location = New System.Drawing.Point(801, 463)
        Me.lblTotalAmountForm3.Name = "lblTotalAmountForm3"
        Me.lblTotalAmountForm3.Size = New System.Drawing.Size(79, 16)
        Me.lblTotalAmountForm3.TabIndex = 51
        Me.lblTotalAmountForm3.Text = "total amount"
        Me.lblTotalAmountForm3.UseMnemonic = False
        '
        'lblFrm3CustomerId
        '
        Me.lblFrm3CustomerId.AutoSize = True
        Me.lblFrm3CustomerId.Location = New System.Drawing.Point(796, 56)
        Me.lblFrm3CustomerId.Name = "lblFrm3CustomerId"
        Me.lblFrm3CustomerId.Size = New System.Drawing.Size(75, 16)
        Me.lblFrm3CustomerId.TabIndex = 52
        Me.lblFrm3CustomerId.Text = "CustomerId"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(742, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Date:"
        '
        'lblFrm3Date
        '
        Me.lblFrm3Date.AutoSize = True
        Me.lblFrm3Date.Location = New System.Drawing.Point(799, 27)
        Me.lblFrm3Date.Name = "lblFrm3Date"
        Me.lblFrm3Date.Size = New System.Drawing.Size(80, 16)
        Me.lblFrm3Date.TabIndex = 54
        Me.lblFrm3Date.Text = "lblFrm3Date"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 529)
        Me.Controls.Add(Me.lblFrm3Date)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFrm3CustomerId)
        Me.Controls.Add(Me.lblTotalAmountForm3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblFrm3Address)
        Me.Controls.Add(Me.lblFrm3Gender)
        Me.Controls.Add(Me.lblFrm3DOB)
        Me.Controls.Add(Me.lblFrm3Lname)
        Me.Controls.Add(Me.lblFrm3Fname)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblDateOfBirth)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblId As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblFrm3Fname As Label
    Friend WithEvents lblFrm3Lname As Label
    Friend WithEvents lblFrm3DOB As Label
    Friend WithEvents lblFrm3Gender As Label
    Friend WithEvents lblFrm3Address As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalAmountForm3 As Label
    Friend WithEvents lblFrm3CustomerId As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFrm3Date As Label
End Class
