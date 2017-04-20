<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewMod
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
        Me.dgvCookies = New System.Windows.Forms.DataGridView()
        Me.CookieIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduledDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThinMintsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarameldeLitesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeanutButterPattiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShortBreadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CookiesBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSCDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSCDataSet = New FinalProject.GSCDataSet()
        Me.CookiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CookiesTableAdapter = New FinalProject.GSCDataSetTableAdapters.CookiesTableAdapter()
        Me.CookiesInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableAdapter = New FinalProject.GSCDataSetTableAdapters.InventoryTableAdapter()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.CookiesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CookiesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dgvCookies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CookiesBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSCDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CookiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CookiesInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CookiesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CookiesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCookies
        '
        Me.dgvCookies.AllowUserToDeleteRows = False
        Me.dgvCookies.AutoGenerateColumns = False
        Me.dgvCookies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCookies.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CookieIdDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.ScheduledDataGridViewTextBoxColumn, Me.ThinMintsDataGridViewTextBoxColumn, Me.CarameldeLitesDataGridViewTextBoxColumn, Me.PeanutButterPattiesDataGridViewTextBoxColumn, Me.ShortBreadDataGridViewTextBoxColumn, Me.CommentsDataGridViewTextBoxColumn, Me.ZipCodeDataGridViewTextBoxColumn})
        Me.dgvCookies.DataSource = Me.CookiesBindingSource3
        Me.dgvCookies.Location = New System.Drawing.Point(0, 50)
        Me.dgvCookies.Name = "dgvCookies"
        Me.dgvCookies.RowTemplate.Height = 24
        Me.dgvCookies.Size = New System.Drawing.Size(751, 377)
        Me.dgvCookies.TabIndex = 0
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
        'CookiesBindingSource3
        '
        Me.CookiesBindingSource3.DataMember = "Cookies"
        Me.CookiesBindingSource3.DataSource = Me.GSCDataSetBindingSource
        '
        'GSCDataSetBindingSource
        '
        Me.GSCDataSetBindingSource.DataSource = Me.GSCDataSet
        Me.GSCDataSetBindingSource.Position = 0
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
        'CookiesInventoryBindingSource
        '
        Me.CookiesInventoryBindingSource.DataMember = "Cookies_Inventory"
        Me.CookiesInventoryBindingSource.DataSource = Me.CookiesBindingSource
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(157, 12)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(98, 28)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'CookiesBindingSource1
        '
        Me.CookiesBindingSource1.DataMember = "Cookies"
        Me.CookiesBindingSource1.DataSource = Me.GSCDataSetBindingSource
        '
        'CookiesBindingSource2
        '
        Me.CookiesBindingSource2.DataMember = "Cookies"
        Me.CookiesBindingSource2.DataSource = Me.GSCDataSet
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(334, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(98, 28)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'ViewMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 428)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.dgvCookies)
        Me.Name = "ViewMod"
        Me.Text = "ViewMod"
        CType(Me.dgvCookies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CookiesBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSCDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CookiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CookiesInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CookiesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CookiesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCookies As DataGridView
    Friend WithEvents GSCDataSet As GSCDataSet
    Friend WithEvents CookiesBindingSource As BindingSource
    Friend WithEvents CookiesTableAdapter As GSCDataSetTableAdapters.CookiesTableAdapter
    Friend WithEvents CookiesInventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As GSCDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents btnEdit As Button
    Friend WithEvents CookiesBindingSource1 As BindingSource
    Friend WithEvents GSCDataSetBindingSource As BindingSource
    Friend WithEvents CookiesBindingSource2 As BindingSource
    Friend WithEvents CookieIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScheduledDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ThinMintsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarameldeLitesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeanutButterPattiesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShortBreadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZipCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CookiesBindingSource3 As BindingSource
    Friend WithEvents btnDelete As Button
End Class
