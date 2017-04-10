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
        Me.dgvCookie = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThinMintsDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaramelDeLitesDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeanutButterPattiesDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShortBreadDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvInvent = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThinMintsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaramelDeLitesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeanutButterPattiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShortBreadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipCodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CookiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCookie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInvent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(360, 447)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 30)
        Me.btnClose.TabIndex = 1
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
        Me.rdoSold.TabIndex = 5
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
        Me.rdoInvent.TabIndex = 6
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
        'dgvCookie
        '
        Me.dgvCookie.AutoGenerateColumns = False
        Me.dgvCookie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCookie.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.UserNameDataGridViewTextBoxColumn1, Me.DateDataGridViewTextBoxColumn1, Me.ThinMintsDataGridViewTextBoxColumn1, Me.CaramelDeLitesDataGridViewTextBoxColumn1, Me.PeanutButterPattiesDataGridViewTextBoxColumn1, Me.ShortBreadDataGridViewTextBoxColumn1, Me.CommentsDataGridViewTextBoxColumn1, Me.ZipCodeDataGridViewTextBoxColumn})
        Me.dgvCookie.DataSource = Me.CookiesBindingSource
        Me.dgvCookie.Location = New System.Drawing.Point(12, 62)
        Me.dgvCookie.Name = "dgvCookie"
        Me.dgvCookie.RowTemplate.Height = 24
        Me.dgvCookie.Size = New System.Drawing.Size(779, 379)
        Me.dgvCookie.TabIndex = 11
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'UserNameDataGridViewTextBoxColumn1
        '
        Me.UserNameDataGridViewTextBoxColumn1.DataPropertyName = "UserName"
        Me.UserNameDataGridViewTextBoxColumn1.HeaderText = "UserName"
        Me.UserNameDataGridViewTextBoxColumn1.Name = "UserNameDataGridViewTextBoxColumn1"
        '
        'DateDataGridViewTextBoxColumn1
        '
        Me.DateDataGridViewTextBoxColumn1.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn1.Name = "DateDataGridViewTextBoxColumn1"
        '
        'ThinMintsDataGridViewTextBoxColumn1
        '
        Me.ThinMintsDataGridViewTextBoxColumn1.DataPropertyName = "ThinMints"
        Me.ThinMintsDataGridViewTextBoxColumn1.HeaderText = "ThinMints"
        Me.ThinMintsDataGridViewTextBoxColumn1.Name = "ThinMintsDataGridViewTextBoxColumn1"
        '
        'CaramelDeLitesDataGridViewTextBoxColumn1
        '
        Me.CaramelDeLitesDataGridViewTextBoxColumn1.DataPropertyName = "Caramel deLites"
        Me.CaramelDeLitesDataGridViewTextBoxColumn1.HeaderText = "Caramel deLites"
        Me.CaramelDeLitesDataGridViewTextBoxColumn1.Name = "CaramelDeLitesDataGridViewTextBoxColumn1"
        '
        'PeanutButterPattiesDataGridViewTextBoxColumn1
        '
        Me.PeanutButterPattiesDataGridViewTextBoxColumn1.DataPropertyName = "PeanutButter Patties"
        Me.PeanutButterPattiesDataGridViewTextBoxColumn1.HeaderText = "PeanutButter Patties"
        Me.PeanutButterPattiesDataGridViewTextBoxColumn1.Name = "PeanutButterPattiesDataGridViewTextBoxColumn1"
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
        Me.dgvInvent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.ThinMintsDataGridViewTextBoxColumn, Me.CaramelDeLitesDataGridViewTextBoxColumn, Me.PeanutButterPattiesDataGridViewTextBoxColumn, Me.ShortBreadDataGridViewTextBoxColumn, Me.CommentsDataGridViewTextBoxColumn, Me.ZipCodeDataGridViewTextBoxColumn1})
        Me.dgvInvent.DataSource = Me.InventoryBindingSource
        Me.dgvInvent.Location = New System.Drawing.Point(12, 62)
        Me.dgvInvent.Name = "dgvInvent"
        Me.dgvInvent.RowTemplate.Height = 24
        Me.dgvInvent.Size = New System.Drawing.Size(779, 379)
        Me.dgvInvent.TabIndex = 12
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'ThinMintsDataGridViewTextBoxColumn
        '
        Me.ThinMintsDataGridViewTextBoxColumn.DataPropertyName = "ThinMints"
        Me.ThinMintsDataGridViewTextBoxColumn.HeaderText = "ThinMints"
        Me.ThinMintsDataGridViewTextBoxColumn.Name = "ThinMintsDataGridViewTextBoxColumn"
        '
        'CaramelDeLitesDataGridViewTextBoxColumn
        '
        Me.CaramelDeLitesDataGridViewTextBoxColumn.DataPropertyName = "Caramel deLites"
        Me.CaramelDeLitesDataGridViewTextBoxColumn.HeaderText = "Caramel deLites"
        Me.CaramelDeLitesDataGridViewTextBoxColumn.Name = "CaramelDeLitesDataGridViewTextBoxColumn"
        '
        'PeanutButterPattiesDataGridViewTextBoxColumn
        '
        Me.PeanutButterPattiesDataGridViewTextBoxColumn.DataPropertyName = "PeanutButter Patties"
        Me.PeanutButterPattiesDataGridViewTextBoxColumn.HeaderText = "PeanutButter Patties"
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
        Me.Controls.Add(Me.dgvCookie)
        Me.Controls.Add(Me.rdoInvent)
        Me.Controls.Add(Me.rdoSold)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "View"
        Me.Text = "Cookie Sheets"
        CType(Me.CookiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCookie, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvCookie As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ThinMintsDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CaramelDeLitesDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PeanutButterPattiesDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ShortBreadDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ZipCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgvInvent As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ThinMintsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CaramelDeLitesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeanutButterPattiesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShortBreadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZipCodeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
