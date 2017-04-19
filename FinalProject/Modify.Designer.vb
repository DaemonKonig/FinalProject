<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modify
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
        Me.txtClose = New System.Windows.Forms.Button()
        Me.lblModMssg = New System.Windows.Forms.Label()
        Me.cboTrpr = New System.Windows.Forms.ComboBox()
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSCDataSet = New FinalProject.GSCDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtMints = New System.Windows.Forms.TextBox()
        Me.txtLites = New System.Windows.Forms.TextBox()
        Me.txtPatties = New System.Windows.Forms.TextBox()
        Me.txtBread = New System.Windows.Forms.TextBox()
        Me.derp3 = New System.Windows.Forms.Label()
        Me.derp2 = New System.Windows.Forms.Label()
        Me.derp1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AccountsTableAdapter = New FinalProject.GSCDataSetTableAdapters.AccountsTableAdapter()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtClose
        '
        Me.txtClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClose.Location = New System.Drawing.Point(667, 378)
        Me.txtClose.Name = "txtClose"
        Me.txtClose.Size = New System.Drawing.Size(75, 31)
        Me.txtClose.TabIndex = 3
        Me.txtClose.Text = "Close"
        Me.txtClose.UseVisualStyleBackColor = True
        '
        'lblModMssg
        '
        Me.lblModMssg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModMssg.Location = New System.Drawing.Point(12, 9)
        Me.lblModMssg.Name = "lblModMssg"
        Me.lblModMssg.Size = New System.Drawing.Size(730, 61)
        Me.lblModMssg.TabIndex = 2
        Me.lblModMssg.Text = "Please select Troopers Name and enter the date of submission. Then Enter the Corr" &
    "ect Information  and click Submit to Submit  the correct information."
        Me.lblModMssg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboTrpr
        '
        Me.cboTrpr.DataSource = Me.AccountsBindingSource
        Me.cboTrpr.DisplayMember = "Username"
        Me.cboTrpr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTrpr.FormattingEnabled = True
        Me.cboTrpr.Location = New System.Drawing.Point(263, 73)
        Me.cboTrpr.Name = "cboTrpr"
        Me.cboTrpr.Size = New System.Drawing.Size(144, 28)
        Me.cboTrpr.TabIndex = 0
        Me.cboTrpr.ValueMember = "Username"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(142, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Trooper:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSub
        '
        Me.btnSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub.Location = New System.Drawing.Point(474, 378)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(75, 31)
        Me.btnSub.TabIndex = 2
        Me.btnSub.Text = "Submit"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(127, 174)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(87, 20)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "ThinMints:"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMints
        '
        Me.txtMints.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMints.Location = New System.Drawing.Point(263, 167)
        Me.txtMints.Name = "txtMints"
        Me.txtMints.Size = New System.Drawing.Size(100, 27)
        Me.txtMints.TabIndex = 1
        '
        'txtLites
        '
        Me.txtLites.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLites.Location = New System.Drawing.Point(263, 218)
        Me.txtLites.Name = "txtLites"
        Me.txtLites.Size = New System.Drawing.Size(100, 27)
        Me.txtLites.TabIndex = 1
        '
        'txtPatties
        '
        Me.txtPatties.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatties.Location = New System.Drawing.Point(263, 268)
        Me.txtPatties.Name = "txtPatties"
        Me.txtPatties.Size = New System.Drawing.Size(100, 27)
        Me.txtPatties.TabIndex = 1
        '
        'txtBread
        '
        Me.txtBread.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBread.Location = New System.Drawing.Point(263, 317)
        Me.txtBread.Name = "txtBread"
        Me.txtBread.Size = New System.Drawing.Size(100, 27)
        Me.txtBread.TabIndex = 1
        '
        'derp3
        '
        Me.derp3.AutoSize = True
        Me.derp3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.derp3.Location = New System.Drawing.Point(89, 225)
        Me.derp3.Name = "derp3"
        Me.derp3.Size = New System.Drawing.Size(137, 20)
        Me.derp3.TabIndex = 2
        Me.derp3.Text = "Caramel deLites:"
        Me.derp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'derp2
        '
        Me.derp2.AutoSize = True
        Me.derp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.derp2.Location = New System.Drawing.Point(57, 271)
        Me.derp2.Name = "derp2"
        Me.derp2.Size = New System.Drawing.Size(169, 20)
        Me.derp2.TabIndex = 2
        Me.derp2.Text = "PeanutButter Patties:"
        Me.derp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'derp1
        '
        Me.derp1.AutoSize = True
        Me.derp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.derp1.Location = New System.Drawing.Point(127, 320)
        Me.derp1.Name = "derp1"
        Me.derp1.Size = New System.Drawing.Size(99, 20)
        Me.derp1.TabIndex = 2
        Me.derp1.Text = "ShortBread:"
        Me.derp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(103, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Date of entry:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtComment
        '
        Me.txtComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComment.Location = New System.Drawing.Point(474, 120)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(268, 206)
        Me.txtComment.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(470, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Comments:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(571, 378)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 31)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(263, 120)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(144, 27)
        Me.dtpDate.TabIndex = 15
        '
        'txtZip
        '
        Me.txtZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.Location = New System.Drawing.Point(263, 361)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 27)
        Me.txtZip.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 364)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ZipCode:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AccountsTableAdapter
        '
        Me.AccountsTableAdapter.ClearBeforeFill = True
        '
        'Modify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 452)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.cboTrpr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.derp1)
        Me.Controls.Add(Me.derp2)
        Me.Controls.Add(Me.derp3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblModMssg)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtBread)
        Me.Controls.Add(Me.txtPatties)
        Me.Controls.Add(Me.txtLites)
        Me.Controls.Add(Me.txtMints)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.txtClose)
        Me.Name = "Modify"
        Me.Text = "Modify Cookies"
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtClose As Button
    Friend WithEvents lblModMssg As Label
    Friend WithEvents cboTrpr As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSub As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents txtMints As TextBox
    Friend WithEvents txtLites As TextBox
    Friend WithEvents txtPatties As TextBox
    Friend WithEvents txtBread As TextBox
    Friend WithEvents derp3 As Label
    Friend WithEvents derp2 As Label
    Friend WithEvents derp1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtComment As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtZip As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GSCDataSet As GSCDataSet
    Friend WithEvents AccountsBindingSource As BindingSource
    Friend WithEvents AccountsTableAdapter As GSCDataSetTableAdapters.AccountsTableAdapter
End Class
