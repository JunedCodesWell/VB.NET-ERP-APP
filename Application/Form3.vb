Imports CustomerClass
Imports MedicineClass
Imports System.Net
Imports System.Data
Imports System.Data.Common
Imports System.Windows.Forms
Public Class Form3

    'declaring variables to hold the variables
    Private cust As Customer
    Private med As Medicine

    Public Sub New(ByVal Form1Cust As Customer, ByVal form2Med As Medicine) 'custom constructor

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        cust = Form1Cust
        med = form2Med

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        billDeatils()
    End Sub

    Private Sub billDeatils()

        Dim Fname As String = cust.FirstName
        Dim Lname As String = cust.LastName
        Dim DOB As Date = cust.DateOfBirth
        Dim Gender As String = cust.Gender
        Dim Address As String = cust.Address

        Dim medName As String = med.MedicineName
        Dim PPS As String = med.PricePerStrip

        lblFrm3Fname.Text = Fname
        lblFrm3Lname.Text = Lname
        lblFrm3DOB.Text = DOB
        lblFrm3Gender.Text = Gender
        lblFrm3Address.Text = Address

        lblFrm3MedName.Text = medName
        lblFrm3PPS.Text = PPS

    End Sub


End Class