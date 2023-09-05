<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtFirstNumber = New System.Windows.Forms.TextBox()
        Me.lblFirstNumber = New System.Windows.Forms.Label()
        Me.lblSecondNumber = New System.Windows.Forms.Label()
        Me.txtSecondNumber = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFirstNumber
        '
        Me.txtFirstNumber.Location = New System.Drawing.Point(212, 67)
        Me.txtFirstNumber.Name = "txtFirstNumber"
        Me.txtFirstNumber.Size = New System.Drawing.Size(100, 26)
        Me.txtFirstNumber.TabIndex = 0
        '
        'lblFirstNumber
        '
        Me.lblFirstNumber.AutoSize = True
        Me.lblFirstNumber.Location = New System.Drawing.Point(74, 67)
        Me.lblFirstNumber.Name = "lblFirstNumber"
        Me.lblFirstNumber.Size = New System.Drawing.Size(132, 20)
        Me.lblFirstNumber.TabIndex = 1
        Me.lblFirstNumber.Text = "Enter 1st number"
        '
        'lblSecondNumber
        '
        Me.lblSecondNumber.AutoSize = True
        Me.lblSecondNumber.Location = New System.Drawing.Point(74, 172)
        Me.lblSecondNumber.Name = "lblSecondNumber"
        Me.lblSecondNumber.Size = New System.Drawing.Size(137, 20)
        Me.lblSecondNumber.TabIndex = 2
        Me.lblSecondNumber.Text = "Enter 2nd number"
        '
        'txtSecondNumber
        '
        Me.txtSecondNumber.Location = New System.Drawing.Point(212, 169)
        Me.txtSecondNumber.Name = "txtSecondNumber"
        Me.txtSecondNumber.Size = New System.Drawing.Size(100, 26)
        Me.txtSecondNumber.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(125, 253)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(139, 56)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtSecondNumber)
        Me.Controls.Add(Me.lblSecondNumber)
        Me.Controls.Add(Me.lblFirstNumber)
        Me.Controls.Add(Me.txtFirstNumber)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstNumber As TextBox
    Friend WithEvents lblFirstNumber As Label
    Friend WithEvents lblSecondNumber As Label
    Friend WithEvents txtSecondNumber As TextBox
    Friend WithEvents btnCalculate As Button
End Class
