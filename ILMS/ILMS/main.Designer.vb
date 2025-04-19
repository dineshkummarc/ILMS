<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tlmasterfiles = New System.Windows.Forms.ToolStripDropDownButton
        Me.FacilitatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.studentmenu = New System.Windows.Forms.ToolStripMenuItem
        Me.tlsEnrollment = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnlogin = New System.Windows.Forms.ToolStripButton
        Me.TSUser = New System.Windows.Forms.ToolStripLabel
        Me.tlsInventory = New System.Windows.Forms.ToolStripButton
        Me.tlsettings = New System.Windows.Forms.ToolStripDropDownButton
        Me.DefaultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tlreports = New System.Windows.Forms.ToolStripDropDownButton
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 610)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1274, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.GripMargin = New System.Windows.Forms.Padding(1)
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.tlmasterfiles, Me.tlsEnrollment, Me.ToolStripSeparator1, Me.btnlogin, Me.TSUser, Me.tlsInventory, Me.tlsettings, Me.tlreports, Me.ToolStripButton5})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1274, 52)
        Me.ToolStrip2.TabIndex = 12
        Me.ToolStrip2.Text = "Reports"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 52)
        '
        'tlmasterfiles
        '
        Me.tlmasterfiles.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacilitatorToolStripMenuItem, Me.studentmenu})
        Me.tlmasterfiles.Image = Global.ILMS.My.Resources.Resources.card_file
        Me.tlmasterfiles.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlmasterfiles.Name = "tlmasterfiles"
        Me.tlmasterfiles.Size = New System.Drawing.Size(77, 49)
        Me.tlmasterfiles.Text = "Masterfiles"
        Me.tlmasterfiles.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlmasterfiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FacilitatorToolStripMenuItem
        '
        Me.FacilitatorToolStripMenuItem.Name = "FacilitatorToolStripMenuItem"
        Me.FacilitatorToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.FacilitatorToolStripMenuItem.Text = "Facilitator"
        '
        'studentmenu
        '
        Me.studentmenu.Name = "studentmenu"
        Me.studentmenu.Size = New System.Drawing.Size(126, 22)
        Me.studentmenu.Text = "&Student"
        '
        'tlsEnrollment
        '
        Me.tlsEnrollment.Image = CType(resources.GetObject("tlsEnrollment.Image"), System.Drawing.Image)
        Me.tlsEnrollment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsEnrollment.Name = "tlsEnrollment"
        Me.tlsEnrollment.Size = New System.Drawing.Size(69, 49)
        Me.tlsEnrollment.Text = "Enrollment"
        Me.tlsEnrollment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlsEnrollment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'btnlogin
        '
        Me.btnlogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlogin.Image = Global.ILMS.My.Resources.Resources.Login_icon
        Me.btnlogin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(41, 49)
        Me.btnlogin.Text = "Login"
        Me.btnlogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSUser
        '
        Me.TSUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TSUser.Name = "TSUser"
        Me.TSUser.Size = New System.Drawing.Size(58, 49)
        Me.TSUser.Text = "Hi, Guest!"
        '
        'tlsInventory
        '
        Me.tlsInventory.Image = CType(resources.GetObject("tlsInventory.Image"), System.Drawing.Image)
        Me.tlsInventory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsInventory.Name = "tlsInventory"
        Me.tlsInventory.Size = New System.Drawing.Size(61, 49)
        Me.tlsInventory.Text = "Inventory"
        Me.tlsInventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlsInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tlsettings
        '
        Me.tlsettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultsToolStripMenuItem})
        Me.tlsettings.Image = Global.ILMS.My.Resources.Resources.settings
        Me.tlsettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsettings.Name = "tlsettings"
        Me.tlsettings.Size = New System.Drawing.Size(62, 49)
        Me.tlsettings.Text = "Settings"
        Me.tlsettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlsettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DefaultsToolStripMenuItem
        '
        Me.DefaultsToolStripMenuItem.Name = "DefaultsToolStripMenuItem"
        Me.DefaultsToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.DefaultsToolStripMenuItem.Text = "Defaults"
        '
        'tlreports
        '
        Me.tlreports.Image = Global.ILMS.My.Resources.Resources.report
        Me.tlreports.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlreports.Name = "tlreports"
        Me.tlreports.Size = New System.Drawing.Size(60, 49)
        Me.tlreports.Text = "Reports"
        Me.tlreports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(34, 49)
        Me.ToolStripButton5.Text = "ToolStripButton5"
        Me.ToolStripButton5.Visible = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 632)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.StatusStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.IsMdiContainer = True
        Me.Name = "main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Internet Laboratory Management System"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlmasterfiles As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents studentmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsEnrollment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnlogin As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSUser As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlsInventory As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsettings As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents DefaultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlreports As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents FacilitatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
