<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtSelect = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.btnRetrive = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomertableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_masterDataSet = New Application.customer_masterDataSet()
        Me.Customer_tableTableAdapter = New Application.customer_masterDataSetTableAdapters.customer_tableTableAdapter()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomertableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_masterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(111, 56)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 22)
        Me.txtFirstName.TabIndex = 0
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(111, 84)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 22)
        Me.txtLastName.TabIndex = 1
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(111, 169)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(200, 85)
        Me.txtAddress.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(111, 112)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 4
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(23, 62)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(69, 16)
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.Text = "FirstName"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(23, 90)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(69, 16)
        Me.lblLastName.TabIndex = 6
        Me.lblLastName.Text = "LastName"
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Location = New System.Drawing.Point(23, 118)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(75, 16)
        Me.lblDateOfBirth.TabIndex = 7
        Me.lblDateOfBirth.Text = "DateOfBirth"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(23, 147)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(52, 16)
        Me.lblGender.TabIndex = 8
        Me.lblGender.Text = "Gender"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(23, 175)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(58, 16)
        Me.lblAddress.TabIndex = 9
        Me.lblAddress.Text = "Address"
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(374, 410)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(113, 58)
        Me.btnInsert.TabIndex = 11
        Me.btnInsert.Text = "Save/Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(715, 410)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(96, 58)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(989, 410)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 58)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtSelect
        '
        Me.txtSelect.Location = New System.Drawing.Point(111, 27)
        Me.txtSelect.Name = "txtSelect"
        Me.txtSelect.Size = New System.Drawing.Size(100, 22)
        Me.txtSelect.TabIndex = 14
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(57, 30)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(18, 16)
        Me.lblId.TabIndex = 15
        Me.lblId.Text = "Id"
        '
        'btnRetrive
        '
        Me.btnRetrive.Location = New System.Drawing.Point(217, 24)
        Me.btnRetrive.Name = "btnRetrive"
        Me.btnRetrive.Size = New System.Drawing.Size(99, 28)
        Me.btnRetrive.TabIndex = 16
        Me.btnRetrive.Text = "Retrive"
        Me.btnRetrive.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomertableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(328, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(786, 370)
        Me.DataGridView1.TabIndex = 17
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 125
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.Width = 125
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.Width = 125
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        Me.DateOfBirthDataGridViewTextBoxColumn.Width = 125
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.Width = 125
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 125
        '
        'CustomertableBindingSource
        '
        Me.CustomertableBindingSource.DataMember = "customer_table"
        Me.CustomertableBindingSource.DataSource = Me.Customer_masterDataSet
        '
        'Customer_masterDataSet
        '
        Me.Customer_masterDataSet.DataSetName = "customer_masterDataSet"
        Me.Customer_masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Customer_tableTableAdapter
        '
        Me.Customer_tableTableAdapter.ClearBeforeFill = True
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.cmbGender.Location = New System.Drawing.Point(111, 139)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(141, 24)
        Me.cmbGender.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 501)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnRetrive)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtSelect)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblDateOfBirth)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerFrm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomertableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_masterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtSelect As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents btnRetrive As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Customer_masterDataSet As customer_masterDataSet
    Friend WithEvents CustomertableBindingSource As BindingSource
    Friend WithEvents Customer_tableTableAdapter As customer_masterDataSetTableAdapters.customer_tableTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cmbGender As ComboBox
End Class
