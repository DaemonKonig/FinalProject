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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmNCS = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmInvent = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAddTrpr = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmView = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCkieSht = New System.Windows.Forms.ToolStripMenuItem()
        Me.TroopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CookiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblLogged = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmFile, Me.tsmView, Me.ModifyToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(622, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmFile
        '
        Me.tsmFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.tsmAddTrpr, Me.tsmClose})
        Me.tsmFile.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmFile.Name = "tsmFile"
        Me.tsmFile.Size = New System.Drawing.Size(47, 27)
        Me.tsmFile.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNCS, Me.tsmInvent})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(181, 28)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'tsmNCS
        '
        Me.tsmNCS.Name = "tsmNCS"
        Me.tsmNCS.Size = New System.Drawing.Size(186, 28)
        Me.tsmNCS.Text = "Cookie Sheet"
        '
        'tsmInvent
        '
        Me.tsmInvent.Name = "tsmInvent"
        Me.tsmInvent.Size = New System.Drawing.Size(186, 28)
        Me.tsmInvent.Text = "Inventory"
        '
        'tsmAddTrpr
        '
        Me.tsmAddTrpr.Name = "tsmAddTrpr"
        Me.tsmAddTrpr.Size = New System.Drawing.Size(181, 28)
        Me.tsmAddTrpr.Text = "Add Trooper"
        '
        'tsmClose
        '
        Me.tsmClose.Name = "tsmClose"
        Me.tsmClose.Size = New System.Drawing.Size(181, 28)
        Me.tsmClose.Text = "Close"
        '
        'tsmView
        '
        Me.tsmView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmCkieSht, Me.TroopToolStripMenuItem})
        Me.tsmView.Name = "tsmView"
        Me.tsmView.Size = New System.Drawing.Size(53, 27)
        Me.tsmView.Text = "View"
        '
        'tsmCkieSht
        '
        Me.tsmCkieSht.Name = "tsmCkieSht"
        Me.tsmCkieSht.Size = New System.Drawing.Size(217, 26)
        Me.tsmCkieSht.Text = "Cookies && Inventory"
        '
        'TroopToolStripMenuItem
        '
        Me.TroopToolStripMenuItem.Name = "TroopToolStripMenuItem"
        Me.TroopToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.TroopToolStripMenuItem.Text = "Troop"
        '
        'ModifyToolStripMenuItem
        '
        Me.ModifyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CookiesToolStripMenuItem, Me.InventoryToolStripMenuItem})
        Me.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem"
        Me.ModifyToolStripMenuItem.Size = New System.Drawing.Size(68, 27)
        Me.ModifyToolStripMenuItem.Text = "Modify"
        '
        'CookiesToolStripMenuItem
        '
        Me.CookiesToolStripMenuItem.Name = "CookiesToolStripMenuItem"
        Me.CookiesToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.CookiesToolStripMenuItem.Text = "Cookie Sheets"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.InventoryToolStripMenuItem.Text = "Inventory"
        '
        'lblLogged
        '
        Me.lblLogged.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogged.Location = New System.Drawing.Point(213, 43)
        Me.lblLogged.Name = "lblLogged"
        Me.lblLogged.Size = New System.Drawing.Size(134, 23)
        Me.lblLogged.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.FinalProject.My.Resources.Resources.searching_cookie_300x300
        Me.PictureBox1.Location = New System.Drawing.Point(140, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(309, 271)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 366)
        Me.Controls.Add(Me.lblLogged)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Cookie Tracker 5000"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmFile As ToolStripMenuItem
    Friend WithEvents tsmView As ToolStripMenuItem
    Friend WithEvents tsmAddTrpr As ToolStripMenuItem
    Friend WithEvents tsmClose As ToolStripMenuItem
    Friend WithEvents tsmCkieSht As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmNCS As ToolStripMenuItem
    Friend WithEvents tsmInvent As ToolStripMenuItem
    Friend WithEvents lblLogged As Label
    Friend WithEvents ModifyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CookiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TroopToolStripMenuItem As ToolStripMenuItem
End Class
