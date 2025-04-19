<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewdefault
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtcategory = New System.Windows.Forms.TextBox
        Me.radyes = New System.Windows.Forms.RadioButton
        Me.radno = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtlistname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnsave = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtlistname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.radno)
        Me.GroupBox1.Controls.Add(Me.radyes)
        Me.GroupBox1.Controls.Add(Me.txtcategory)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Default"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Category :"
        '
        'txtcategory
        '
        Me.txtcategory.Location = New System.Drawing.Point(68, 29)
        Me.txtcategory.Name = "txtcategory"
        Me.txtcategory.Size = New System.Drawing.Size(148, 20)
        Me.txtcategory.TabIndex = 1
        '
        'radyes
        '
        Me.radyes.AutoSize = True
        Me.radyes.Location = New System.Drawing.Point(107, 94)
        Me.radyes.Name = "radyes"
        Me.radyes.Size = New System.Drawing.Size(43, 17)
        Me.radyes.TabIndex = 2
        Me.radyes.TabStop = True
        Me.radyes.Text = "Yes"
        Me.radyes.UseVisualStyleBackColor = True
        '
        'radno
        '
        Me.radno.AutoSize = True
        Me.radno.Checked = True
        Me.radno.Location = New System.Drawing.Point(156, 94)
        Me.radno.Name = "radno"
        Me.radno.Size = New System.Drawing.Size(39, 17)
        Me.radno.TabIndex = 3
        Me.radno.TabStop = True
        Me.radno.Text = "No"
        Me.radno.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Item :"
        '
        'txtlistname
        '
        Me.txtlistname.Location = New System.Drawing.Point(68, 55)
        Me.txtlistname.Name = "txtlistname"
        Me.txtlistname.Size = New System.Drawing.Size(148, 20)
        Me.txtlistname.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Set as Default? :"
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(145, 147)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(57, 23)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(208, 147)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(57, 23)
        Me.btncancel.TabIndex = 2
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'frmNewdefault
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 178)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmNewdefault"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtlistname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents radno As System.Windows.Forms.RadioButton
    Friend WithEvents radyes As System.Windows.Forms.RadioButton
    Friend WithEvents txtcategory As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
End Class
