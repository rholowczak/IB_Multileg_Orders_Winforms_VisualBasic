Public Class Form1

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        ' Connect to Trader Workstation (or IB Gateway) 
        AxTws1.connect("", 7496, 0)
    End Sub

    Private Sub btnRetrieveSeries_Click(sender As Object, e As EventArgs) Handles btnRetrieveSeries.Click
        ' Retrieve all of the contracts that match this underlying
        ' Clear out the Data grid
        dgOptionsSeries.Rows.Clear()
        dgOptionsSeries.Refresh()
        ' Create the contract object
        Dim optionSeries = AxTws1.createContract()
        ' Check the underlying symbol only
        optionSeries.symbol = tbUnderlyingSymbol.Text
        optionSeries.secType = "OPT"
        ' Request all of the series on this underlying
        AxTws1.reqContractDetailsEx(1, optionSeries)
        lbErrors.Items.Add("Request Made")
    End Sub

    Private Sub label2_Click(sender As Object, e As EventArgs) Handles label2.Click
        AxTws1.reqIds(1)
    End Sub

    Private Sub AxTws1_errMsg(sender As Object, e As AxTWSLib._DTwsEvents_errMsgEvent) Handles AxTws1.errMsg
        ' Echo any errors to the lbError list box
        lbErrors.Items.Add(e.errorCode & " " & e.errorMsg)
    End Sub

    Private Sub AxTws1_contractDetails(sender As Object, e As AxTWSLib._DTwsEvents_contractDetailsEvent) Handles AxTws1.contractDetails
        dgOptionsSeries.Rows.Add(e.conId, e.symbol, e.expiry, e.strike, e.right)
    End Sub

    Private Sub dgOptionsSeries_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgOptionsSeries.CellContentDoubleClick
        ' Double click on a cell. ContractID is in column 0
        ' ContractID will be copied in to one of the tbContractIDLeg text boxes
        If (e.ColumnIndex = 0) Then
            ' See which Leg is empty
            If (tbContractIDLeg1.Text = String.Empty) Then
                tbContractIDLeg1.Text = dgOptionsSeries.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            Else
                tbContractIDLeg2.Text = dgOptionsSeries.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            End If
        End If
    End Sub

    Private Sub AxTws1_nextValidId(sender As Object, e As AxTWSLib._DTwsEvents_nextValidIdEvent) Handles AxTws1.nextValidId
        tbOrderId.Text = e.id.ToString()
    End Sub

    Private Sub tbPlaceOrder_Click(sender As Object, e As EventArgs) Handles tbPlaceOrder.Click
        ' Place a combo order
        ' At this point the two contract identifiers will be in text boxes
        ' tbContractIDLeg1.Text and tbContractIDLeg2.Text
        ' Create a list of Combo Legs
        Dim cllComboOrderLegs = AxTws1.createComboLegList()

        ' Create Leg 1 of the order
        Dim clLeg1 As TWSLib.IComboLeg

        ' Create Leg 2 of the order
        Dim clLeg2 As TWSLib.IComboLeg

        ' Create the master order
        Dim ordMasterOrder = AxTws1.createOrder()

        ' Create the master contract that will hold the legs
        Dim cMasterContract = AxTws1.createContract()

        ' Fill in the Combo Leg information for Leg 1
        clLeg1 = cllComboOrderLegs.Add()
        clLeg1.conId = Convert.ToInt32(tbContractIDLeg1.Text)
        clLeg1.ratio = 1
        clLeg1.action = "BUY"
        clLeg1.exchange = "SMART"

        ' Fill in the Combo Leg information for Leg 2
        clLeg2 = cllComboOrderLegs.Add()
        clLeg2.conId = Convert.ToInt32(tbContractIDLeg2.Text)
        clLeg2.ratio = 1
        clLeg2.action = "BUY"
        clLeg2.exchange = "SMART"

        ' Fill in the master contract
        cMasterContract.symbol = tbUnderlyingSymbol.Text
        cMasterContract.secType = "BAG"
        cMasterContract.exchange = "SMART"
        cMasterContract.currency = "USD"
        cMasterContract.comboLegs = cllComboOrderLegs

        ' Fill in the Master Order
        ordMasterOrder.action = "BUY"
        ordMasterOrder.totalQuantity = 1
        ordMasterOrder.orderType = "MKT"

        '  Place the order
        AxTws1.placeOrderEx(Convert.ToInt32(tbOrderId.Text), cMasterContract, ordMasterOrder)

    End Sub

    Private Sub AxTws1_orderStatus(sender As Object, e As AxTWSLib._DTwsEvents_orderStatusEvent) Handles AxTws1.orderStatus
        ' Show any Order Status changes to the lbOrderStatus list box
        Dim strOrderStatus As String
        strOrderStatus = e.id & " " & e.parentId & " " & e.status
        strOrderStatus &= " " & e.filled & " " & e.lastFillPrice
        strOrderStatus &= " " & e.avgFillPrice & " " & e.remaining
        ' Add to list box
        lbOrderStatus.Items.Add(strOrderStatus)
    End Sub
End Class
