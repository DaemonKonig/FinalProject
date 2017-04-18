<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class View
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.rdoSold = New System.Windows.Forms.RadioButton()
        Me.rdoInvent = New System.Windows.Forms.RadioButton()
        Me.CookiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSCDataSet = New FinalProject.GSCDataSet()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableAdapter = New FinalProject.GSCDataSetTableAdapters.InventoryTableAdapter()
        Me.CookiesTableAdapter = New FinalProject.GSCDataSetTableAdapters.CookiesTableAdapter()
        Me.CookiesInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dvgCookie = New System.Windows.Forms.DataGridView()
        Me.CookieIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduledDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThinMintsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarameldeLitesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeanutButterPattiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShortBreadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvInvent = New System.Windows.Forms.DataGridView()
        Me.InventoryIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduledDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThinMintsDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaramelDeLitesDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeanutButterPattiesDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShortBreadDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipCodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CookiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CookiesInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgCookie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInvent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(360, 447)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 30)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'rdoSold
        '
        Me.rdoSold.AutoSize = True
        Me.rdoSold.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSold.Location = New System.Drawing.Point(406, 12)
        Me.rdoSold.Name = "rdoSold"
        Me.rdoSold.Size = New System.Drawing.Size(128, 24)
        Me.rdoSold.TabIndex = 1
        Me.rdoSold.TabStop = True
        Me.rdoSold.Text = "Cookies Sold"
        Me.rdoSold.UseVisualStyleBackColor = True
        '
        'rdoInvent
        '
        Me.rdoInvent.AutoSize = True
        Me.rdoInvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoInvent.Location = New System.Drawing.Point(161, 12)
        Me.rdoInvent.Name = "rdoInvent"
        Me.rdoInvent.Size = New System.Drawing.Size(97, 24)
        Me.rdoInvent.TabIndex = 0
        Me.rdoInvent.TabStop = True
        Me.rdoInvent.Text = "Inventory"
        Me.rdoInvent.UseVisualStyleBackColor = True
        '
        'CookiesBindingSource
        '
        Me.CookiesBindingSource.DataMember = "Cookies"
        Me.CookiesBindingSource.DataSource = Me.GSCDataSet
        '
        'GSCDataSet
        '
        Me.GSCDataSet.DataSetName = "GSCDataSet"
        Me.GSCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.GSCDataSet
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'CookiesTableAdapter
        '
        Me.CookiesTableAdapter.ClearBeforeFill = True
        '
        'CookiesInventoryBindingSource
        '
        Me.CookiesInventoryBindingSource.DataMember = "Cookies_Inventory"
        Me.CookiesInventoryBindingSource.DataSource = Me.CookiesBindingSource
        '
        'dvgCookie
        '
        Me.dvgCookie.AutoGenerateColumns = False
        Me.dvgCookie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgCookie.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CookieIdDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.ScheduledDataGridViewTextBoxColumn, Me.ThinMintsDataGridViewTextBoxColumn, Me.CarameldeLitesDataGridViewTextBoxColumn, Me.PeanutButterPattiesDataGridViewTextBoxColumn, Me.ShortBreadDataGridViewTextBoxColumn, Me.CommentsDataGridViewTextBoxColumn, Me.ZipCodeDataGridViewTextBoxColumn})
        Me.dvgCookie.DataSource = Me.CookiesBindingSource
        Me.dvgCookie.Location = New System.Drawing.Point(12, 42)
        Me.dvgCookie.Name = "dvgCookie"
        Me.dvgCookie.RowTemplate.Height = 24
        Me.dvgCookie.Size = New System.Drawing.Size(779, 387)
        Me.dvgCookie.TabIndex = 3
        '
        'CookieIdDataGridViewTextBoxColumn
        '
        Me.CookieIdDataGridViewTextBoxColumn.DataPropertyName = "CookieId"
        Me.CookieIdDataGridViewTextBoxColumn.HeaderText = "CookieId"
        Me.CookieIdDataGridViewTextBoxColumn.Name = "CookieIdDataGridViewTextBoxColumn"
        Me.CookieIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        '
        'ScheduledDataGridViewTextBoxColumn
        '
        Me.ScheduledDataGridViewTextBoxColumn.DataPropertyName = "Scheduled"
        Me.ScheduledDataGridViewTextBoxColumn.HeaderText = "Scheduled"
        Me.ScheduledDataGridViewTextBoxColumn.Name = "ScheduledDataGridViewTextBoxColumn"
        '
        'ThinMintsDataGridViewTextBoxColumn
        '
        Me.ThinMintsDataGridViewTextBoxColumn.DataPropertyName = "ThinMints"
        Me.ThinMintsDataGridViewTextBoxColumn.HeaderText = "ThinMints"
        Me.ThinMintsDataGridViewTextBoxColumn.Name = "ThinMintsDataGridViewTextBoxColumn"
        '
        'CarameldeLitesDataGridViewTextBoxColumn
        '
        Me.CarameldeLitesDataGridViewTextBoxColumn.DataPropertyName = "Caramel_deLites"
        Me.CarameldeLitesDataGridViewTextBoxColumn.HeaderText = "Caramel_deLites"
        Me.CarameldeLitesDataGridViewTextBoxColumn.Name = "CarameldeLitesDataGridViewTextBoxColumn"
        '
        'PeanutButterPattiesDataGridViewTextBoxColumn
        '
        Me.PeanutButterPattiesDataGridViewTextBoxColumn.DataPropertyName = "PeanutButter_Patties"
        Me.PeanutButterPattiesDataGridViewTextBoxColumn.HeaderText = "PeanutButter_Patties"
        Me.PeanutButterPattiesDataGridViewTextBoxColumn.Name = "PeanutButterPattiesDataGridViewTextBoxColumn"
        '
        'ShortBreadDataGridViewTextBoxColumn
        '
        Me.ShortBreadDataGridViewTextBoxColumn.DataPropertyName = "ShortBread"
        Me.ShortBreadDataGridViewTextBoxColumn.HeaderText = "ShortBread"
        Me.ShortBreadDataGridViewTextBoxColumn.Name = "ShortBreadDataGridViewTextBoxColumn"
        '
        'CommentsDataGridViewTextBoxColumn
        '
        Me.CommentsDataGridViewTextBoxColumn.DataPropertyName = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.HeaderText = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.Name = "CommentsDataGridViewTextBoxColumn"
        '
        'ZipCodeDataGridViewTextBoxColumn
        '
        Me.ZipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode"
        Me.ZipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode"
        Me.ZipCodeDataGridViewTextBoxColumn.Name = "ZipCodeDataGridViewTextBoxColumn"
        '
        'dgvInvent
        '
        Me.dgvInvent.AutoGenerateColumns = False
        Me.dgvInvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InventoryIdDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn1, Me.ScheduledDataGridViewTextBoxColumn1, Me.ThinMintsDataGridViewTextBoxColumn1, Me.CaramelDeLitesDataGridViewTextBoxColumn2, Me.PeanutButterPattiesDataGridViewTextBoxColumn2, Me.ShortBreadDataGridViewTextBoxColumn1, Me.CommentsDataGridViewTextBoxColumn1, Me.ZipCodeDataGridViewTextBoxColumn1})
        Me.dgvInvent.DataSource = Me.InventoryBindingSource
        Me.dgvInvent.Location = New System.Drawing.Point(12, 42)
        Me.dgvInvent.Name = "dgvInvent"
        Me.dgvInvent.RowTemplate.Height = 24
        Me.dgvInvent.Size = New System.Drawing.Size(779, 387)
        Me.dgvInvent.TabIndex = 4
        '
        'InventoryIdDataGridViewTextBoxColumn
        '
        Me.InventoryIdDataGridViewTextBoxColumn.DataPropertyName = "InventoryId"
        Me.InventoryIdDataGridViewTextBoxColumn.HeaderText = "InventoryId"
        Me.InventoryIdDataGridViewTextBoxColumn.Name = "InventoryIdDataGridViewTextBoxColumn"
        Me.InventoryIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserNameDataGridViewTextBoxColumn1
        '
        Me.UserNameDataGridViewTextBoxColumn1.DataPropertyName = "UserName"
        Me.UserNameDataGridViewTextBoxColumn1.HeaderText = "UserName"
        Me.UserNameDataGridViewTextBoxColumn1.Name = "UserNameDataGridViewTextBoxColumn1"
        '
        'ScheduledDataGridViewTextBoxColumn1
        '
        Me.ScheduledDataGridViewTextBoxColumn1.DataPropertyName = "Scheduled"
        Me.ScheduledDataGridViewTextBoxColumn1.HeaderText = "Scheduled"
        Me.ScheduledDataGridViewTextBoxColumn1.Name = "ScheduledDataGridViewTextBoxColumn1"
        '
        'ThinMintsDataGridViewTextBoxColumn1
        '
        Me.ThinMintsDataGridViewTextBoxColumn1.DataPropertyName = "ThinMints"
        Me.ThinMintsDataGridViewTextBoxColumn1.HeaderText = "ThinMints"
        Me.ThinMintsDataGridViewTextBoxColumn1.Name = "ThinMintsDataGridViewTextBoxColumn1"
        '
        'CaramelDeLitesDataGridViewTextBoxColumn2
        '
        Me.CaramelDeLitesDataGridViewTextBoxColumn2.DataPropertyName = "Caramel deLites"
        Me.CaramelDeLitesDataGridViewTextBoxColumn2.HeaderText = "Caramel deLites"
        Me.CaramelDeLitesDataGridViewTextBoxColumn2.Name = "CaramelDeLitesDataGridViewTextBoxColumn2"
        '
        'PeanutButterPattiesDataGridViewTextBoxColumn2
        '
        Me.PeanutButterPattiesDataGridViewTextBoxColumn2.DataPropertyName = "PeanutButter Patties"
        Me.PeanutButterPattiesDataGridViewTextBoxColumn2.HeaderText = "PeanutButter Patties"
        Me.PeanutButterPattiesDataGridViewTextBoxColumn2.Name = "PeanutButterPattiesDataGridViewTextBoxColumn2"
        '
        'ShortBreadDataGridViewTextBoxColumn1
        '
        Me.ShortBreadDataGridViewTextBoxColumn1.DataPropertyName = "ShortBread"
        Me.ShortBreadDataGridViewTextBoxColumn1.HeaderText = "ShortBread"
        Me.ShortBreadDataGridViewTextBoxColumn1.Name = "ShortBreadDataGridViewTextBoxColumn1"
        '
        'CommentsDataGridViewTextBoxColumn1
        '
        Me.CommentsDataGridViewTextBoxColumn1.DataPropertyName = "Comments"
        Me.CommentsDataGridViewTextBoxColumn1.HeaderText = "Comments"
        Me.CommentsDataGridViewTextBoxColumn1.Name = "CommentsDataGridViewTextBoxColumn1"
        '
        'ZipCodeDataGridViewTextBoxColumn1
        '
        Me.ZipCodeDataGridViewTextBoxColumn1.DataPropertyName = "ZipCode"
        Me.ZipCodeDataGridViewTextBoxColumn1.HeaderText = "ZipCode"
        Me.ZipCodeDataGridViewTextBoxColumn1.Name = "ZipCodeDataGridViewTextBoxColumn1"
        '
        'View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 489)
        Me.Controls.Add(Me.dgvInvent)
        Me.Controls.Add(Me.dvgCookie)
        Me.Controls.Add(Me.rdoInvent)
        Me.Controls.Add(Me.rdoSold)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "View"
        Me.Text = "Cookie Sheets"
        CType(Me.CookiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CookiesInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgCookie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInvent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As Button
    Friend WithEvents rdoSold As RadioButton
    Friend WithEvents rdoInvent As RadioButton
    Friend WithEvents GSCDataSet As GSCDataSet
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As GSCDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents CookiesBindingSource As BindingSource
    Friend WithEvents CookiesTableAdapter As GSCDataSetTableAdapters.CookiesTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CaramelDeLitesDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PeanutButterPattiesDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CookiesInventoryBindingSource As BindingSource
    Friend WithEvents dvgCookie As DataGridView
    Friend WithEvents CookieIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScheduledDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ThinMintsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarameldeLitesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeanutButterPattiesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShortBreadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZipCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgvInvent As DataGridView
    Friend WithEvents InventoryIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ScheduledDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ThinMintsDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CaramelDeLitesDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents PeanutButterPattiesDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ShortBreadDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ZipCodeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
