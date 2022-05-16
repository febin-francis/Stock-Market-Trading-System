<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listed_Stocks
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet8 = New SMTS.Database1DataSet8()
        Me.StocksTableAdapter = New SMTS.Database1DataSet8TableAdapters.StocksTableAdapter()
        Me.StockNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuyPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OldPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StockNameDataGridViewTextBoxColumn, Me.BuyPriceDataGridViewTextBoxColumn, Me.SellPriceDataGridViewTextBoxColumn, Me.OldPriceDataGridViewTextBoxColumn, Me.TotalqtyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StocksBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(55, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(667, 357)
        Me.DataGridView1.TabIndex = 0
        '
        'StocksBindingSource
        '
        Me.StocksBindingSource.DataMember = "Stocks"
        Me.StocksBindingSource.DataSource = Me.Database1DataSet8
        '
        'Database1DataSet8
        '
        Me.Database1DataSet8.DataSetName = "Database1DataSet8"
        Me.Database1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StocksTableAdapter
        '
        Me.StocksTableAdapter.ClearBeforeFill = True
        '
        'StockNameDataGridViewTextBoxColumn
        '
        Me.StockNameDataGridViewTextBoxColumn.DataPropertyName = "Stock_Name"
        Me.StockNameDataGridViewTextBoxColumn.HeaderText = "Stock Name"
        Me.StockNameDataGridViewTextBoxColumn.Name = "StockNameDataGridViewTextBoxColumn"
        Me.StockNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BuyPriceDataGridViewTextBoxColumn
        '
        Me.BuyPriceDataGridViewTextBoxColumn.DataPropertyName = "Buy_Price"
        Me.BuyPriceDataGridViewTextBoxColumn.HeaderText = "Buy Price"
        Me.BuyPriceDataGridViewTextBoxColumn.Name = "BuyPriceDataGridViewTextBoxColumn"
        Me.BuyPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SellPriceDataGridViewTextBoxColumn
        '
        Me.SellPriceDataGridViewTextBoxColumn.DataPropertyName = "Sell_Price"
        Me.SellPriceDataGridViewTextBoxColumn.HeaderText = "Sell Price"
        Me.SellPriceDataGridViewTextBoxColumn.Name = "SellPriceDataGridViewTextBoxColumn"
        Me.SellPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OldPriceDataGridViewTextBoxColumn
        '
        Me.OldPriceDataGridViewTextBoxColumn.DataPropertyName = "Old_Price"
        Me.OldPriceDataGridViewTextBoxColumn.HeaderText = "Old Price"
        Me.OldPriceDataGridViewTextBoxColumn.Name = "OldPriceDataGridViewTextBoxColumn"
        Me.OldPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalqtyDataGridViewTextBoxColumn
        '
        Me.TotalqtyDataGridViewTextBoxColumn.DataPropertyName = "Total_qty"
        Me.TotalqtyDataGridViewTextBoxColumn.HeaderText = "Total Quantity"
        Me.TotalqtyDataGridViewTextBoxColumn.Name = "TotalqtyDataGridViewTextBoxColumn"
        Me.TotalqtyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Listed_Stocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 403)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Listed_Stocks"
        Me.Text = "Listed_Stocks"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Database1DataSet8 As SMTS.Database1DataSet8
    Friend WithEvents StocksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StocksTableAdapter As SMTS.Database1DataSet8TableAdapters.StocksTableAdapter
    Friend WithEvents StockNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuyPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SellPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OldPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalqtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
