<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTroop
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
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSCDataSet = New FinalProject.GSCDataSet()
        Me.AccountsTableAdapter = New FinalProject.GSCDataSetTableAdapters.AccountsTableAdapter()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvTroop = New System.Windows.Forms.DataGridView()
        Me.AccountsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MessageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTroop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'AccountsTableAdapter
        '
        Me.AccountsTableAdapter.ClearBeforeFill = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(108, 12)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(84, 32)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(336, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(84, 32)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dgvTroop
        '
        Me.dgvTroop.AutoGenerateColumns = False
        Me.dgvTroop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTroop.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIdDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.MessageDataGridViewTextBoxColumn})
        Me.dgvTroop.DataSource = Me.AccountsBindingSource1
        Me.dgvTroop.Location = New System.Drawing.Point(12, 50)
        Me.dgvTroop.Name = "dgvTroop"
        Me.dgvTroop.RowTemplate.Height = 24
        Me.dgvTroop.Size = New System.Drawing.Size(558, 345)
        Me.dgvTroop.TabIndex = 2
        '
        'AccountsBindingSource1
        '
        Me.AccountsBindingSource1.DataMember = "Accounts"
        Me.AccountsBindingSource1.DataSource = Me.GSCDataSet
        '
        'UserIdDataGridViewTextBoxColumn
        '
        Me.UserIdDataGridViewTextBoxColumn.DataPropertyName = "UserId"
        Me.UserIdDataGridViewTextBoxColumn.HeaderText = "UserId"
        Me.UserIdDataGridViewTextBoxColumn.Name = "UserIdDataGridViewTextBoxColumn"
        Me.UserIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        '
        'MessageDataGridViewTextBoxColumn
        '
        Me.MessageDataGridViewTextBoxColumn.DataPropertyName = "Message"
        Me.MessageDataGridViewTextBoxColumn.HeaderText = "Message"
        Me.MessageDataGridViewTextBoxColumn.Name = "MessageDataGridViewTextBoxColumn"
        '
        'ViewTroop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 407)
        Me.Controls.Add(Me.dgvTroop)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Name = "ViewTroop"
        Me.Text = "ViewTroop"
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTroop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GSCDataSet As GSCDataSet
    Friend WithEvents AccountsBindingSource As BindingSource
    Friend WithEvents AccountsTableAdapter As GSCDataSetTableAdapters.AccountsTableAdapter
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvTroop As DataGridView
    Friend WithEvents UserIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MessageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountsBindingSource1 As BindingSource
End Class
