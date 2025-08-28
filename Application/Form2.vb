Imports System.Collections.ObjectModel
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Net
Imports System.Reflection.Emit
Imports System.Windows.Forms
Imports CustomerClass
Imports MedicineClass


Public Class Form2

    Dim cn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim da As SqlDataAdapter

    Public Function ClassAndValidation() As Medicine

        Dim med As New Medicine()

        If Integer.TryParse(txtId.Text, Nothing) Then 'for retrieve
            med.medId = Convert.ToInt32(txtId.Text)
        Else
            med.medId = 0
        End If

        If Integer.TryParse(txtMedUpdateId.Text, Nothing) Then
            med.medUpdateId = Convert.ToInt32(txtMedUpdateId.Text) 'for update
        Else
            med.medUpdateId = 0
        End If

        If Integer.TryParse(txtMedDeleteId.Text, Nothing) Then 'for delete
            med.medDeleteId = Convert.ToInt32(txtMedDeleteId.Text)
        Else
            med.medDeleteId = 0
        End If
        'med.Id = CInt(txtId.Text) not valid error
        med.MedicineName = txtMedName.Text

        Dim stockValue As Integer = 0
        If Integer.TryParse(txtStockAvlb.Text, stockValue) Then
            med.StockAvailable = stockValue
        Else
            med.StockAvailable = 0
        End If
        'med.StockAvailable = CInt(txtStockAvlb.Text)

        Dim priceValue As Decimal = 0
        If Decimal.TryParse(txtPricePS.Text, priceValue) Then
            med.PricePerStrip = priceValue
        Else
            med.PricePerStrip = 0
        End If
        'med.PricePerStrip = CDec(txtPricePS.Text)

        Return med

    End Function

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Medicine_table_DataSet1.medicine_Table' table. You can move, or remove it, as needed.
        Me.Medicine_TableTableAdapter1.Fill(Me.Medicine_table_DataSet1.medicine_Table)
        'TODO: This line of code loads data into the 'Purchased_Items_Table.Purchased_Table' table. You can move, or remove it, as needed.
        Me.Purchased_TableTableAdapter.Fill(Me.Purchased_Items_Table.Purchased_Table)
        'TODO: This line of code loads data into the 'Customer_master_medicine_table.medicine_Table' table. You can move, or remove it, as needed.
        Me.Medicine_TableTableAdapter.Fill(Me.Customer_master_medicine_table.medicine_Table)

        cn = New SqlConnection("Data Source=DESKTOP-4KKK0QH\SQLEXPRESS;Initial Catalog=customer_master;Integrated Security=True;Encrypt=False;TrustServerCertificate=True")
        cn.Open()
        MsgBox("Database connected successfully")
        cn.Close()

        'Total Amount Update code(for Label)
        AddHandler DVGPurchasedItem.CellValueChanged, AddressOf UpdateTotalAmount
        AddHandler DVGPurchasedItem.RowsRemoved, AddressOf UpdateTotalAmount
        AddHandler DVGPurchasedItem.RowsAdded, AddressOf UpdateTotalAmount
        AddHandler DVGPurchasedItem.CellEndEdit, AddressOf UpdateTotalAmount

    End Sub

    Private Sub btnSaveInsert_Click(sender As Object, e As EventArgs) Handles btnSaveInsert.Click
        'No change needed
        Dim med As Medicine = ClassAndValidation()
        cmd = New SqlCommand("INSERT INTO medicine_Table ([Medicine Name], [Stock Available], [Price/Strip]) VALUES (@MedicineName, @StockAvailable, @PriceStrip)", cn)
        cmd.Parameters.AddWithValue("@MedicineName", med.MedicineName)
        cmd.Parameters.AddWithValue("@StockAvailable", med.StockAvailable)
        cmd.Parameters.AddWithValue("@PriceStrip", med.PricePerStrip)

        cn.Open()
        cmd.ExecuteNonQuery()
        UpdateDGVMedTable()
        cn.Close()
        MsgBox("Record Inserted Successfully..")

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'No change needed
        Dim med As Medicine = ClassAndValidation()
        cmd = New SqlCommand("UPDATE medicine_Table SET [Medicine Name] = @MedicineName, [Stock Available] = @StockAvailable, [Price/Strip] = @PriceStrip WHERE Id = @Id", cn)
        cmd.Parameters.AddWithValue("@Id", med.medId)
        cmd.Parameters.AddWithValue("@MedicineName", med.MedicineName)
        cmd.Parameters.AddWithValue("@StockAvailable", med.StockAvailable)
        cmd.Parameters.AddWithValue("@PriceStrip", med.PricePerStrip)

        cn.Open()
        cmd.ExecuteNonQuery()
        UpdateDGVMedTable()
        cn.Close()
        MsgBox("Record Updated Successfully..")

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim med As Medicine = ClassAndValidation()
        cmd = New SqlCommand("DELETE FROM medicine_Table WHERE Id = @Id", cn)
        cmd.Parameters.AddWithValue("@Id", med.medId)

        cn.Open()
        cmd.ExecuteNonQuery()
        UpdateDGVMedTable()
        cn.Close()
        MsgBox("Record Updated Successfully..")

    End Sub

    Private Sub btnRetrieve_Click(sender As Object, e As EventArgs) Handles btnRetrieve.Click

        Dim med As Medicine = ClassAndValidation()
        cmd = New SqlCommand("SELECT * FROM medicine_Table WHERE Id = @Id", cn)
        cmd.Parameters.AddWithValue("@Id", med.medId)

        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            txtMedName.Text = dr(1)
            txtStockAvlb.Text = dr(2)
            txtPricePS.Text = dr(3)
        End If
        cn.Close()

    End Sub

    Private Sub UpdateDGVMedTable()

        da = New SqlDataAdapter
        dt = New DataTable
        cmd = New SqlCommand("SELECT * FROM medicine_Table", cn)
        'cn.Open()
        da.SelectCommand = cmd
        da.Fill(dt)
        'cn.Close()
        dvgMedTable.DataSource = dt

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is System.Windows.Forms.TextBox Then
                CType(ctrl, System.Windows.Forms.TextBox).Clear()
            End If
        Next

    End Sub

    'Add To Cart Functionality
    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click

        Dim med As Medicine = Me.ClassAndValidation()

        If dvgMedTable.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a medicine to purchase. No Selection")
            Exit Sub
        End If

        'Retrieving Values from table 1
        Dim selectedRow As DataGridViewRow = dvgMedTable.CurrentRow
        Dim medId As Integer = Convert.ToInt32(selectedRow.Cells("DVGMedTableIdCloumn").Value)      'corrections made from here
        Dim medName As String = selectedRow.Cells("DVGMedTableMedNameColumn").Value.ToString()
        Dim stockAvailable As Integer = Convert.ToInt32(selectedRow.Cells("DVGMedTableStockAvlbColumn").Value)
        Dim pricePerStrip As Decimal = Convert.ToDecimal(selectedRow.Cells("DVGMedTablePPSColumn").Value)

        'Get Purchase Quantity
        Dim purchaseQty As Integer
        If Not Integer.TryParse(txtPurchaseQty.Text.Trim, purchaseQty) OrElse purchaseQty <= 0 Then
            MessageBox.Show("Please enter a valid quantity.")
            Exit Sub
        End If

        If purchaseQty > stockAvailable Then
            MessageBox.Show("Not enough stock available.")
            Exit Sub
        End If

        'Calculating total price for this purchase
        Dim totalPrice As Decimal = pricePerStrip * purchaseQty

        'push values in table2(purchased items table)
        DVGPurchasedItem.Rows.Add(medId, medName, purchaseQty, totalPrice) 'work fixed

        'update Table1(Stock availability update)
        selectedRow.Cells("DVGMedTableStockAvlbColumn").Value = stockAvailable - purchaseQty

        'update SQL dataBase
        'cmd = New SqlCommand("UPDATE medicine_table SET [Stock Available] = [Stock Available] - @qty WHERE id = @id", cn)
        'cmd.Parameters.AddWithValue("@qty", purchaseQty)
        'cmd.Parameters.AddWithValue("@id", med.medId)
        'cn.Open()
        'cmd.ExecuteNonQuery()
        'cn.Close()

        'Adding to purachase items table in Database
        'Dim insertCmd As New SqlCommand("INSERT INTO Purchased_Table (ProductName, Quantity, Price) VALUES (@pn, @q, @p)", cn)
        'insertCmd.Parameters.AddWithValue("@pn", medName)
        'insertCmd.Parameters.AddWithValue("@q", purchaseQty)
        'insertCmd.Parameters.AddWithValue("@p", totalPrice)
        'cn.Open()
        'insertCmd.ExecuteNonQuery()

    End Sub


    '============================================================================================================
    '============================================================================================================
    '============================================================================================================


    Private Sub btnGenerateBill_Click(sender As Object, e As EventArgs) Handles btnGenerateBill.Click

        Dim cust As Customer = Form1.ClassAndValidation()
        Dim med As Medicine = Me.ClassAndValidation()
        Dim billCartItems As DataTable = Me.CopyCart()
        Dim frm3 As New Form3(cust, med, billCartItems)
        frm3.SetTotalAmount(lblTotalAmountValue.Text)

        'update database connected to table1(stock available)
        Try

            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If


            For Each row As DataGridViewRow In DVGPurchasedItem.Rows

                If row.IsNewRow Then Continue For


                Dim medId As Integer = Convert.ToInt32(row.Cells("DGVTable2MedicineIdColumn").Value)


                Dim qtyPurchased As Integer = Convert.ToInt32(row.Cells("DGVTable2QtyColumn").Value)


                Dim query As String = "UPDATE medicine_table SET [Stock Available] = [Stock Available] - @qty WHERE Id = @id"

                Using cmd As New SqlCommand(query, cn)
                    cmd.Parameters.AddWithValue("@qty", qtyPurchased)
                    cmd.Parameters.AddWithValue("@id", medId)


                    cmd.ExecuteNonQuery()
                End Using
            Next


            MessageBox.Show("Bill generated and stock updated in database.")


        Catch ex As Exception
            MessageBox.Show("Error while generating bill: " & ex.Message)
        Finally

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

        End Try

        frm3.Show()

    End Sub

    'Delete Button Code(Purachse Table - delete row button)
    Private Sub btnDeleteRow_Click(sender As Object, e As EventArgs) Handles btnDeleteRow.Click

        ' Check if a row is selected
        If DVGPurchasedItem.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.")
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow = DVGPurchasedItem.SelectedRows(0)
        Dim medicineId As Integer = Convert.ToInt32(selectedRow.Cells("DGVTable2MedicineIdColumn").Value)
        Dim quantityToRestore As Integer = Convert.ToInt32(selectedRow.Cells("DGVTable2QtyColumn").Value)

        ' Add the quantity back to the stock table in UI only
        For Each stockRestoreRow As DataGridViewRow In dvgMedTable.Rows
            If Convert.ToInt32(stockRestoreRow.Cells("DVGMedTableIdCloumn").Value) = medicineId Then
                stockRestoreRow.Cells("DVGMedTableStockAvlbColumn").Value = Convert.ToInt32(stockRestoreRow.Cells("DVGMedTableStockAvlbColumn").Value) + quantityToRestore
                Exit For
            End If
        Next

        DVGPurchasedItem.Rows.Remove(selectedRow)

    End Sub

    'Data Table (Purachsed Table Copy)
    Public Function CopyCart() As DataTable

        Dim cartCopy As New DataTable()
        For Each col As DataGridViewColumn In DVGPurchasedItem.Columns
            cartCopy.Columns.Add(col.HeaderText)
        Next

        For Each row As DataGridViewRow In DVGPurchasedItem.Rows
            If Not row.IsNewRow Then
                Dim rowCopy As DataRow = cartCopy.NewRow()
                For i As Integer = 0 To DVGPurchasedItem.Columns.Count - 1
                    rowCopy(i) = row.Cells(i).Value
                Next
                cartCopy.Rows.Add(rowCopy)
            End If
        Next

        Return cartCopy

    End Function

    'Update Total Amount Code
    Private Sub UpdateTotalAmount(sender As Object, e As EventArgs)
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In DVGPurchasedItem.Rows
            If Not row.IsNewRow AndAlso row.Cells("DGVTable2PriceColumn").Value IsNot Nothing Then
                Dim price As Decimal
                If Decimal.TryParse(row.Cells("DGVTable2PriceColumn").Value.ToString(), price) Then
                    total += price
                End If
            End If
        Next

        lblTotalAmountValue.Text = total.ToString("F2")
    End Sub

End Class