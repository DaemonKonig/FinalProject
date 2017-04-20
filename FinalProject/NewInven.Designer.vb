<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewInven
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
        Me.btnSub = New System.Windows.Forms.Button()
        Me.cboUsers = New System.Windows.Forms.ComboBox()
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSCDataSet = New FinalProject.GSCDataSet()
        Me.txtMints = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLites = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPatties = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBread = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AccountsTableAdapter = New FinalProject.GSCDataSetTableAdapters.AccountsTableAdapter()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSub
        '
        Me.btnSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub.Location = New System.Drawing.Point(124, 385)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(114, 38)
        Me.btnSub.TabIndex = 0
        Me.btnSub.Text = "Submit"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'cboUsers
        '
        Me.cboUsers.DataSource = Me.AccountsBindingSource
        Me.cboUsers.DisplayMember = "Username"
        Me.cboUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUsers.FormattingEnabled = True
        Me.cboUsers.Location = New System.Drawing.Point(177, 41)
        Me.cboUsers.Name = "cboUsers"
        Me.cboUsers.Size = New System.Drawing.Size(200, 28)
        Me.cboUsers.TabIndex = 1
        Me.cboUsers.ValueMember = "Username"
        '
        'AccountsBindingSource
        '
        Me.AccountsBindingSource.DataMember = "Accounts"
        Me.AccountsBindingSource.DataSource = Me.GSCDataSet
        '
        'GSCDataSet
        '
        Me.GSCDataSet.DataSetName = "GSCDataSet"
        Me.GSCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtMints
        '
        Me.txtMints.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMints.Location = New System.Drawing.Point(216, 144)
        Me.txtMints.Name = "txtMints"
        Me.txtMints.Size = New System.Drawing.Size(161, 27)
        Me.txtMints.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "UserName:"
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Location = New System.Drawing.Point(177, 87)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 27)
        Me.dtpDate.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(263, 385)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(114, 38)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(396, 385)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(114, 38)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(118, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ThinMints:"
        '
        'txtLites
        '
        Me.txtLites.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLites.Location = New System.Drawing.Point(216, 193)
        Me.txtLites.Name = "txtLites"
        Me.txtLites.Size = New System.Drawing.Size(161, 27)
        Me.txtLites.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Caramel deLites:"
        '
        'txtPatties
        '
        Me.txtPatties.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatties.Location = New System.Drawing.Point(216, 235)
        Me.txtPatties.Name = "txtPatties"
        Me.txtPatties.Size = New System.Drawing.Size(161, 27)
        Me.txtPatties.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "PeanutButter Patties:"
        '
        'txtBread
        '
        Me.txtBread.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBread.Location = New System.Drawing.Point(216, 277)
        Me.txtBread.Name = "txtBread"
        Me.txtBread.Size = New System.Drawing.Size(161, 27)
        Me.txtBread.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(106, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "ShortBread:"
        '
        'txtZip
        '
        Me.txtZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.Location = New System.Drawing.Point(216, 314)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(161, 27)
        Me.txtZip.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(133, 317)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Zipcode:"
        '
        'txtComment
        '
        Me.txtComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComment.Location = New System.Drawing.Point(415, 53)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(223, 251)
        Me.txtComment.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(411, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Comments:"
        '
        'AccountsTableAdapter
        '
        Me.AccountsTableAdapter.ClearBeforeFill = True
        '
        'NewInven
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 435)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtBread)
        Me.Controls.Add(Me.txtPatties)
        Me.Controls.Add(Me.txtLites)
        Me.Controls.Add(Me.txtMints)
        Me.Controls.Add(Me.cboUsers)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSub)
        Me.Name = "NewInven"
        Me.Text = "NewInven"
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSub As Button
    Friend WithEvents cboUsers As ComboBox
    Friend WithEvents txtMints As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLites As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPatties As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBread As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtComment As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GSCDataSet As GSCDataSet
    Friend WithEvents AccountsBindingSource As BindingSource
    Friend WithEvents AccountsTableAdapter As GSCDataSetTableAdapters.AccountsTableAdapter
End Class
