Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.Common

Public Class Form1

    Dim cn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim dt As DataTable


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Customer_masterDataSet.customer_table' table. You can move, or remove it, as needed.
        Me.Customer_tableTableAdapter.Fill(Me.Customer_masterDataSet.customer_table)

        cn = New SqlConnection("Data Source=DESKTOP-4KKK0QH\SQLEXPRESS;Initial Catalog=customer_master;Integrated Security=True;Encrypt=False")
        cn.Open()
        MsgBox("DataBase Connected Successfully")
        cn.Close()

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        cmd = New SqlCommand("INSERT INTO customer_table (FirstName, LastName, DateOfBirth, Gender, Address) VALUES ('" & txtFirstName.Text & "', '" & txtLastName.Text & "', '" & DateTimePicker1.Value & "', '" & txtGender.Text & "', '" & txtAddress.Text & "')", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        UpdateDGV()
        cn.Close()
        MsgBox("Record inserted successfully")

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If String.IsNullOrWhiteSpace(txtSelect.Text) OrElse Not Integer.TryParse(txtSelect.Text, Nothing) Then
            ' if the input in the select box is invalid
            MessageBox.Show("Please enter a valid integer.")
        Else
            cmd = New SqlCommand("UPDATE customer_table SET FirstName = '" & txtFirstName.Text & "', LastName = '" & txtLastName.Text & "', DateOfBirth = '" & DateTimePicker1.Value & "', Gender = '" & txtGender.Text & "', Address = '" & txtAddress.Text & "' WHERE Id = " & txtSelect.Text & " ", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            UpdateDGV()
            cn.Close()
            MsgBox("Record updated successfully")
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        cmd = New SqlCommand("DELETE FROM customer_table WHERE Id = " & txtSelect.Text & "", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        UpdateDGV()
        cn.Close()
        MsgBox("Record deleted successfully")

    End Sub

    Private Sub btnRetrive_Click(sender As Object, e As EventArgs) Handles btnRetrive.Click

        cmd = New SqlCommand("SELECT * FROM customer_table WHERE Id =  @Id", cn)
        cmd.Parameters.AddWithValue("@Id", txtSelect.Text)
        cn.Open()
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            txtFirstName.Text = dr(1)
            txtLastName.Text = dr(2)
            DateTimePicker1.Value = dr(3)
            txtGender.Text = dr(4)
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
