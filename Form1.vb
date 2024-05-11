Public Class Form1
    ' Storing constants
    Const dblStereoPrice As Double = 500
    Const dblLeatherPrice As Double = 1000
    Const dblNavigationPrice As Double = 1500
    Const dblPearlPrice As Double = 500
    Const dblCustomPrice As Double = 750
    Const dblTaxRate As Double = 0.07
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear all the labels and textboxes and set trade in back to default value of 0
        txtFirstNam.Clear()
        txtLastName.Clear()
        txtBase.Clear()
        txtTrade.Clear()
        lblAF.ResetText()
        lblAmtDue.ResetText()
        lblSubtotal.Text = ""
        lblTax.Text = String.Empty

        chckLeather.Checked = False
        chckNavigation.Checked = False
        chckStereo.Checked = False

        radStandard.Checked = True
        txtFirstNam.Focus()
    End Sub
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' constants for options and tax rate
        Dim dblBasePrice As Double
        Dim dblTrade As Double

        Dim dblAFPrice As Double
        Dim dblSubTotal As Double
        Dim dblTax As Double
        Dim dblAmountDue As Double

        Dim blnValidated As Boolean = True

        Call Get_Validate_Input(dblBasePrice, dblTrade, blnValidated)

        If blnValidated = True Then
            Call Calculate_Car_Price(dblBasePrice, dblTrade, dblAFPrice, dblSubTotal, dblTax, dblAmountDue)
            Call Display_Totals(dblAFPrice, dblSubTotal, dblTax, dblAmountDue)
        End If
    End Sub
    Private Sub Get_Validate_Input(ByRef dblBasePrice As Double, ByRef dblTrade As Double, ByRef blnValidated As Boolean)
        Call Get_Validate_Base_Price(dblBasePrice, blnValidated)
        If blnValidated = True Then
            Call Get_Validate_Trade(dblTrade, blnValidated)
        End If
    End Sub
    Private Sub Get_Validate_Base_Price(ByRef dblBasePrice As Double, ByRef blnValidated As Boolean)
        ' Validating input text
        If IsNumeric(txtBase.Text) Then
            dblBasePrice = txtBase.Text
            If dblBasePrice < 1 Then
                MessageBox.Show("Base Price Must Be Greater than 0")
                txtBase.Focus()
                blnValidated = False

            End If
        Else
            MessageBox.Show("Base Price Must Exist and Must be Numeric")
            txtBase.Focus()
            blnValidated = False
        End If
    End Sub
    Private Sub Get_Validate_Trade(ByRef dblTrade As Double, ByRef blnValidated As Boolean)
        ' Valaditing input in NUmeric
        If IsNumeric(txtTrade.Text) Then
            dblTrade = txtTrade.Text
            If dblTrade < 0 Then
                MessageBox.Show("Trade In Must Be 0 or Greater")
                txtTrade.Focus()
                blnValidated = False
            End If
        Else
            MessageBox.Show("Trade In Must Exist and Must be Numeric")
            txtTrade.Focus()
            blnValidated = False
        End If
    End Sub
    Private Sub Calculate_Car_Price(ByVal dblBasePrice As Double, ByVal dblTrade As Double, ByRef dblAFPrice As Double, ByRef dblSubTotal As Double, ByRef dblTax As Double, ByRef dblAmountDue As Double)
        Call Calculate_AF_Price(dblAFPrice)
        Call Calculate_Tax(dblBasePrice, dblAFPrice, dblTax)
        Call Calculate_SubTotal(dblBasePrice, dblAFPrice, dblSubTotal, dblTax)
        Call Calcluate_Total(dblSubTotal, dblTrade, dblAmountDue)
    End Sub
    Private Sub Calculate_AF_Price(ByRef dblAFPrice As Double)
        Call Calculate_Accessories(dblAFPrice)
        Call Calcuate_Finish(dblAFPrice)
    End Sub
    Private Sub Calculate_Accessories(ByRef dblAFPrice As Double)
        ' Calculating Accessories
        If chckStereo.Checked = True Then
            dblAFPrice = dblStereoPrice
        End If
        If chckLeather.Checked Then
            dblAFPrice += dblLeatherPrice
        End If
        If chckNavigation.Checked Then
            dblAFPrice += dblNavigationPrice
        End If
    End Sub
    Private Sub Calcuate_Finish(ByRef dblAFPrice As Double)
        ' Calculating Finish
        If radPearlized.Checked Then
            dblAFPrice += dblPearlPrice
        Else
            If radCustom.Checked Then
                dblAFPrice += dblCustomPrice
            End If
        End If
    End Sub
    Private Sub Calculate_Tax(ByVal dblBasePrice As Double, ByVal dblAFPrice As Double, ByRef dblTax As Double)
        dblTax = (dblBasePrice + dblAFPrice) * dblTaxRate
    End Sub
    Private Sub Calculate_SubTotal(ByVal dblBasePrice As Double, ByVal dblAFPrice As Double, ByRef dblSubTotal As Double, ByVal dbltax As Double)
        dblSubTotal = dbltax + dblBasePrice + dblAFPrice
    End Sub
    Private Sub Calcluate_Total(ByVal dblSubTotal As Double, ByVal dblTrade As Double, ByRef dblAmountDue As Double)
        dblAmountDue = dblSubTotal - dblTrade
    End Sub
    Private Sub Display_Totals(ByVal dblAFPrice As Double, ByVal dblSubTotal As Double, ByVal dblTax As Double, ByVal dblAmountDue As Double)
        ' Displaying outputs/Sales Totals
        lblAF.Text = FormatCurrency(dblAFPrice)
        lblTax.Text = FormatCurrency(dblTax)
        lblSubtotal.Text = FormatCurrency(dblSubTotal)
        lblAmtDue.Text = FormatCurrency(dblAmountDue)
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' close the program
        Close()
    End Sub
End Class