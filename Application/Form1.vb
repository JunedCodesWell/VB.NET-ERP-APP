Imports CustomerClass
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.Common
Imports System.Windows.Forms



Public Class Form1
    'SQL declarations----------------
    Dim cn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim dt As DataTable

    'Function for imported Class and Validation----
    Public Function ClassAndValidation() As Customer

        Dim cust As New Customer()

        If Integer.TryParse(txtSelect.Text, Nothing) Then 'for retrieve btn
            cust.Id = Convert.ToInt32(txtSelect.Text)
        Else
            cust.Id = 0
        End If

        If Integer.TryParse(txtUpdateId.Text, Nothing) Then 'for update btn
            cust.UpdateId = Convert.ToInt32(txtUpdateId.Text)
        Else
            cust.UpdateId = 0
        End If

        If Integer.TryParse(txtDeleteId.Text, Nothing) Then 'for delete btn
            cust.DeleteId = Convert.ToInt32(txtDeleteId.Text)
        Else
            cust.DeleteId = 0
        End If


        cust.FirstName = txtFirstName.Text
        cust.LastName = txtLastName.Text
        cust.DateOfBirth = DateTimePicker1.Value
        cust.Gender = cmbGender.Text
        cust.Address = txtAddress.Text

        Return cust

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Customer_masterDataSet.customer_table' table. You can move, or remove it, as needed.
        Me.Customer_tableTableAdapter.Fill(Me.Customer_masterDataSet.customer_table)

        cn = New SqlConnection("Data Source=DESKTOP-4KKK0QH\SQLEXPRESS;Initial Catalog=customer_master;Integrated Security=True;Encrypt=False")
        cn.Open()
        MsgBox("DataBase Connected Successfully")
        cn.Close()

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        'completed No code Change required
        Dim cust As Customer = ClassAndValidation()
        If Not cust.IsValidAge() Then
            Exit Sub
        End If
        cmd = New SqlCommand("INSERT INTO customer_table (FirstName, LastName, DateOfBirth, Gender, Address) VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @Address)", cn)
        cmd.Parameters.AddWithValue("@Id", cust.Id)
        cmd.Parameters.AddWithValue("@FirstName", cust.FirstName)
        cmd.Parameters.AddWithValue("@LastName", cust.LastName)
        'cmd.Parameters.AddWithValue("@DateOfBirth", cust.DateOfBirth)
        If cust.DateOfBirth < New DateTime(1753, 1, 1) OrElse cust.DateOfBirth > New DateTime(9999, 12, 31) Then
            cmd.Parameters.AddWithValue("@DateOfBirth", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@DateOfBirth", cust.DateOfBirth)
        End If
        cmd.Parameters.AddWithValue("@Gender", cust.Gender)
        cmd.Parameters.AddWithValue("@Address", cust.Address)
        cn.Open()
        cmd.ExecuteNonQuery()
        UpdateDGV()
        cn.Close()
        MsgBox("Record inserted successfully")
        Form2.Show()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim cust As Customer = ClassAndValidation()
        If Not cust.IsValidAge() Then
            Exit Sub
        End If
        cmd = New SqlCommand("UPDATE customer_table SET FirstName = @FirstName, LastName = @LastName, DateOfBirth = @DateOfBirth, Gender = @Gender, Address = @Address WHERE Id = @Id", cn)
        cmd.Parameters.AddWithValue("@Id", cust.UpdateId)
        cmd.Parameters.AddWithValue("@FirstName", cust.FirstName)
        cmd.Parameters.AddWithValue("@LastName", cust.LastName)
        'cmd.Parameters.AddWithValue("@DateOfBirth", cust.DateOfBirth)
        If cust.DateOfBirth < New DateTime(1753, 1, 1) OrElse cust.DateOfBirth > New DateTime(9999, 12, 31) Then
            cmd.Parameters.AddWithValue("@DateOfBirth", DBNull.Value)
        Else
            cmd.Parameters.AddWithValue("@DateOfBirth", cust.DateOfBirth)
        End If
        cmd.Parameters.AddWithValue("@Gender", cust.Gender)
        cmd.Parameters.AddWithValue("@Address", cust.Address)
        cn.Open()
        cmd.ExecuteNonQuery()
        UpdateDGV()
        cn.Close()
        MsgBox("Record updated successfully")
        Form2.Show()


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim cust As Customer = ClassAndValidation()
        cmd = New SqlCommand("DELETE FROM customer_table WHERE Id = @Id", cn)
        cmd.Parameters.AddWithValue("@Id", cust.DeleteId)
        cn.Open()
        cmd.ExecuteNonQuery()
        UpdateDGV()
        cn.Close()
        MsgBox("Record deleted successfully")

    End Sub

    Private Sub btnRetrive_Click(sender As Object, e As EventArgs) Handles btnRetrive.Click

        Dim cust As Customer = ClassAndValidation()
        'cust.EnableValidation = False   'Date/Age Msg will not be shown
        cmd = New SqlCommand("SELECT * FROM customer_table WHERE Id =  @Id", cn)
        cmd.Parameters.AddWithValue("@Id", cust.Id)
        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            txtFirstName.Text = dr(1)
            txtLastName.Text = dr(2)
            DateTimePicker1.Value = dr(3)
            cmbGender.Text = dr(4)
            txtAddress.Text = dr(5)
        Else
            MsgBox("No Record Found..!!")
        End If
        cn.Close()

    End Sub

    Private Sub UpdateDGV()

        da = New SqlDataAdapter
        dt = New DataTable
        cmd = New SqlCommand("SELECT * FROM customer_table", cn)
        da.SelectCommand = cmd
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form2.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("clicked")
        Dim mainForm As New mainFrm()
        mainForm.Show()
        'error int this piece of code
    End Sub

    'clear all textboxes
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is System.Windows.Forms.TextBox Then
                CType(ctrl, System.Windows.Forms.TextBox).Clear()
            End If
        Next
    End Sub

End Class
