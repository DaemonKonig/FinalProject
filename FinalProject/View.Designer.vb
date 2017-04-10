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
        Me.dvgCookies = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCompTo = New System.Windows.Forms.Button()
        Me.rdoSold = New System.Windows.Forms.RadioButton()
        Me.rdoInvent = New System.Windows.Forms.RadioButton()
        Me.cboSrchFor = New System.Windows.Forms.ComboBox()
        Me.dvgInven = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSCDataSet1 = New FinalProject.GSCDataSet()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThinMintsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaramelDeLitesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeanutButterPattiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShortBreadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CookiesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSCDataSet = New FinalProject.GSCDataSet()
        Me.CookiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CookiesTableAdapter = New FinalProject.GSCDataSetTableAdapters.CookiesTableAdapter()
        Me.InventoryTableAdapter = New FinalProject.GSCDataSetTableAdapters.InventoryTableAdapter()
        CType(Me.dvgCookies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgInven, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSCDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CookiesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CookiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgCookies
        '
        Me.dvgCookies.AutoGenerateColumns = False
        Me.dvgCookies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgCookies.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ThinMintsDataGridViewTextBoxColumn, Me.CaramelDeLitesDataGridViewTextBoxColumn, Me.PeanutButterPattiesDataGridViewTextBoxColumn, Me.ShortBreadDataGridViewTextBoxColumn, Me.CommentsDataGridViewTextBoxColumn})
        Me.dvgCookies.DataSource = Me.CookiesBindingSource1
        Me.dvgCookies.Location = New System.Drawing.Point(12, 62)
        Me.dvgCookies.Name = "dvgCookies"
        Me.dvgCookies.RowTemplate.Height = 24
        Me.dvgCookies.Size = New System.Drawing.Size(779, 379)
        Me.dvgCookies.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(538, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(82, 30)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(234, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search By Username"
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
        'btnCompTo
        '
        Me.btnCompTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompTo.Location = New System.Drawing.Point(658, 11)
        Me.btnCompTo.Name = "btnCompTo"
        Me.btnCompTo.Size = New System.Drawing.Size(118, 30)
        Me.btnCompTo.TabIndex = 1
        Me.btnCompTo.Text = "Compare To"
        Me.btnCompTo.UseVisualStyleBackColor = True
        '
        'rdoSold
        '
        Me.rdoSold.AutoSize = True
        Me.rdoSold.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSold.Location = New System.Drawing.Point(12, 5)
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
        Me.rdoInvent.Location = New System.Drawing.Point(12, 32)
        Me.rdoInvent.Name = "rdoInvent"
        Me.rdoInvent.Size = New System.Drawing.Size(97, 24)
        Me.rdoInvent.TabIndex = 6
        Me.rdoInvent.TabStop = True
        Me.rdoInvent.Text = "Inventory"
        Me.rdoInvent.UseVisualStyleBackColor = True
        '
        'cboSrchFor
        '
        Me.cboSrchFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSrchFor.FormattingEnabled = True
        Me.cboSrchFor.Location = New System.Drawing.Point(409, 14)
        Me.cboSrchFor.Name = "cboSrchFor"
        Me.cboSrchFor.Size = New System.Drawing.Size(121, 28)
        Me.cboSrchFor.TabIndex = 4
        '
        'dvgInven
        '
        Me.dvgInven.AutoGenerateColumns = False
        Me.dvgInven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgInven.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dvgInven.DataSource = Me.InventoryBindingSource2
        Me.dvgInven.Location = New System.Drawing.Point(12, 62)
        Me.dvgInven.Name = "dvgInven"
        Me.dvgInven.RowTemplate.Height = 24
        Me.dvgInven.Size = New System.Drawing.Size(779, 379)
        Me.dvgInven.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ThinMints"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ThinMints"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Caramel deLites"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Caramel deLites"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PeanutButter Patties"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PeanutButter Patties"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ShortBread"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ShortBread"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'InventoryBindingSource2
        '
        Me.InventoryBindingSource2.DataMember = "Inventory"
        Me.InventoryBindingSource2.DataSource = Me.GSCDataSet1
        '
        'GSCDataSet1
        '
        Me.GSCDataSet1.DataSetName = "GSCDataSet"
        Me.GSCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ThinMintsDataGridViewTextBoxColumn
        '
        Me.ThinMintsDataGridViewTextBoxColumn.DataPropertyName = "ThinMints"
        Me.ThinMintsDataGridViewTextBoxColumn.HeaderText = "ThinMints"
        Me.ThinMintsDataGridViewTextBoxColumn.Name = "ThinMintsDataGridViewTextBoxColumn"
        Me.ThinMintsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CaramelDeLitesDataGridViewTextBoxColumn
        '
        Me.CaramelDeLitesDataGridViewTextBoxColumn.DataPropertyName = "Caramel deLites"
        Me.CaramelDeLitesDataGridViewTextBoxColumn.HeaderText = "Caramel deLites"
        Me.CaramelDeLitesDataGridViewTextBoxColumn.Name = "CaramelDeLitesDataGridViewTextBoxColumn"
        Me.CaramelDeLitesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PeanutButterPattiesDataGridViewTextBoxColumn
        '
        Me.PeanutButterPattiesDataGridViewTextBoxColumn.DataPropertyName = "PeanutButter Patties"
        Me.PeanutButterPattiesDataGridViewTextBoxColumn.HeaderText = "PeanutButter Patties"
        Me.PeanutButterPattiesDataGridViewTextBoxColumn.Name = "PeanutButterPattiesDataGridViewTextBoxColumn"
        Me.PeanutButterPattiesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShortBreadDataGridViewTextBoxColumn
        '
        Me.ShortBreadDataGridViewTextBoxColumn.DataPropertyName = "ShortBread"
        Me.ShortBreadDataGridViewTextBoxColumn.HeaderText = "ShortBread"
        Me.ShortBreadDataGridViewTextBoxColumn.Name = "ShortBreadDataGridViewTextBoxColumn"
        Me.ShortBreadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CommentsDataGridViewTextBoxColumn
        '
        Me.CommentsDataGridViewTextBoxColumn.DataPropertyName = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.HeaderText = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.Name = "CommentsDataGridViewTextBoxColumn"
        Me.CommentsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CookiesBindingSource1
        '
        Me.CookiesBindingSource1.DataMember = "Cookies"
        Me.CookiesBindingSource1.DataSource = Me.GSCDataSet1
        '
        'InventoryBindingSource1
        '
        Me.InventoryBindingSource1.DataMember = "Inventory"
        Me.InventoryBindingSource1.DataSource = Me.GSCDataSet1
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
        'CookiesBindingSource
        '
        Me.CookiesBindingSource.DataMember = "Cookies"
        Me.CookiesBindingSource.DataSource = Me.GSCDataSet
        '
        'CookiesTableAdapter
        '
        Me.CookiesTableAdapter.ClearBeforeFill = True
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 489)
        Me.Controls.Add(Me.dvgInven)
        Me.Controls.Add(Me.rdoInvent)
        Me.Controls.Add(Me.rdoSold)
        Me.Controls.Add(Me.cboSrchFor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCompTo)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dvgCookies)
        Me.Name = "View"
        Me.Text = "Cookie Sheets"
        CType(Me.dvgCookies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgInven, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSCDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CookiesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CookiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dvgCookies As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnCompTo As Button
    Friend WithEvents rdoSold As RadioButton
    Friend WithEvents rdoInvent As RadioButton
    Friend WithEvents GSCDataSet As GSCDataSet
    Friend WithEvents CookiesBindingSource As BindingSource
    Friend WithEvents CookiesTableAdapter As GSCDataSetTableAdapters.CookiesTableAdapter
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As GSCDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ThinMintsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CaramelDeLitesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeanutButterPattiesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShortBreadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cboSrchFor As ComboBox
    Friend WithEvents GSCDataSet1 As GSCDataSet
    Friend WithEvents CookiesBindingSource1 As BindingSource
    Friend WithEvents dvgInven As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents InventoryBindingSource1 As BindingSource
    Friend WithEvents InventoryBindingSource2 As BindingSource
End Class
