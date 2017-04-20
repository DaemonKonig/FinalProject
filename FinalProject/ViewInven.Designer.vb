<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewInven
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
        Me.dgvInven = New System.Windows.Forms.DataGridView()
        Me.InventoryIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduledDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThinMintsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaramelDeLitesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeanutButterPattiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShortBreadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSCDataSet = New FinalProject.GSCDataSet()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.InventoryTableAdapter = New FinalProject.GSCDataSetTableAdapters.InventoryTableAdapter()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dgvInven, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInven
        '
        Me.dgvInven.AutoGenerateColumns = False
        Me.dgvInven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInven.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InventoryIdDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.ScheduledDataGridViewTextBoxColumn, Me.ThinMintsDataGridViewTextBoxColumn, Me.CaramelDeLitesDataGridViewTextBoxColumn, Me.PeanutButterPattiesDataGridViewTextBoxColumn, Me.ShortBreadDataGridViewTextBoxColumn, Me.CommentsDataGridViewTextBoxColumn, Me.ZipCodeDataGridViewTextBoxColumn})
        Me.dgvInven.DataSource = Me.InventoryBindingSource
        Me.dgvInven.Location = New System.Drawing.Point(12, 41)
        Me.dgvInven.Name = "dgvInven"
        Me.dgvInven.RowTemplate.Height = 24
        Me.dgvInven.Size = New System.Drawing.Size(681, 346)
        Me.dgvInven.TabIndex = 0
        '
        'InventoryIdDataGridViewTextBoxColumn
        '
        Me.InventoryIdDataGridViewTextBoxColumn.DataPropertyName = "InventoryId"
        Me.InventoryIdDataGridViewTextBoxColumn.HeaderText = "InventoryId"
        Me.InventoryIdDataGridViewTextBoxColumn.Name = "InventoryIdDataGridViewTextBoxColumn"
        Me.InventoryIdDataGridViewTextBoxColumn.ReadOnly = True
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
        'ZipCodeDataGridViewTextBoxColumn
        '
        Me.ZipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode"
        Me.ZipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode"
        Me.ZipCodeDataGridViewTextBoxColumn.Name = "ZipCodeDataGridViewTextBoxColumn"
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.GSCDataSet
        '
        'GSCDataSet
        '
        Me.GSCDataSet.DataSetName = "GSCDataSet"
        Me.GSCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(230, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(78, 33)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(379, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(78, 33)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'ViewInven
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 399)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.dgvInven)
        Me.Name = "ViewInven"
        Me.Text = "ViewInven"
        CType(Me.dgvInven, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvInven As DataGridView
    Friend WithEvents btnEdit As Button
    Friend WithEvents GSCDataSet As GSCDataSet
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As GSCDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents InventoryIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScheduledDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ThinMintsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CaramelDeLitesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeanutButterPattiesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShortBreadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZipCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As Button
End Class
