<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCookieSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTroopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeCookieSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ModifyToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(614, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewReportToolStripMenuItem, Me.ViewToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(44, 24)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewCookieSheetToolStripMenuItem, Me.ViewTroopToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(53, 24)
        Me.ToolStripMenuItem2.Text = "View"
        '
        'NewReportToolStripMenuItem
        '
        Me.NewReportToolStripMenuItem.Name = "NewReportToolStripMenuItem"
        Me.NewReportToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.NewReportToolStripMenuItem.Text = "New Cookie Sheet"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ViewToolStripMenuItem.Text = "Add Troop"
        '
        'ViewCookieSheetToolStripMenuItem
        '
        Me.ViewCookieSheetToolStripMenuItem.Name = "ViewCookieSheetToolStripMenuItem"
        Me.ViewCookieSheetToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.ViewCookieSheetToolStripMenuItem.Text = "View Cookie Sheet"
        '
        'ModifyToolStripMenuItem
        '
        Me.ModifyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeCookieSheetToolStripMenuItem, Me.ChangeUserToolStripMenuItem})
        Me.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem"
        Me.ModifyToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.ModifyToolStripMenuItem.Text = "Modify"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ViewTroopToolStripMenuItem
        '
        Me.ViewTroopToolStripMenuItem.Name = "ViewTroopToolStripMenuItem"
        Me.ViewTroopToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.ViewTroopToolStripMenuItem.Text = "View Troop"
        '
        'ChangeCookieSheetToolStripMenuItem
        '
        Me.ChangeCookieSheetToolStripMenuItem.Name = "ChangeCookieSheetToolStripMenuItem"
        Me.ChangeCookieSheetToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.ChangeCookieSheetToolStripMenuItem.Text = "Change Cookie Sheet"
        '
        'ChangeUserToolStripMenuItem
        '
        Me.ChangeUserToolStripMenuItem.Name = "ChangeUserToolStripMenuItem"
        Me.ChangeUserToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.ChangeUserToolStripMenuItem.Text = "Change Troop"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 258)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Cookie Tracker 5000"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents NewReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCookieSheetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewTroopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeCookieSheetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
End Class
