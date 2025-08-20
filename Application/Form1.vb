Imports System.Data.SqlClient

Public Class Form1

    Dim cn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cn = New SqlConnection("Data Source=DESKTOP-4KKK0QH\SQLEXPRESS;Initial Catalog=customer_master;Integrated Security=True;Encrypt=False")
        cn.Open()
        MsgBox("DataBase Connected Successfully")
        cn.Close()

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        cmd = New SqlCommand("INSERT INTO customer_table (FirstName, LastName, DateOfBirth, Gender, Address) VALUES ('" & txtFirstName.Text & "', '" & txtLastName.Text & "', '" & DateTimePicker1.Value & "', '" & txtGender.Text & "', '" & txtAddress.Text & "')", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Record inserted successfully")

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        cmd = New SqlCommand("UPDATE customer_table SET FirstName = '" & txtFirstName.Text & "', LastName = '" & txtLastName.Text & "', DateOfBirth = '" & DateTimePicker1.Value & "', Gender = '" & txtGender.Text & "', Address = '" & txtAddress.Text & "' WHERE Id = " & txtSelect.Text & " ", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Record updated successfully")
        
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        cmd = New SqlCommand("DELETE FROM customer_table WHERE Id = " & txtSelect.Text & "", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Record deleted successfully")

    End Sub

    Private Sub btnRetrive_Click(sender As Object, e As EventArgs) Handles btnRetrive.Click

        cmd = New SqlCommand("SELECT * FROM customer_table WHERE Id = " & txtSelect.Text & "", cn)
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
End Class
