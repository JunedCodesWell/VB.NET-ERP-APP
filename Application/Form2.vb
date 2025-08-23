Imports MedicineClass
Imports System.Data.SqlClient
Imports System.Net


Public Class Form2

    Dim cn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Private Function ClassAndValidation() As Medicine

        Dim med As New Medicine()

        If Integer.TryParse(txtId.Text, Nothing) Then
            med.Id = Convert.ToInt32(txtId.Text)
        Else
            med.Id = 0
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

        cn = New SqlConnection("Data Source=DESKTOP-4KKK0QH\SQLEXPRESS;Initial Catalog=customer_master;Integrated Security=True;Encrypt=False;TrustServerCertificate=True")
        cn.Open()
        MsgBox("Database connected successfully")
        cn.Close()
    End Sub

    Private Sub btnSaveInsert_Click(sender As Object, e As EventArgs) Handles btnSaveInsert.Click
        'No change needed
        Dim med As Medicine = ClassAndValidation()
        cmd = New SqlCommand("INSERT INTO medicine_Table ([Medicine Name], [Stock Available], [Price/Strip]) VALUES (@MedicineName, @StockAvailable, @PriceStrip)", cn)
        'cmd.Parameters.AddWithValue("@Id", med.Id)
        cmd.Parameters.AddWithValue("@MedicineName", med.MedicineName)
        cmd.Parameters.AddWithValue("@StockAvailable", med.StockAvailable)
        cmd.Parameters.AddWithValue("@PriceStrip", med.PricePerStrip)

        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Record Inserted Successfully..")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'No change needed
        Dim med As Medicine = ClassAndValidation()
        cmd = New SqlCommand("UPDATE medicine_Table SET [Medicine Name] = @MedicineName, [Stock Available] = @StockAvailable, [Price/Strip] = @PriceStrip WHERE Id = @Id", cn)
        cmd.Parameters.AddWithValue("@Id", med.Id)
        cmd.Parameters.AddWithValue("@MedicineName", med.MedicineName)
        cmd.Parameters.AddWithValue("@StockAvailable", med.StockAvailable)
        cmd.Parameters.AddWithValue("@PriceStrip", med.PricePerStrip)

        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Record Updated Successfully..")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim med As Medicine = ClassAndValidation()
        cmd = New SqlCommand("DELETE FROM medicine_Table WHERE Id = @Id", cn)
        cmd.Parameters.AddWithValue("@Id", med.Id)

        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Record Updated Successfully..")
    End Sub

    Private Sub btnRetrieve_Click(sender As Object, e As EventArgs) Handles btnRetrieve.Click

        Dim med As Medicine = ClassAndValidation()
        cmd = New SqlCommand("SELECT * FROM medicine_Table WHERE Id = @Id", cn)
        cmd.Parameters.AddWithValue("@Id", med.Id)

        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            txtMedName.Text = dr(1)
            txtStockAvlb.Text = dr(2)
            txtPricePS.Text = dr(3)
        End If
        cn.Close()

    End Sub
End Class