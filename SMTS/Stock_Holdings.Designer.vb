<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock_Holdings
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
        Me.HoldingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet7 = New SMTS.Database1DataSet7()
        Me.HoldingsTableAdapter = New SMTS.Database1DataSet7TableAdapters.HoldingsTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HoldingsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet13 = New SMTS.Database1DataSet13()
        Me.HoldingsTableAdapter1 = New SMTS.Database1DataSet13TableAdapters.HoldingsTableAdapter()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuyPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.I_Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.HoldingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoldingsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HoldingsBindingSource
        '
        Me.HoldingsBindingSource.DataMember = "Holdings"
        Me.HoldingsBindingSource.DataSource = Me.Database1DataSet7
        '
        'Database1DataSet7
        '
        Me.Database1DataSet7.DataSetName = "Database1DataSet7"
        Me.Database1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HoldingsTableAdapter
        '
        Me.HoldingsTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Email, Me.StockNameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.BuyPriceDataGridViewTextBoxColumn, Me.I_Value, Me.C_Value, Me.PlDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HoldingsBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(726, 363)
        Me.DataGridView1.TabIndex = 0
        '
        'HoldingsBindingSource1
        '
        Me.HoldingsBindingSource1.DataMember = "Holdings"
        Me.HoldingsBindingSource1.DataSource = Me.Database1DataSet13
        '
        'Database1DataSet13
        '
        Me.Database1DataSet13.DataSetName = "Database1DataSet13"
        Me.Database1DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HoldingsTableAdapter1
        '
        Me.HoldingsTableAdapter1.ClearBeforeFill = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "H_id"
        Me.Column1.HeaderText = "Holding ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email ID"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'StockNameDataGridViewTextBoxColumn
        '
        Me.StockNameDataGridViewTextBoxColumn.DataPropertyName = "Stock_Name"
        Me.StockNameDataGridViewTextBoxColumn.HeaderText = "Stock Name"
        Me.StockNameDataGridViewTextBoxColumn.Name = "StockNameDataGridViewTextBoxColumn"
        Me.StockNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BuyPriceDataGridViewTextBoxColumn
        '
        Me.BuyPriceDataGridViewTextBoxColumn.DataPropertyName = "Buy_Price"
        Me.BuyPriceDataGridViewTextBoxColumn.HeaderText = "Buy Price"
        Me.BuyPriceDataGridViewTextBoxColumn.Name = "BuyPriceDataGridViewTextBoxColumn"
        Me.BuyPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'I_Value
        '
        Me.I_Value.DataPropertyName = "I_Value"
        Me.I_Value.HeaderText = "Invested Value"
        Me.I_Value.Name = "I_Value"
        Me.I_Value.ReadOnly = True
        '
        'C_Value
        '
        Me.C_Value.DataPropertyName = "C_Value"
        Me.C_Value.HeaderText = "Current Value"
        Me.C_Value.Name = "C_Value"
        Me.C_Value.ReadOnly = True
        '
        'PlDataGridViewTextBoxColumn
        '
        Me.PlDataGridViewTextBoxColumn.DataPropertyName = "pl"
        Me.PlDataGridViewTextBoxColumn.HeaderText = "Profit/Loss"
        Me.PlDataGridViewTextBoxColumn.Name = "PlDataGridViewTextBoxColumn"
        Me.PlDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Stock_Holdings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 417)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Stock_Holdings"
        Me.Text = "Stock_Holdings"
        CType(Me.HoldingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoldingsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Database1DataSet7 As SMTS.Database1DataSet7
    Friend WithEvents HoldingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HoldingsTableAdapter As SMTS.Database1DataSet7TableAdapters.HoldingsTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Database1DataSet13 As SMTS.Database1DataSet13
    Friend WithEvents HoldingsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents HoldingsTableAdapter1 As SMTS.Database1DataSet13TableAdapters.HoldingsTableAdapter
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuyPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents I_Value As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents C_Value As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
