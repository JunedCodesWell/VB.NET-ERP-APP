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
        Me.MedicineTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_master_medicine_table = New Application.customer_master_medicine_table()
        Me.Medicine_TableTableAdapter = New Application.customer_master_medicine_tableTableAdapters.medicine_TableTableAdapter()
        Me.txtMedUpdateId = New System.Windows.Forms.TextBox()
        Me.txtMedDeleteId = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.LabelStockAvailable = New System.Windows.Forms.Label()
        Me.PurchasedTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Purchased_Items_Table = New Application.Purchased_Items_Table()
        Me.Purchased_TableTableAdapter = New Application.Purchased_Items_TableTableAdapters.Purchased_TableTableAdapter()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.txtPurchaseQty = New System.Windows.Forms.TextBox()
        Me.dvgMedTable = New System.Windows.Forms.DataGridView()
        Me.DVGMedTableIdCloumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVGMedTableMedNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVGMedTableStockAvlbColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DVGMedTablePPSColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Medicine_table_DataSet1 = New Application.medicine_table_DataSet1()
        Me.DVGPurchasedItem = New System.Windows.Forms.DataGridView()
        Me.DGVTable2MedicineIdColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVTable2MedicineNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVTable2QtyColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVTable2PriceColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGenerateBill = New System.Windows.Forms.Button()
        Me.Medicine_TableTableAdapter1 = New Application.medicine_table_DataSet1TableAdapters.medicine_TableTableAdapter()
        Me.btnDeleteRow = New System.Windows.Forms.Button()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblTotalAmountValue = New System.Windows.Forms.Label()
        CType(Me.Customer_masterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomermasterDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicineTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_master_medicine_table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchasedTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Purchased_Items_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgMedTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicineTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Medicine_table_DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DVGPurchasedItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(47, 405)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(18, 16)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Id"
        '
        'lblMedName
        '
        Me.lblMedName.AutoSize = True
        Me.lblMedName.Location = New System.Drawing.Point(47, 437)
        Me.lblMedName.Name = "lblMedName"
        Me.lblMedName.Size = New System.Drawing.Size(102, 16)
        Me.lblMedName.TabIndex = 1
        Me.lblMedName.Text = "Medicine Name"
        '
        'lblStockAvlb
        '
        Me.lblStockAvlb.AutoSize = True
        Me.lblStockAvlb.Location = New System.Drawing.Point(47, 478)
        Me.lblStockAvlb.Name = "lblStockAvlb"
        Me.lblStockAvlb.Size = New System.Drawing.Size(98, 16)
        Me.lblStockAvlb.TabIndex = 2
        Me.lblStockAvlb.Text = "StockAvailable"
        '
        'lblPricePS
        '
        Me.lblPricePS.AutoSize = True
        Me.lblPricePS.Location = New System.Drawing.Point(47, 516)
        Me.lblPricePS.Name = "lblPricePS"
        Me.lblPricePS.Size = New System.Drawing.Size(69, 16)
        Me.lblPricePS.TabIndex = 3
        Me.lblPricePS.Text = "Price/Strip"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(19, 635)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(85, 22)
        Me.txtId.TabIndex = 4
        '
        'txtMedName
        '
        Me.txtMedName.Location = New System.Drawing.Point(159, 437)
        Me.txtMedName.Name = "txtMedName"
        Me.txtMedName.Size = New System.Drawing.Size(281, 22)
        Me.txtMedName.TabIndex = 5
        '
        'txtStockAvlb
        '
        Me.txtStockAvlb.Location = New System.Drawing.Point(159, 475)
        Me.txtStockAvlb.Name = "txtStockAvlb"
        Me.txtStockAvlb.Size = New System.Drawing.Size(281, 22)
        Me.txtStockAvlb.TabIndex = 6
        '
        'txtPricePS
        '
        Me.txtPricePS.Location = New System.Drawing.Point(159, 513)
        Me.txtPricePS.Name = "txtPricePS"
        Me.txtPricePS.Size = New System.Drawing.Size(281, 22)
        Me.txtPricePS.TabIndex = 7
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Location = New System.Drawing.Point(19, 672)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(85, 51)
        Me.btnRetrieve.TabIndex = 8
        Me.btnRetrieve.Text = "Retrieve/Id"
        Me.btnRetrieve.UseVisualStyleBackColor = True
        '
        'btnSaveInsert
        '
        Me.btnSaveInsert.Location = New System.Drawing.Point(236, 555)
        Me.btnSaveInsert.Name = "btnSaveInsert"
        Me.btnSaveInsert.Size = New System.Drawing.Size(100, 51)
        Me.btnSaveInsert.TabIndex = 9
        Me.btnSaveInsert.Text = "Save/Insert"
        Me.btnSaveInsert.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(255, 672)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(91, 51)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(502, 672)
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
        Me.txtMedUpdateId.Location = New System.Drawing.Point(255, 635)
        Me.txtMedUpdateId.Name = "txtMedUpdateId"
        Me.txtMedUpdateId.Size = New System.Drawing.Size(91, 22)
        Me.txtMedUpdateId.TabIndex = 13
        '
        'txtMedDeleteId
        '
        Me.txtMedDeleteId.Location = New System.Drawing.Point(502, 635)
        Me.txtMedDeleteId.Name = "txtMedDeleteId"
        Me.txtMedDeleteId.Size = New System.Drawing.Size(92, 22)
        Me.txtMedDeleteId.TabIndex = 14
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(513, 437)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 51)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear Text"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'LabelStockAvailable
        '
        Me.LabelStockAvailable.AutoSize = True
        Me.LabelStockAvailable.Location = New System.Drawing.Point(41, 14)
        Me.LabelStockAvailable.Name = "LabelStockAvailable"
        Me.LabelStockAvailable.Size = New System.Drawing.Size(101, 16)
        Me.LabelStockAvailable.TabIndex = 17
        Me.LabelStockAvailable.Text = "Stock Available"
        '
        'PurchasedTableBindingSource
        '
        Me.PurchasedTableBindingSource.DataMember = "Purchased_Table"
        Me.PurchasedTableBindingSource.DataSource = Me.Purchased_Items_Table
        '
        'Purchased_Items_Table
        '
        Me.Purchased_Items_Table.DataSetName = "Purchased_Items_Table"
        Me.Purchased_Items_Table.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Purchased_TableTableAdapter
        '
        Me.Purchased_TableTableAdapter.ClearBeforeFill = True
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Location = New System.Drawing.Point(686, 167)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(100, 65)
        Me.btnAddToCart.TabIndex = 19
        Me.btnAddToCart.Text = "Add To Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = True
        '
        'txtPurchaseQty
        '
        Me.txtPurchaseQty.Location = New System.Drawing.Point(686, 121)
        Me.txtPurchaseQty.Name = "txtPurchaseQty"
        Me.txtPurchaseQty.Size = New System.Drawing.Size(100, 22)
        Me.txtPurchaseQty.TabIndex = 20
        '
        'dvgMedTable
        '
        Me.dvgMedTable.AutoGenerateColumns = False
        Me.dvgMedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgMedTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DVGMedTableIdCloumn, Me.DVGMedTableMedNameColumn, Me.DVGMedTableStockAvlbColumn, Me.DVGMedTablePPSColumn})
        Me.dvgMedTable.DataSource = Me.MedicineTableBindingSource1
        Me.dvgMedTable.Location = New System.Drawing.Point(12, 40)
        Me.dvgMedTable.Name = "dvgMedTable"
        Me.dvgMedTable.RowHeadersWidth = 51
        Me.dvgMedTable.RowTemplate.Height = 24
        Me.dvgMedTable.Size = New System.Drawing.Size(635, 346)
        Me.dvgMedTable.TabIndex = 12
        '
        'DVGMedTableIdCloumn
        '
        Me.DVGMedTableIdCloumn.DataPropertyName = "id"
        Me.DVGMedTableIdCloumn.HeaderText = "id"
        Me.DVGMedTableIdCloumn.MinimumWidth = 6
        Me.DVGMedTableIdCloumn.Name = "DVGMedTableIdCloumn"
        Me.DVGMedTableIdCloumn.ReadOnly = True
        Me.DVGMedTableIdCloumn.Width = 125
        '
        'DVGMedTableMedNameColumn
        '
        Me.DVGMedTableMedNameColumn.DataPropertyName = "Medicine Name"
        Me.DVGMedTableMedNameColumn.HeaderText = "Medicine Name"
        Me.DVGMedTableMedNameColumn.MinimumWidth = 6
        Me.DVGMedTableMedNameColumn.Name = "DVGMedTableMedNameColumn"
        Me.DVGMedTableMedNameColumn.Width = 125
        '
        'DVGMedTableStockAvlbColumn
        '
        Me.DVGMedTableStockAvlbColumn.DataPropertyName = "Stock Available"
        Me.DVGMedTableStockAvlbColumn.HeaderText = "Stock Available"
        Me.DVGMedTableStockAvlbColumn.MinimumWidth = 6
        Me.DVGMedTableStockAvlbColumn.Name = "DVGMedTableStockAvlbColumn"
        Me.DVGMedTableStockAvlbColumn.Width = 125
        '
        'DVGMedTablePPSColumn
        '
        Me.DVGMedTablePPSColumn.DataPropertyName = "Price/strip"
        Me.DVGMedTablePPSColumn.HeaderText = "Price/strip"
        Me.DVGMedTablePPSColumn.MinimumWidth = 6
        Me.DVGMedTablePPSColumn.Name = "DVGMedTablePPSColumn"
        Me.DVGMedTablePPSColumn.Width = 125
        '
        'MedicineTableBindingSource1
        '
        Me.MedicineTableBindingSource1.DataMember = "medicine_Table"
        Me.MedicineTableBindingSource1.DataSource = Me.Medicine_table_DataSet1
        '
        'Medicine_table_DataSet1
        '
        Me.Medicine_table_DataSet1.DataSetName = "medicine_table_DataSet1"
        Me.Medicine_table_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DVGPurchasedItem
        '
        Me.DVGPurchasedItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVGPurchasedItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGVTable2MedicineIdColumn, Me.DGVTable2MedicineNameColumn, Me.DGVTable2QtyColumn, Me.DGVTable2PriceColumn})
        Me.DVGPurchasedItem.Location = New System.Drawing.Point(840, 40)
        Me.DVGPurchasedItem.Name = "DVGPurchasedItem"
        Me.DVGPurchasedItem.RowHeadersWidth = 51
        Me.DVGPurchasedItem.RowTemplate.Height = 24
        Me.DVGPurchasedItem.Size = New System.Drawing.Size(517, 346)
        Me.DVGPurchasedItem.TabIndex = 18
        '
        'DGVTable2MedicineIdColumn
        '
        Me.DGVTable2MedicineIdColumn.HeaderText = "Medicine Id"
        Me.DGVTable2MedicineIdColumn.MinimumWidth = 6
        Me.DGVTable2MedicineIdColumn.Name = "DGVTable2MedicineIdColumn"
        Me.DGVTable2MedicineIdColumn.Width = 125
        '
        'DGVTable2MedicineNameColumn
        '
        Me.DGVTable2MedicineNameColumn.HeaderText = "Medicine Name"
        Me.DGVTable2MedicineNameColumn.MinimumWidth = 6
        Me.DGVTable2MedicineNameColumn.Name = "DGVTable2MedicineNameColumn"
        Me.DGVTable2MedicineNameColumn.Width = 125
        '
        'DGVTable2QtyColumn
        '
        Me.DGVTable2QtyColumn.HeaderText = "Quantity"
        Me.DGVTable2QtyColumn.MinimumWidth = 6
        Me.DGVTable2QtyColumn.Name = "DGVTable2QtyColumn"
        Me.DGVTable2QtyColumn.Width = 125
        '
        'DGVTable2PriceColumn
        '
        Me.DGVTable2PriceColumn.HeaderText = "Price"
        Me.DGVTable2PriceColumn.MinimumWidth = 6
        Me.DGVTable2PriceColumn.Name = "DGVTable2PriceColumn"
        Me.DGVTable2PriceColumn.Width = 125
        '
        'btnGenerateBill
        '
        Me.btnGenerateBill.Location = New System.Drawing.Point(1303, 621)
        Me.btnGenerateBill.Name = "btnGenerateBill"
        Me.btnGenerateBill.Size = New System.Drawing.Size(134, 82)
        Me.btnGenerateBill.TabIndex = 21
        Me.btnGenerateBill.Text = "Generate Bill"
        Me.btnGenerateBill.UseVisualStyleBackColor = True
        '
        'Medicine_TableTableAdapter1
        '
        Me.Medicine_TableTableAdapter1.ClearBeforeFill = True
        '
        'btnDeleteRow
        '
        Me.btnDeleteRow.Location = New System.Drawing.Point(1373, 167)
        Me.btnDeleteRow.Name = "btnDeleteRow"
        Me.btnDeleteRow.Size = New System.Drawing.Size(99, 65)
        Me.btnDeleteRow.TabIndex = 22
        Me.btnDeleteRow.Text = "Delete Row"
        Me.btnDeleteRow.UseVisualStyleBackColor = True
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Location = New System.Drawing.Point(1054, 495)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(92, 16)
        Me.lblTotalAmount.TabIndex = 23
        Me.lblTotalAmount.Text = "Total Amount :"
        '
        'lblTotalAmountValue
        '
        Me.lblTotalAmountValue.AutoSize = True
        Me.lblTotalAmountValue.Location = New System.Drawing.Point(1184, 495)
        Me.lblTotalAmountValue.Name = "lblTotalAmountValue"
        Me.lblTotalAmountValue.Size = New System.Drawing.Size(79, 16)
        Me.lblTotalAmountValue.TabIndex = 24
        Me.lblTotalAmountValue.Text = "total amount"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1484, 733)
        Me.Controls.Add(Me.lblTotalAmountValue)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.btnDeleteRow)
        Me.Controls.Add(Me.btnGenerateBill)
        Me.Controls.Add(Me.txtPurchaseQty)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.DVGPurchasedItem)
        Me.Controls.Add(Me.LabelStockAvailable)
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
        CType(Me.MedicineTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_master_medicine_table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchasedTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Purchased_Items_Table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgMedTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicineTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Medicine_table_DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DVGPurchasedItem, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Customer_master_medicine_table As customer_master_medicine_table
    Friend WithEvents MedicineTableBindingSource As BindingSource
    Friend WithEvents Medicine_TableTableAdapter As customer_master_medicine_tableTableAdapters.medicine_TableTableAdapter
    Friend WithEvents txtMedUpdateId As TextBox
    Friend WithEvents txtMedDeleteId As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents LabelStockAvailable As Label
    Friend WithEvents Purchased_Items_Table As Purchased_Items_Table
    Friend WithEvents PurchasedTableBindingSource As BindingSource
    Friend WithEvents Purchased_TableTableAdapter As Purchased_Items_TableTableAdapters.Purchased_TableTableAdapter
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents txtPurchaseQty As TextBox
    Friend WithEvents dvgMedTable As DataGridView
    Friend WithEvents DVGMedTableIdCloumn As DataGridViewTextBoxColumn
    Friend WithEvents DVGMedTableMedNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents DVGMedTableStockAvlbColumn As DataGridViewTextBoxColumn
    Friend WithEvents DVGMedTablePPSColumn As DataGridViewTextBoxColumn
    Friend WithEvents DVGPurchasedItem As DataGridView
    Friend WithEvents btnGenerateBill As Button
    Friend WithEvents DGVTable2MedicineIdColumn As DataGridViewTextBoxColumn
    Friend WithEvents DGVTable2MedicineNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents DGVTable2QtyColumn As DataGridViewTextBoxColumn
    Friend WithEvents DGVTable2PriceColumn As DataGridViewTextBoxColumn
    Friend WithEvents Medicine_table_DataSet1 As medicine_table_DataSet1
    Friend WithEvents MedicineTableBindingSource1 As BindingSource
    Friend WithEvents Medicine_TableTableAdapter1 As medicine_table_DataSet1TableAdapters.medicine_TableTableAdapter
    Friend WithEvents btnDeleteRow As Button
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblTotalAmountValue As Label
End Class
