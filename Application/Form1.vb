Imports CustomerClass
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.Common


Public Class Form1
    'SQL declarations----------------
    Dim cn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    '--------------------------------

    'TextBox.Text values in a variable-------
    'Dim Id As Integer
    'Dim FirstName As String = txtFirstName.Text
    'Dim LastName As String = txtLastName.Text
    'Dim DOB As Date = DateTimePicker1.Value
    'Dim Gender As String = txtGender.Text
    'Dim Address As String = txtAddress.Text

    '-----------------------------------------


    'Function for imported Class and Validation----
    Private Function ClassAndValidation() As Customer

        Dim cust As New Customer()

        If Integer.TryParse(txtSelect.Text, Nothing) Then
            cust.Id = Convert.ToInt32(txtSelect.Text)
        Else
            cust.Id = 0
        End If

        cust.FirstName = txtFirstName.Text
        cust.LastName = txtLastName.Text
        cust.DateOfBirth = DateTimePicker1.Value
        cust.Gender = cmbGender.Text
        cust.Address = txtAddress.Text


        Return cust

    End Function
    '-----------------------------------------

    'SQL Parameters---------------------------


    '-----------------------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Customer_masterDataSet.customer_table' table. You can move, or remove it, as needed.
        Me.Customer_tableTableAdapter.Fill(Me.Customer_masterDataSet.customer_table)

        cn = New SqlConnection("Data Source=DESKTOP-4KKK0QH\SQLEXPRESS;Initial Catalog=customer_master;Integrated Security=True;Encrypt=False")
        cn.Open()
        MsgBox("DataBase Connected Successfully")
        cn.Close()

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        Dim cust As Customer = ClassAndValidation()
        cmd = New SqlCommand("INSERT INTO customer_table (FirstName, LastName, DateOfBirth, Gender, Address) VALUES (@FirstName, @LastName, @DateOfBirth, @Gender, @Address)", cn)
        cmd.Parameters.AddWithValue("@Id", cust.Id)
        cmd.Parameters.AddWithValue("@FirstName", cust.FirstName)
        cmd.Parameters.AddWithValue("@LastName", cust.LastName)
        cmd.Parameters.AddWithValue("@DateOfBirth", cust.DateOfBirth)
        cmd.Parameters.AddWithValue("@Gender", cust.Gender)
        cmd.Parameters.AddWithValue("@Address", cust.Address)
        cn.Open()
        cmd.ExecuteNonQuery()
        UpdateDGV()
        cn.Close()
        MsgBox("Record inserted successfully")

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim cust As Customer = ClassAndValidation()
        cmd = New SqlCommand("UPDATE customer_table SET FirstName = @FirstName, LastName = @LastName, DateOfBirth = @DateOfBirth, Gender = @Gender, Address = @Address WHERE Id = @Id", cn)
        cmd.Parameters.AddWithValue("@Id", cust.Id)
        cmd.Parameters.AddWithValue("@FirstName", cust.FirstName)
        cmd.Parameters.AddWithValue("@LastName", cust.LastName)
        cmd.Parameters.AddWithValue("@DateOfBirth", cust.DateOfBirth)
        cmd.Parameters.AddWithValue("@Gender", cust.Gender)
        cmd.Parameters.AddWithValue("@Address", cust.Address)
        cn.Open()
        cmd.ExecuteNonQuery()
        UpdateDGV()
        cn.Close()
        MsgBox("Record updated successfully")


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim cust As Customer = ClassAndValidation()
        cmd = New SqlCommand("DELETE FROM customer_table WHERE Id = @Id", cn)
        cmd.Parameters.AddWithValue("@Id", cust.Id)
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
        'cn.Open()
        da.SelectCommand = cmd
        da.Fill(dt)
        'cn.Close()

        DataGridView1.DataSource = dt

    End Sub


End Class
