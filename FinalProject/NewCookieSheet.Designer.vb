<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCookieSheet
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMints = New System.Windows.Forms.TextBox()
        Me.btnCncl = New System.Windows.Forms.Button()
        Me.txtBread = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCaramel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPatties = New System.Windows.Forms.TextBox()
        Me.lblVar = New System.Windows.Forms.Label()
        Me.btnClr = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboUsers = New System.Windows.Forms.ComboBox()
        Me.GSCDataSet = New FinalProject.GSCDataSet()
        Me.CookiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CookiesTableAdapter = New FinalProject.GSCDataSetTableAdapters.CookiesTableAdapter()
        CType(Me.GSCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CookiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSub
        '
        Me.btnSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub.Location = New System.Drawing.Point(285, 382)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(87, 38)
        Me.btnSub.TabIndex = 7
        Me.btnSub.Text = "Submit"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Thin Mints:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMints
        '
        Me.txtMints.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMints.Location = New System.Drawing.Point(214, 118)
        Me.txtMints.Name = "txtMints"
        Me.txtMints.Size = New System.Drawing.Size(158, 27)
        Me.txtMints.TabIndex = 0
        '
        'btnCncl
        '
        Me.btnCncl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCncl.Location = New System.Drawing.Point(522, 382)
        Me.btnCncl.Name = "btnCncl"
        Me.btnCncl.Size = New System.Drawing.Size(87, 38)
        Me.btnCncl.TabIndex = 9
        Me.btnCncl.Text = "Cancel"
        Me.btnCncl.UseVisualStyleBackColor = True
        '
        'txtBread
        '
        Me.txtBread.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBread.Location = New System.Drawing.Point(214, 241)
        Me.txtBread.Name = "txtBread"
        Me.txtBread.Size = New System.Drawing.Size(158, 27)
        Me.txtBread.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ShortBread:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 20)
        Me.Label4.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Caramel deLites:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCaramel
        '
        Me.txtCaramel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaramel.Location = New System.Drawing.Point(214, 157)
        Me.txtCaramel.Name = "txtCaramel"
        Me.txtCaramel.Size = New System.Drawing.Size(158, 27)
        Me.txtCaramel.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Peanut Butter Patties:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPatties
        '
        Me.txtPatties.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatties.Location = New System.Drawing.Point(214, 199)
        Me.txtPatties.Name = "txtPatties"
        Me.txtPatties.Size = New System.Drawing.Size(158, 27)
        Me.txtPatties.TabIndex = 2
        '
        'lblVar
        '
        Me.lblVar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVar.Location = New System.Drawing.Point(12, -7)
        Me.lblVar.Name = "lblVar"
        Me.lblVar.Size = New System.Drawing.Size(786, 83)
        Me.lblVar.TabIndex = 1
        Me.lblVar.Text = "Please Enter the amount of each cookie sold, the date they were sold on, addition" &
    "al comments as needed, then click submit to submit the information."
        Me.lblVar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClr
        '
        Me.btnClr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClr.Location = New System.Drawing.Point(408, 382)
        Me.btnClr.Name = "btnClr"
        Me.btnClr.Size = New System.Drawing.Size(87, 38)
        Me.btnClr.TabIndex = 8
        Me.btnClr.Text = "Clear"
        Me.btnClr.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(136, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Date:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtComments
        '
        Me.txtComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComments.Location = New System.Drawing.Point(536, 103)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(244, 188)
        Me.txtComments.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(532, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Comments:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Location = New System.Drawing.Point(214, 289)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(158, 27)
        Me.dtpDate.TabIndex = 4
        '
        'txtZip
        '
        Me.txtZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.Location = New System.Drawing.Point(214, 338)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(158, 27)
        Me.txtZip.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(111, 341)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "ZipCode:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(120, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 20)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Users:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboUsers
        '
        Me.cboUsers.DataSource = Me.CookiesBindingSource
        Me.cboUsers.DisplayMember = "UserName"
        Me.cboUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUsers.FormattingEnabled = True
        Me.cboUsers.Location = New System.Drawing.Point(214, 77)
        Me.cboUsers.Name = "cboUsers"
        Me.cboUsers.Size = New System.Drawing.Size(158, 28)
        Me.cboUsers.TabIndex = 10
        Me.cboUsers.ValueMember = "UserName"
        '
        'GSCDataSet
        '
        Me.GSCDataSet.DataSetName = "GSCDataSet"
        Me.GSCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CookiesBindingSource
        '
        Me.CookiesBindingSource.DataMember = "Cookies"
        Me.CookiesBindingSource.DataSource = Me.GSCDataSet
        '
        'CookiesTableAdapter
        '
        Me.CookiesTableAdapter.ClearBeforeFill = True
        '
        'NewCookieSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 432)
        Me.Controls.Add(Me.cboUsers)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtBread)
        Me.Controls.Add(Me.txtPatties)
        Me.Controls.Add(Me.txtCaramel)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.txtMints)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblVar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClr)
        Me.Controls.Add(Me.btnCncl)
        Me.Controls.Add(Me.btnSub)
        Me.Name = "NewCookieSheet"
        Me.Text = "New Cookie Sheet"
        CType(Me.GSCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CookiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSub As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMints As TextBox
    Friend WithEvents btnCncl As Button
    Friend WithEvents txtBread As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCaramel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPatties As TextBox
    Friend WithEvents lblVar As Label
    Friend WithEvents btnClr As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtComments As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtZip As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cboUsers As ComboBox
    Friend WithEvents GSCDataSet As GSCDataSet
    Friend WithEvents CookiesBindingSource As BindingSource
    Friend WithEvents CookiesTableAdapter As GSCDataSetTableAdapters.CookiesTableAdapter
End Class
