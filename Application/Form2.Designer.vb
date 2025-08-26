<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblMedName = New System.Windows.Forms.Label()
        Me.lblStockAvlb = New System.Windows.Forms.Label()
        Me.lblPricePS = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtMedName = New System.Windows.Forms.TextBox()
        Me.txtStockAvlb = New System.Windows.Forms.TextBox()
        Me.txtPricePS = New System.Windows.Forms.TextBox()
        Me.btnRetrieve = New System.Windows.Forms.Button()
        Me.btnSaveInsert = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Customer_masterDataSet = New Application.customer_masterDataSet()
        Me.CustomermasterDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dvgMedTable = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockAvailableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PricestripDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_master_medicine_table = New Application.customer_master_medicine_table()
        Me.Medicine_TableTableAdapter = New Application.customer_master_medicine_tableTableAdapters.medicine_TableTableAdapter()
        Me.txtMedUpdateId = New System.Windows.Forms.TextBox()
        Me.txtMedDeleteId = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.Customer_masterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomermasterDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgMedTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicineTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_master_medicine_table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(28, 44)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(18, 16)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Id"
        '
        'lblMedName
        '
        Me.lblMedName.AutoSize = True
        Me.lblMedName.Location = New System.Drawing.Point(28, 107)
        Me.lblMedName.Name = "lblMedName"
        Me.lblMedName.Size = New System.Drawing.Size(102, 16)
        Me.lblMedName.TabIndex = 1
        Me.lblMedName.Text = "Medicine Name"
        '
        'lblStockAvlb
        '
        Me.lblStockAvlb.AutoSize = True
        Me.lblStockAvlb.Location = New System.Drawing.Point(28, 181)
        Me.lblStockAvlb.Name = "lblStockAvlb"
        Me.lblStockAvlb.Size = New System.Drawing.Size(98, 16)
        Me.lblStockAvlb.TabIndex = 2
        Me.lblStockAvlb.Text = "StockAvailable"
        '
        'lblPricePS
        '
        Me.lblPricePS.AutoSize = True
        Me.lblPricePS.Location = New System.Drawing.Point(28, 254)
        Me.lblPricePS.Name = "lblPricePS"
        Me.lblPricePS.Size = New System.Drawing.Size(69, 16)
        Me.lblPricePS.TabIndex = 3
        Me.lblPricePS.Text = "Price/Strip"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(34, 440)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(85, 22)
        Me.txtId.TabIndex = 4
        '
        'txtMedName
        '
        Me.txtMedName.Location = New System.Drawing.Point(140, 107)
        Me.txtMedName.Name = "txtMedName"
        Me.txtMedName.Size = New System.Drawing.Size(100, 22)
        Me.txtMedName.TabIndex = 5
        '
        'txtStockAvlb
        '
        Me.txtStockAvlb.Location = New System.Drawing.Point(140, 178)
        Me.txtStockAvlb.Name = "txtStockAvlb"
        Me.txtStockAvlb.Size = New System.Drawing.Size(100, 22)
        Me.txtStockAvlb.TabIndex = 6
        '
        'txtPricePS
        '
        Me.txtPricePS.Location = New System.Drawing.Point(140, 251)
        Me.txtPricePS.Name = "txtPricePS"
        Me.txtPricePS.Size = New System.Drawing.Size(100, 22)
        Me.txtPricePS.TabIndex = 7
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Location = New System.Drawing.Point(34, 477)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(85, 51)
        Me.btnRetrieve.TabIndex = 8
        Me.btnRetrieve.Text = "Retrieve"
        Me.btnRetrieve.UseVisualStyleBackColor = True
        '
        'btnSaveInsert
        '
        Me.btnSaveInsert.Location = New System.Drawing.Point(84, 336)
        Me.btnSaveInsert.Name = "btnSaveInsert"
        Me.btnSaveInsert.Size = New System.Drawing.Size(100, 51)
        Me.btnSaveInsert.TabIndex = 9
        Me.btnSaveInsert.Text = "Save/Insert"
        Me.btnSaveInsert.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(270, 477)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(91, 51)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(517, 477)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(92, 51)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Customer_masterDataSet
        '
        Me.Customer_masterDataSet.DataSetName = "customer_masterDataSet"
        Me.Customer_masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomermasterDataSetBindingSource
        '
        Me.CustomermasterDataSetBindingSource.DataSource = Me.Customer_masterDataSet
        Me.CustomermasterDataSetBindingSource.Position = 0
        '
        'dvgMedTable
        '
        Me.dvgMedTable.AutoGenerateColumns = False
        Me.dvgMedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgMedTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.MedicineNameDataGridViewTextBoxColumn, Me.StockAvailableDataGridViewTextBoxColumn, Me.PricestripDataGridViewTextBoxColumn})
        Me.dvgMedTable.DataSource = Me.MedicineTableBindingSource
        Me.dvgMedTable.Location = New System.Drawing.Point(389, 41)
        Me.dvgMedTable.Name = "dvgMedTable"
        Me.dvgMedTable.RowHeadersWidth = 51
        Me.dvgMedTable.RowTemplate.Height = 24
        Me.dvgMedTable.Size = New System.Drawing.Size(635, 346)
        Me.dvgMedTable.TabIndex = 12
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 125
        '
        'MedicineNameDataGridViewTextBoxColumn
        '
        Me.MedicineNameDataGridViewTextBoxColumn.DataPropertyName = "Medicine Name"
        Me.MedicineNameDataGridViewTextBoxColumn.HeaderText = "Medicine Name"
        Me.MedicineNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MedicineNameDataGridViewTextBoxColumn.Name = "MedicineNameDataGridViewTextBoxColumn"
        Me.MedicineNameDataGridViewTextBoxColumn.Width = 125
        '
        'StockAvailableDataGridViewTextBoxColumn
        '
        Me.StockAvailableDataGridViewTextBoxColumn.DataPropertyName = "Stock Available"
        Me.StockAvailableDataGridViewTextBoxColumn.HeaderText = "Stock Available"
        Me.StockAvailableDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StockAvailableDataGridViewTextBoxColumn.Name = "StockAvailableDataGridViewTextBoxColumn"
        Me.StockAvailableDataGridViewTextBoxColumn.Width = 125
        '
        'PricestripDataGridViewTextBoxColumn
        '
        Me.PricestripDataGridViewTextBoxColumn.DataPropertyName = "Price/strip"
        Me.PricestripDataGridViewTextBoxColumn.HeaderText = "Price/strip"
        Me.PricestripDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PricestripDataGridViewTextBoxColumn.Name = "PricestripDataGridViewTextBoxColumn"
        Me.PricestripDataGridViewTextBoxColumn.Width = 125
        '
        'MedicineTableBindingSource
        '
        Me.MedicineTableBindingSource.DataMember = "medicine_Table"
        Me.MedicineTableBindingSource.DataSource = Me.Customer_master_medicine_table
        '
        'Customer_master_medicine_table
        '
        Me.Customer_master_medicine_table.DataSetName = "customer_master_medicine_table"
        Me.Customer_master_medicine_table.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Medicine_TableTableAdapter
        '
        Me.Medicine_TableTableAdapter.ClearBeforeFill = True
        '
        'txtMedUpdateId
        '
        Me.txtMedUpdateId.Location = New System.Drawing.Point(270, 440)
        Me.txtMedUpdateId.Name = "txtMedUpdateId"
        Me.txtMedUpdateId.Size = New System.Drawing.Size(91, 22)
        Me.txtMedUpdateId.TabIndex = 13
        '
        'txtMedDeleteId
        '
        Me.txtMedDeleteId.Location = New System.Drawing.Point(517, 440)
        Me.txtMedDeleteId.Name = "txtMedDeleteId"
        Me.txtMedDeleteId.Size = New System.Drawing.Size(92, 22)
        Me.txtMedDeleteId.TabIndex = 14
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(685, 456)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(115, 43)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear Text"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(227, 27)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1484, 733)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtMedDeleteId)
        Me.Controls.Add(Me.txtMedUpdateId)
        Me.Controls.Add(Me.dvgMedTable)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSaveInsert)
        Me.Controls.Add(Me.btnRetrieve)
        Me.Controls.Add(Me.txtPricePS)
        Me.Controls.Add(Me.txtStockAvlb)
        Me.Controls.Add(Me.txtMedName)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblPricePS)
        Me.Controls.Add(Me.lblStockAvlb)
        Me.Controls.Add(Me.lblMedName)
        Me.Controls.Add(Me.lblId)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MedicineFrm"
        CType(Me.Customer_masterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomermasterDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgMedTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicineTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_master_medicine_table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblId As Label
    Friend WithEvents lblMedName As Label
    Friend WithEvents lblStockAvlb As Label
    Friend WithEvents lblPricePS As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtMedName As TextBox
    Friend WithEvents txtStockAvlb As TextBox
    Friend WithEvents txtPricePS As TextBox
    Friend WithEvents btnRetrieve As Button
    Friend WithEvents btnSaveInsert As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Customer_masterDataSet As customer_masterDataSet
    Friend WithEvents CustomermasterDataSetBindingSource As BindingSource
    Friend WithEvents dvgMedTable As DataGridView
    Friend WithEvents Customer_master_medicine_table As customer_master_medicine_table
    Friend WithEvents MedicineTableBindingSource As BindingSource
    Friend WithEvents Medicine_TableTableAdapter As customer_master_medicine_tableTableAdapters.medicine_TableTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicineNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockAvailableDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PricestripDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtMedUpdateId As TextBox
    Friend WithEvents txtMedDeleteId As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents PictureBox3 As PictureBox
End Class
