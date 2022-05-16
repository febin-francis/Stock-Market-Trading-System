<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.PortfolioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet1 = New SMTS.Database1DataSet1()
        Me.Database1DataSet = New SMTS.Database1DataSet()
        Me.Database1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PortfolioTableAdapter = New SMTS.Database1DataSet1TableAdapters.PortfolioTableAdapter()
        Me.Database1DataSet3 = New SMTS.Database1DataSet3()
        Me.HoldingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HoldingsTableAdapter = New SMTS.Database1DataSet3TableAdapters.HoldingsTableAdapter()
        Me.Database1DataSet4 = New SMTS.Database1DataSet4()
        Me.HoldingsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HoldingsTableAdapter1 = New SMTS.Database1DataSet4TableAdapters.HoldingsTableAdapter()
        Me.HoldingsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet5 = New SMTS.Database1DataSet5()
        Me.HoldingsTableAdapter2 = New SMTS.Database1DataSet5TableAdapters.HoldingsTableAdapter()
        Me.HoldingsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet10 = New SMTS.Database1DataSet10()
        Me.HoldingsTableAdapter3 = New SMTS.Database1DataSet10TableAdapters.HoldingsTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StockNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuyPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoldingsBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet11 = New SMTS.Database1DataSet11()
        Me.HoldingsTableAdapter4 = New SMTS.Database1DataSet11TableAdapters.HoldingsTableAdapter()
        CType(Me.PortfolioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoldingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoldingsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoldingsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoldingsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoldingsBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PortfolioBindingSource
        '
        Me.PortfolioBindingSource.DataMember = "Portfolio"
        Me.PortfolioBindingSource.DataSource = Me.Database1DataSet1
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Database1DataSetBindingSource
        '
        Me.Database1DataSetBindingSource.DataSource = Me.Database1DataSet
        Me.Database1DataSetBindingSource.Position = 0
        '
        'PortfolioTableAdapter
        '
        Me.PortfolioTableAdapter.ClearBeforeFill = True
        '
        'Database1DataSet3
        '
        Me.Database1DataSet3.DataSetName = "Database1DataSet3"
        Me.Database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HoldingsBindingSource
        '
        Me.HoldingsBindingSource.DataMember = "Holdings"
        Me.HoldingsBindingSource.DataSource = Me.Database1DataSet3
        '
        'HoldingsTableAdapter
        '
        Me.HoldingsTableAdapter.ClearBeforeFill = True
        '
        'Database1DataSet4
        '
        Me.Database1DataSet4.DataSetName = "Database1DataSet4"
        Me.Database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HoldingsBindingSource1
        '
        Me.HoldingsBindingSource1.DataMember = "Holdings"
        Me.HoldingsBindingSource1.DataSource = Me.Database1DataSet4
        '
        'HoldingsTableAdapter1
        '
        Me.HoldingsTableAdapter1.ClearBeforeFill = True
        '
        'HoldingsBindingSource2
        '
        Me.HoldingsBindingSource2.DataMember = "Holdings"
        Me.HoldingsBindingSource2.DataSource = Me.Database1DataSet5
        '
        'Database1DataSet5
        '
        Me.Database1DataSet5.DataSetName = "Database1DataSet5"
        Me.Database1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HoldingsTableAdapter2
        '
        Me.HoldingsTableAdapter2.ClearBeforeFill = True
        '
        'HoldingsBindingSource3
        '
        Me.HoldingsBindingSource3.DataMember = "Holdings"
        Me.HoldingsBindingSource3.DataSource = Me.Database1DataSet10
        '
        'Database1DataSet10
        '
        Me.Database1DataSet10.DataSetName = "Database1DataSet10"
        Me.Database1DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HoldingsTableAdapter3
        '
        Me.HoldingsTableAdapter3.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(160, 418)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Profit/Loss :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(318, 418)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(498, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Portfolio"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StockNameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.BuyPriceDataGridViewTextBoxColumn, Me.IValueDataGridViewTextBoxColumn, Me.CValueDataGridViewTextBoxColumn, Me.PlDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HoldingsBindingSource4
        Me.DataGridView1.Location = New System.Drawing.Point(68, 85)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(986, 292)
        Me.DataGridView1.TabIndex = 4
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
        'IValueDataGridViewTextBoxColumn
        '
        Me.IValueDataGridViewTextBoxColumn.DataPropertyName = "I_Value"
        Me.IValueDataGridViewTextBoxColumn.HeaderText = "Invested Value"
        Me.IValueDataGridViewTextBoxColumn.Name = "IValueDataGridViewTextBoxColumn"
        Me.IValueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CValueDataGridViewTextBoxColumn
        '
        Me.CValueDataGridViewTextBoxColumn.DataPropertyName = "C_Value"
        Me.CValueDataGridViewTextBoxColumn.HeaderText = "Current Value"
        Me.CValueDataGridViewTextBoxColumn.Name = "CValueDataGridViewTextBoxColumn"
        Me.CValueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PlDataGridViewTextBoxColumn
        '
        Me.PlDataGridViewTextBoxColumn.DataPropertyName = "pl"
        Me.PlDataGridViewTextBoxColumn.HeaderText = "Profit/Loss"
        Me.PlDataGridViewTextBoxColumn.Name = "PlDataGridViewTextBoxColumn"
        Me.PlDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HoldingsBindingSource4
        '
        Me.HoldingsBindingSource4.DataMember = "Holdings"
        Me.HoldingsBindingSource4.DataSource = Me.Database1DataSet11
        '
        'Database1DataSet11
        '
        Me.Database1DataSet11.DataSetName = "Database1DataSet11"
        Me.Database1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HoldingsTableAdapter4
        '
        Me.HoldingsTableAdapter4.ClearBeforeFill = True
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.BackgroundImage = Global.SMTS.My.Resources.Resources.business_candle_stick_graph_chart_of_stock_market_investment_vector
        Me.ClientSize = New System.Drawing.Size(1111, 522)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Report"
        Me.Text = "Report"
        CType(Me.PortfolioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoldingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoldingsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoldingsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoldingsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoldingsBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Database1DataSet As SMTS.Database1DataSet
    Friend WithEvents Database1DataSet1 As SMTS.Database1DataSet1
    Friend WithEvents PortfolioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PortfolioTableAdapter As SMTS.Database1DataSet1TableAdapters.PortfolioTableAdapter
    Friend WithEvents Database1DataSet3 As SMTS.Database1DataSet3
    Friend WithEvents HoldingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HoldingsTableAdapter As SMTS.Database1DataSet3TableAdapters.HoldingsTableAdapter
    Friend WithEvents Database1DataSet4 As SMTS.Database1DataSet4
    Friend WithEvents HoldingsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents HoldingsTableAdapter1 As SMTS.Database1DataSet4TableAdapters.HoldingsTableAdapter
    Friend WithEvents Database1DataSet5 As SMTS.Database1DataSet5
    Friend WithEvents HoldingsBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents HoldingsTableAdapter2 As SMTS.Database1DataSet5TableAdapters.HoldingsTableAdapter
    Friend WithEvents Database1DataSet10 As SMTS.Database1DataSet10
    Friend WithEvents HoldingsBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents HoldingsTableAdapter3 As SMTS.Database1DataSet10TableAdapters.HoldingsTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Database1DataSet11 As SMTS.Database1DataSet11
    Friend WithEvents HoldingsBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents HoldingsTableAdapter4 As SMTS.Database1DataSet11TableAdapters.HoldingsTableAdapter
    Friend WithEvents StockNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuyPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
