<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainFrm
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
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnMedicine = New System.Windows.Forms.Button()
        Me.lblMainForm = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(169, 173)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(150, 71)
        Me.btnCustomer.TabIndex = 0
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnMedicine
        '
        Me.btnMedicine.Location = New System.Drawing.Point(483, 173)
        Me.btnMedicine.Name = "btnMedicine"
        Me.btnMedicine.Size = New System.Drawing.Size(150, 71)
        Me.btnMedicine.TabIndex = 1
        Me.btnMedicine.Text = "Medicine"
        Me.btnMedicine.UseVisualStyleBackColor = True
        '
        'lblMainForm
        '
        Me.lblMainForm.AutoSize = True
        Me.lblMainForm.Location = New System.Drawing.Point(346, 92)
        Me.lblMainForm.Name = "lblMainForm"
        Me.lblMainForm.Size = New System.Drawing.Size(70, 16)
        Me.lblMainForm.TabIndex = 2
        Me.lblMainForm.Text = "Main Form"
        '
        'mainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMainForm)
        Me.Controls.Add(Me.btnMedicine)
        Me.Controls.Add(Me.btnCustomer)
        Me.Name = "mainFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainFrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnMedicine As Button
    Friend WithEvents lblMainForm As Label
End Class
