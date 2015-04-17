<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbErrors = New System.Windows.Forms.ListBox()
        Me.tbPlaceOrder = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.tbContractIDLeg2 = New System.Windows.Forms.TextBox()
        Me.tbContractIDLeg1 = New System.Windows.Forms.TextBox()
        Me.Rights = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StrikePrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expiration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Symbol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbOrderStatus = New System.Windows.Forms.ListBox()
        Me.dgOptionsSeries = New System.Windows.Forms.DataGridView()
        Me.btnRetrieveSeries = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tbOrderId = New System.Windows.Forms.TextBox()
        Me.tbUnderlyingSymbol = New System.Windows.Forms.TextBox()
        Me.AxTws1 = New AxTWSLib.AxTws()
        CType(Me.dgOptionsSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxTws1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbErrors
        '
        Me.lbErrors.FormattingEnabled = True
        Me.lbErrors.HorizontalScrollbar = True
        Me.lbErrors.ItemHeight = 16
        Me.lbErrors.Location = New System.Drawing.Point(69, 380)
        Me.lbErrors.Name = "lbErrors"
        Me.lbErrors.Size = New System.Drawing.Size(551, 68)
        Me.lbErrors.TabIndex = 19
        '
        'tbPlaceOrder
        '
        Me.tbPlaceOrder.Location = New System.Drawing.Point(310, 31)
        Me.tbPlaceOrder.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.tbPlaceOrder.Name = "tbPlaceOrder"
        Me.tbPlaceOrder.Size = New System.Drawing.Size(100, 25)
        Me.tbPlaceOrder.TabIndex = 15
        Me.tbPlaceOrder.Text = "Place Order"
        Me.tbPlaceOrder.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(413, 59)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(86, 17)
        Me.label4.TabIndex = 10
        Me.label4.Text = "ConID Leg 2"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(307, 59)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(86, 17)
        Me.label3.TabIndex = 11
        Me.label3.Text = "ConID Leg 1"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(66, 285)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(89, 17)
        Me.label5.TabIndex = 12
        Me.label5.Text = "Order Status"
        '
        'tbContractIDLeg2
        '
        Me.tbContractIDLeg2.Location = New System.Drawing.Point(416, 79)
        Me.tbContractIDLeg2.Name = "tbContractIDLeg2"
        Me.tbContractIDLeg2.Size = New System.Drawing.Size(100, 22)
        Me.tbContractIDLeg2.TabIndex = 6
        '
        'tbContractIDLeg1
        '
        Me.tbContractIDLeg1.Location = New System.Drawing.Point(310, 79)
        Me.tbContractIDLeg1.Name = "tbContractIDLeg1"
        Me.tbContractIDLeg1.Size = New System.Drawing.Size(100, 22)
        Me.tbContractIDLeg1.TabIndex = 7
        '
        'Rights
        '
        Me.Rights.HeaderText = "Rights"
        Me.Rights.Name = "Rights"
        '
        'StrikePrice
        '
        Me.StrikePrice.HeaderText = "Strike Price"
        Me.StrikePrice.Name = "StrikePrice"
        '
        'Expiration
        '
        Me.Expiration.HeaderText = "Expiration"
        Me.Expiration.Name = "Expiration"
        '
        'Symbol
        '
        Me.Symbol.HeaderText = "Symbol"
        Me.Symbol.Name = "Symbol"
        '
        'ContractID
        '
        Me.ContractID.HeaderText = "ContractID"
        Me.ContractID.Name = "ContractID"
        '
        'lbOrderStatus
        '
        Me.lbOrderStatus.FormattingEnabled = True
        Me.lbOrderStatus.ItemHeight = 16
        Me.lbOrderStatus.Location = New System.Drawing.Point(69, 306)
        Me.lbOrderStatus.Name = "lbOrderStatus"
        Me.lbOrderStatus.Size = New System.Drawing.Size(551, 68)
        Me.lbOrderStatus.TabIndex = 20
        '
        'dgOptionsSeries
        '
        Me.dgOptionsSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOptionsSeries.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ContractID, Me.Symbol, Me.Expiration, Me.StrikePrice, Me.Rights})
        Me.dgOptionsSeries.Location = New System.Drawing.Point(69, 126)
        Me.dgOptionsSeries.Name = "dgOptionsSeries"
        Me.dgOptionsSeries.RowTemplate.Height = 24
        Me.dgOptionsSeries.Size = New System.Drawing.Size(551, 150)
        Me.dgOptionsSeries.TabIndex = 18
        '
        'btnRetrieveSeries
        '
        Me.btnRetrieveSeries.Location = New System.Drawing.Point(174, 31)
        Me.btnRetrieveSeries.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.btnRetrieveSeries.Name = "btnRetrieveSeries"
        Me.btnRetrieveSeries.Size = New System.Drawing.Size(75, 25)
        Me.btnRetrieveSeries.TabIndex = 16
        Me.btnRetrieveSeries.Text = "Retrieve"
        Me.btnRetrieveSeries.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(69, 31)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 25)
        Me.btnConnect.TabIndex = 17
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(66, 59)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(62, 17)
        Me.label2.TabIndex = 13
        Me.label2.Text = "Order ID"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(171, 59)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(126, 17)
        Me.label1.TabIndex = 14
        Me.label1.Text = "Underlying Symbol"
        '
        'tbOrderId
        '
        Me.tbOrderId.Location = New System.Drawing.Point(69, 79)
        Me.tbOrderId.Name = "tbOrderId"
        Me.tbOrderId.Size = New System.Drawing.Size(75, 22)
        Me.tbOrderId.TabIndex = 8
        '
        'tbUnderlyingSymbol
        '
        Me.tbUnderlyingSymbol.Location = New System.Drawing.Point(174, 79)
        Me.tbUnderlyingSymbol.Name = "tbUnderlyingSymbol"
        Me.tbUnderlyingSymbol.Size = New System.Drawing.Size(100, 22)
        Me.tbUnderlyingSymbol.TabIndex = 9
        Me.tbUnderlyingSymbol.Text = "MSFT"
        '
        'AxTws1
        '
        Me.AxTws1.Enabled = True
        Me.AxTws1.Location = New System.Drawing.Point(537, 22)
        Me.AxTws1.Name = "AxTws1"
        Me.AxTws1.OcxState = CType(resources.GetObject("AxTws1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxTws1.Size = New System.Drawing.Size(127, 34)
        Me.AxTws1.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 479)
        Me.Controls.Add(Me.AxTws1)
        Me.Controls.Add(Me.lbErrors)
        Me.Controls.Add(Me.tbPlaceOrder)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.tbContractIDLeg2)
        Me.Controls.Add(Me.tbContractIDLeg1)
        Me.Controls.Add(Me.lbOrderStatus)
        Me.Controls.Add(Me.dgOptionsSeries)
        Me.Controls.Add(Me.btnRetrieveSeries)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.tbOrderId)
        Me.Controls.Add(Me.tbUnderlyingSymbol)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgOptionsSeries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxTws1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lbErrors As System.Windows.Forms.ListBox
    Private WithEvents tbPlaceOrder As System.Windows.Forms.Button
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents tbContractIDLeg2 As System.Windows.Forms.TextBox
    Private WithEvents tbContractIDLeg1 As System.Windows.Forms.TextBox
    Private WithEvents Rights As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents StrikePrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Expiration As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Symbol As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents ContractID As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents lbOrderStatus As System.Windows.Forms.ListBox
    Private WithEvents dgOptionsSeries As System.Windows.Forms.DataGridView
    Private WithEvents btnRetrieveSeries As System.Windows.Forms.Button
    Private WithEvents btnConnect As System.Windows.Forms.Button
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents tbOrderId As System.Windows.Forms.TextBox
    Private WithEvents tbUnderlyingSymbol As System.Windows.Forms.TextBox
    Friend WithEvents AxTws1 As AxTWSLib.AxTws

End Class
