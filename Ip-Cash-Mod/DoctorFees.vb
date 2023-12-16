Imports System.Data
Imports System.Data.SqlClient


Public Class DoctorFees
    Public xCon As New SqlConnection("Data Source=LAPTOP-C27U7D67\SQLEXPRESS;Initial Catalog=LaskhmiHospital;Integrated Security=True")
    Public xCon1 As New SqlConnection("Data Source=LAPTOP-C27U7D67\SQLEXPRESS;Initial Catalog=LaskhmiHospital;Integrated Security=True") '
    Public xCon2 As New SqlConnection("Data Source=LAPTOP-C27U7D67\SQLEXPRESS;Initial Catalog=LaskhmiHospital;Integrated Security=True") '
    Dim xDoctorFeesByIpNo As Integer = 0
    Dim xBeforeDoctorFeesProcess As Integer = 0
    Dim xAfterDoctorFeesProcess As Integer = 0
    Dim xFinalDoctorFeesProcess As Integer = 0
    Dim xFinalParticularFeesProcess As Integer = 0
    Dim xPercentageValue, xPercentageValue1 As Double
    Dim xBeforeParticularsFeesProcess As Integer = 0
    Dim xAfterParticularsFeesProcess As Integer = 0

    'Step One Other Doctor Amount to be Show and Process
    Private Sub btnOtherDoctFeesShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtherDoctFeesShow.Click
        Call ShowOtherDoctorFees()
        Call ShowRoomAmount()
    End Sub

    Private Sub btnOtherDoctorFeesProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtherDoctorFeesProcess.Click
        Dim xDoctorFees, xLessAmount As Integer
        rchDoctorFees.Text = ""
        rchLessAmount.Text = ""

        Dim xDischargeQry As String = "SELECT ipno FROM AdmissionDetails " _
        & " WHERE (DischargeDateTime >= '" + dtpfromDate.Text + "' and DischargeDateTime <= '" + dtptoDate.Text + "')"
        xCon.Open()
        Dim sqlcmd As New SqlCommand(xDischargeQry, xCon)
        Dim myreader As SqlDataReader
        myreader = sqlcmd.ExecuteReader()
        While myreader.Read()
            xDoctorFees = 0
            xLessAmount = 0
            xDoctorFeesByIpNo = 0
            Dim xIpNo As String = myreader.Item("ipno").ToString
            Dim xRecieptDoctorFeesDetailsQry As String = "SELECT sum(doctorfees) as doctorfees FROM ReceiptDoctorFeesDetails WHERE IPNo='" + xIpNo + "' and doctorname!='Dr. Meena' and doctorname!='Dr. Ramalaksmi' and doctorname!='Dr. Laksmanan'"
            xCon1.Open()

            Dim sqlcmd1 As New SqlCommand(xRecieptDoctorFeesDetailsQry, xCon1)
            Dim myreader1 As SqlDataReader
            myreader1 = sqlcmd1.ExecuteReader()
            '  If myreader1.HasRows + 1 Then
            While myreader1.Read()
                If myreader1.Item("doctorfees").ToString <> String.Empty Then
                    xDoctorFeesByIpNo = myreader1.Item("doctorfees").ToString
                End If
            End While
            ' End If
            xCon1.Close()

            Dim xRecieptDoctorFeesUpdateQry As String = "update ReceiptDoctorFeesDetails set doctorfees =0 WHERE IPNo='" + xIpNo + "' and doctorname!='Dr. Meena' and doctorname!='Dr. Ramalaksmi' and doctorname!='Dr. Laksmanan'"
            xCon1.Open()
            Dim sqlcmdRecieptDoctorFeesUpdate As New SqlCommand(xRecieptDoctorFeesUpdateQry, xCon1)
            Dim myreaderRecieptDoctorFeesUpdate As SqlDataReader
            myreaderRecieptDoctorFeesUpdate = sqlcmdRecieptDoctorFeesUpdate.ExecuteReader()
            xCon1.Close()

            Dim xRecieptDetailsLessAmountQry As String = "update  ReceiptDetails set totalexpense=totalexpense-" + xDoctorFeesByIpNo.ToString + " WHERE IPNo='" + xIpNo + "'"
            xCon1.Open()
            Dim sqlcmdRecieptDetailsLessAmount As New SqlCommand(xRecieptDetailsLessAmountQry, xCon1)
            Dim myreaderRecieptDetailsLessAmount As SqlDataReader
            myreaderRecieptDetailsLessAmount = sqlcmdRecieptDetailsLessAmount.ExecuteReader()
            xCon1.Close()
        End While
        xCon.Close()
    End Sub

    'Step Two Less Amount Show and Process

    Private Sub btnLessShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLessShow.Click
        Dim xLessAmount As Integer
        rchLessAmount.Text = ""
        xLessAmount = 0
        Dim xDischargeQry As String = "SELECT ipno FROM AdmissionDetails " _
        & " WHERE (DischargeDateTime >= '" + dtpfromDate.Text + "' and DischargeDateTime <= '" + dtptoDate.Text + "')"

        xCon.Open()
        Dim sqlcmd As New SqlCommand(xDischargeQry, xCon)
        Dim myreader As SqlDataReader
        myreader = sqlcmd.ExecuteReader()
        While myreader.Read()
            Dim xIpNo As String = myreader.Item("ipno").ToString
            Dim xRecieptDetailsLessAmountQry As String = "SELECT ipno,lessamount FROM ReceiptDetails WHERE IPNo='" + xIpNo + "'  and lessamount>0"
            xCon1.Open()
            Dim sqlcmd2 As New SqlCommand(xRecieptDetailsLessAmountQry, xCon1)
            Dim myreader2 As SqlDataReader
            myreader2 = sqlcmd2.ExecuteReader()
            While myreader2.Read()
                xLessAmount += myreader2.Item("lessamount").ToString
                rchLessAmount.Text += myreader2.Item("ipno").ToString + "-" + myreader2.Item("lessamount").ToString + Environment.NewLine
            End While
            xCon1.Close()
        End While
        lblLessAmount.Text = xLessAmount
        xCon.Close()
    End Sub

    Private Sub btnLessProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLessProcess.Click
        Dim xDoctorFees, xLessAmount As Integer
        rchDoctorFees.Text = ""
        rchLessAmount.Text = ""

        Dim xDischargeQry As String = "SELECT ipno FROM AdmissionDetails " _
        & " WHERE (DischargeDateTime >= '" + dtpfromDate.Text + "' and DischargeDateTime <= '" + dtptoDate.Text + "')"
        xCon.Open()
        Dim sqlcmdDischarge As New SqlCommand(xDischargeQry, xCon)
        Dim myreaderDischarge As SqlDataReader
        myreaderDischarge = sqlcmdDischarge.ExecuteReader()
        While myreaderDischarge.Read()
            xDoctorFees = 0
            xLessAmount = 0
            Dim xIpNo As String = myreaderDischarge.Item("ipno").ToString
            Dim xRecieptDetailsLessAmountUpdateQry As String = "update  ReceiptDetails set lessamount=0  WHERE IPNo='" + xIpNo + "'"
            xCon1.Open()
            Dim sqlcmdRecieptDetailsLessAmountUpdate As New SqlCommand(xRecieptDetailsLessAmountUpdateQry, xCon1)
            Dim myreaderRecieptDetailsLessAmountUpdate As SqlDataReader
            myreaderRecieptDetailsLessAmountUpdate = sqlcmdRecieptDetailsLessAmountUpdate.ExecuteReader()
            xCon1.Close()
        End While
        xCon.Close()
    End Sub



    'Step Three Internal Doctor Fees Show and Process 

    Private Sub btnInternalFeesShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInternalFeesShow.Click
        rchInternalFeesShow.Text = ""
        rchInternalProcessingFeesShow.Text = ""
        rchBeforeDoctorFees.Text = ""
        rchAfterDoctorFees.Text = ""
        lblBeforeFees.Text = ""
        lblAfterParticularFees.Text = ""
        lblBeforeDoctorFees.Text = ""
        lblAfterDoctorFees.Text = ""
        xBeforeParticularsFeesProcess = 0
        xAfterParticularsFeesProcess = 0
        xBeforeDoctorFeesProcess = 0
        xAfterDoctorFeesProcess = 0
        Dim xDischargeQry As String = "SELECT ipno FROM AdmissionDetails " _
        & " WHERE (DischargeDateTime >= '" + dtpfromDate.Text + "' and DischargeDateTime <= '" + dtptoDate.Text + "')"
        xCon.Open()
        Dim sqlcmd As New SqlCommand(xDischargeQry, xCon)
        Dim myreader As SqlDataReader
        myreader = sqlcmd.ExecuteReader()
        While myreader.Read()
            Dim xIpNo As String = myreader.Item("ipno").ToString
            xPercentageValue = txtPercentage.Text.ToString
            xPercentageValue1 = xPercentageValue / 100
            Dim xReceiptNumber As String
            xReceiptNumber = ""
            Dim xCheckClaimBillQry As String = "SELECT ReceiptNumber FROM ReceiptDetails WHERE IPNo ='" + xIpNo + "' and claimbill='n'"
            xCon1.Open()
            Dim sqlcmdReceiptNumber As New SqlCommand(xCheckClaimBillQry, xCon1)
            Dim myreaderReceiptNumber As SqlDataReader
            myreaderReceiptNumber = sqlcmdReceiptNumber.ExecuteReader()
            While myreaderReceiptNumber.Read()
                xReceiptNumber = myreaderReceiptNumber.Item("ReceiptNumber").ToString
            End While
            xCon1.Close()
            If xReceiptNumber <> "" Then

                Dim xRecieptFeesDetailsQry As String = "SELECT ipno,particulars,Fees, ROUND((Fees - " + xPercentageValue1.ToString + " * Fees) / 25, 0) * 25 AS roundedfees FROM ReceiptFeesDetails WHERE IPNo ='" + xIpNo + "'"
                xCon1.Open()

                Dim sqlcmd1 As New SqlCommand(xRecieptFeesDetailsQry, xCon1)
                Dim myreader1 As SqlDataReader
                myreader1 = sqlcmd1.ExecuteReader()

                While myreader1.Read()
                    xBeforeParticularsFeesProcess += myreader1.Item("fees").ToString
                    xAfterParticularsFeesProcess += myreader1.Item("roundedfees").ToString
                    rchInternalFeesShow.Text += myreader1.Item("ipno").ToString + "- " + myreader1.Item("particulars").ToString + "- " + myreader1.Item("fees").ToString + Environment.NewLine
                    rchInternalProcessingFeesShow.Text += myreader1.Item("ipno").ToString + "- " + myreader1.Item("particulars").ToString + "- " + myreader1.Item("roundedfees").ToString + Environment.NewLine
                    'xFinalParticularFeesProcess = xBeforeParticularsFeesProcess - xAfterParticularsFeesProcess
                End While
                xCon1.Close()
            End If

            'Dim xReceiptNumber1 As String
            'xReceiptNumber1 = ""
            'Dim xCheckClaimBillQry1 As String = "SELECT ReceiptNumber FROM ReceiptDetails WHERE IPNo ='" + xIpNo + "' and claimbill='n'"
            'xCon1.Open()
            'Dim sqlcmdReceiptNumber1 As New SqlCommand(xCheckClaimBillQry1, xCon1)
            'Dim myreaderReceiptNumber1 As SqlDataReader
            'myreaderReceiptNumber1 = sqlcmdReceiptNumber1.ExecuteReader()
            'While myreaderReceiptNumber1.Read()
            '    xReceiptNumber1 = myreaderReceiptNumber1.Item("ReceiptNumber").ToString
            'End While
            'xCon1.Close()
            If xReceiptNumber <> "" Then
                Dim xRecieptDoctorFeesDetailsQry As String = "SELECT ipno,doctorfees, ROUND((doctorfees - " + xPercentageValue1.ToString + " * doctorfees) / 25, 0) * 25 AS roundeddoctorfees FROM ReceiptDoctorFeesDetails WHERE IPNo ='" + xIpNo + "' and (doctorname='Dr. Meena' OR doctorname='Dr. Ramalaksmi' OR doctorname='Dr. Laksmanan')"
                xCon1.Open()
                Dim sqlcmd2 As New SqlCommand(xRecieptDoctorFeesDetailsQry, xCon1)
                Dim myreader2 As SqlDataReader
                myreader2 = sqlcmd2.ExecuteReader()
                While myreader2.Read()
                    xBeforeDoctorFeesProcess += myreader2.Item("doctorfees").ToString
                    xAfterDoctorFeesProcess += myreader2.Item("roundeddoctorfees").ToString
                    rchBeforeDoctorFees.Text += myreader2.Item("ipno").ToString + "- " + myreader2.Item("doctorfees").ToString + Environment.NewLine
                    rchAfterDoctorFees.Text += myreader2.Item("ipno").ToString + "- " + myreader2.Item("roundeddoctorfees").ToString + Environment.NewLine
                    'xFinalDoctorFeesProcess = xBeforeDoctorFeesProcess - xAfterDoctorFeesProcess
                End While
                xCon1.Close()
            End If
        End While
        lblBeforeFees.Text = xBeforeParticularsFeesProcess
        lblAfterParticularFees.Text = xAfterParticularsFeesProcess
        lblBeforeDoctorFees.Text = xBeforeDoctorFeesProcess
        lblAfterDoctorFees.Text = xAfterDoctorFeesProcess
        lblTotalParticulars.Text = xAfterParticularsFeesProcess
        lblTotalDoctorFees.Text = xAfterDoctorFeesProcess
        lblGrandTotal.Text = Val(lblTotalRoomRent.Text) + Val(lblTotalParticulars.Text) + Val(lblTotalDoctorFees.Text)
        xCon.Close()
    End Sub

    Private Sub btnInternalFeesProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInternalFeesProcess.Click


        Dim xDischargeQry As String = "SELECT ipno FROM AdmissionDetails " _
        & " WHERE (DischargeDateTime >= '" + dtpfromDate.Text + "' and DischargeDateTime <= '" + dtptoDate.Text + "')"
        'Dim Adpt As New SqlDataAdapter(com, xCon)
        xCon.Open()
        Dim sqlcmd As New SqlCommand(xDischargeQry, xCon)
        Dim myreader As SqlDataReader
        myreader = sqlcmd.ExecuteReader()
        While myreader.Read()
            xFinalDoctorFeesProcess = 0
            xBeforeDoctorFeesProcess = 0
            xAfterDoctorFeesProcess = 0
            xFinalParticularFeesProcess = 0
            xBeforeParticularsFeesProcess = 0
            xAfterParticularsFeesProcess = 0
            Dim xIpNo As String = myreader.Item("ipno").ToString
            Dim xReceiptNumber As String
            xReceiptNumber = ""
            Dim xCheckClaimBillQry As String = "SELECT ReceiptNumber FROM ReceiptDetails WHERE IPNo ='" + xIpNo + "' and claimbill='n'"
            xCon1.Open()
            Dim sqlcmdReceiptNumber As New SqlCommand(xCheckClaimBillQry, xCon1)
            Dim myreaderReceiptNumber As SqlDataReader
            myreaderReceiptNumber = sqlcmdReceiptNumber.ExecuteReader()
            While myreaderReceiptNumber.Read()
                xReceiptNumber = myreaderReceiptNumber.Item("ReceiptNumber").ToString
            End While
            xCon1.Close()
            If xReceiptNumber <> "" Then

                xPercentageValue = txtPercentage.Text.ToString
                xPercentageValue1 = xPercentageValue / 100

                Dim xRecieptDoctorFeesDetailsQry As String = "SELECT ipno,doctorfees, ROUND((doctorfees - " + xPercentageValue1.ToString + " * doctorfees) / 25, 0) * 25 AS roundeddoctorfees FROM ReceiptDoctorFeesDetails WHERE IPNo ='" + xIpNo + "' and (doctorname='Dr. Meena' OR doctorname='Dr. Ramalaksmi' OR doctorname='Dr. Laksmanan')"
                xCon1.Open()
                Dim sqlcmdRecieptDoctorFeesDetails As New SqlCommand(xRecieptDoctorFeesDetailsQry, xCon1)
                Dim myreaderRecieptDoctorFeesDetails As SqlDataReader
                myreaderRecieptDoctorFeesDetails = sqlcmdRecieptDoctorFeesDetails.ExecuteReader()
                While myreaderRecieptDoctorFeesDetails.Read()
                    xBeforeDoctorFeesProcess += myreaderRecieptDoctorFeesDetails.Item("doctorfees").ToString
                    xAfterDoctorFeesProcess += myreaderRecieptDoctorFeesDetails.Item("roundeddoctorfees").ToString
                    xFinalDoctorFeesProcess = xBeforeDoctorFeesProcess - xAfterDoctorFeesProcess
                End While
                xCon1.Close()


                Dim xRecieptDoctorFeesUpdateQry As String = "update ReceiptDoctorFeesDetails set  doctorfees=ROUND((doctorfees - " + xPercentageValue1.ToString + " * doctorfees) / 25, 0) * 25  WHERE IPNo ='" + xIpNo + "' and (doctorname='Dr. Meena' OR doctorname='Dr. Ramalaksmi' OR doctorname='Dr. Laksmanan')"
                xCon1.Open()
                Dim sqlcmdRecieptDoctorFeesUpdate As New SqlCommand(xRecieptDoctorFeesUpdateQry, xCon1)
                Dim myreaderRecieptDoctorFeesUpdate As SqlDataReader
                myreaderRecieptDoctorFeesUpdate = sqlcmdRecieptDoctorFeesUpdate.ExecuteReader()
                xCon1.Close()

      

                Dim xRecieptDoctorFeesTotExpUpdateQry As String = "update  ReceiptDetails set totalexpense=totalexpense-" + xFinalDoctorFeesProcess.ToString + " WHERE IPNo='" + xIpNo + "'"
                xCon1.Open()
                Dim sqlcmdRecieptDoctorFeesTotExpUpdate As New SqlCommand(xRecieptDoctorFeesTotExpUpdateQry, xCon1)
                Dim myreaderRecieptDoctorFeesTotExpUpdate As SqlDataReader
                myreaderRecieptDoctorFeesTotExpUpdate = sqlcmdRecieptDoctorFeesTotExpUpdate.ExecuteReader()
                xCon1.Close()

                xFinalDoctorFeesProcess = 0
                xBeforeDoctorFeesProcess = 0
                xAfterDoctorFeesProcess = 0

                Dim xRecieptParticularsFeesDetailsQry As String = "SELECT ipno,particulars,Fees, ROUND((Fees - " + xPercentageValue1.ToString + " * Fees) / 25, 0) * 25 AS roundedfees FROM ReceiptFeesDetails WHERE IPNo ='" + xIpNo + "'"
                xCon1.Open()

                Dim sqlcmdRecieptParticularsFeesDetails As New SqlCommand(xRecieptParticularsFeesDetailsQry, xCon1)
                Dim myreaderRecieptParticularsFeesDetails As SqlDataReader
                myreaderRecieptParticularsFeesDetails = sqlcmdRecieptParticularsFeesDetails.ExecuteReader()

                While myreaderRecieptParticularsFeesDetails.Read()
                    xBeforeParticularsFeesProcess += myreaderRecieptParticularsFeesDetails.Item("fees").ToString
                    xAfterParticularsFeesProcess += myreaderRecieptParticularsFeesDetails.Item("roundedfees").ToString
                    xFinalParticularFeesProcess = xBeforeParticularsFeesProcess - xAfterParticularsFeesProcess
                End While
                xCon1.Close()


                Dim xRecieptParticularFeesUpdateQry As String = "update  ReceiptFeesDetails set fees=ROUND((Fees - " + xPercentageValue1.ToString + " * Fees) / 25, 0) * 25   WHERE IPNo ='" + xIpNo + "'"
                xCon1.Open()
                Dim sqlcmdRecieptParticularFeesUpdate As New SqlCommand(xRecieptParticularFeesUpdateQry, xCon1)
                Dim myreaderRecieptParticularFeesUpdate As SqlDataReader
                myreaderRecieptParticularFeesUpdate = sqlcmdRecieptParticularFeesUpdate.ExecuteReader()
                xCon1.Close()

    
                Dim xRecieptParticularsTotExpUpdateQry As String = "update  ReceiptDetails set totalexpense=totalexpense-" + xFinalParticularFeesProcess.ToString + " WHERE IPNo='" + xIpNo + "'"
                xCon1.Open()
                Dim sqlcmdRecieptParticularsTotExpUpdate As New SqlCommand(xRecieptParticularsTotExpUpdateQry, xCon1)
                Dim myreaderRecieptParticularsTotExpUpdate As SqlDataReader
                myreaderRecieptParticularsTotExpUpdate = sqlcmdRecieptParticularsTotExpUpdate.ExecuteReader()
                xCon1.Close()
                xFinalParticularFeesProcess = 0
                xBeforeParticularsFeesProcess = 0
                xAfterParticularsFeesProcess = 0
            End If
        End While
        rchBeforeDoctorFees.Text = ""
        rchAfterDoctorFees.Text = ""
        xCon.Close()
    End Sub


    Private Sub ShowOtherDoctorFees()
        Dim xDoctorFees As Integer
        rchDoctorFees.Text = ""
        xDoctorFees = 0
        Dim xDischargeQry As String = "SELECT ipno FROM AdmissionDetails " _
        & " WHERE (DischargeDateTime >= '" + dtpfromDate.Text + "' and DischargeDateTime <= '" + dtptoDate.Text + "')"
        xBeforeDoctorFeesProcess = 0
        xAfterDoctorFeesProcess = 0
        xCon.Open()
        Dim sqlcmd As New SqlCommand(xDischargeQry, xCon)
        Dim myreader As SqlDataReader
        myreader = sqlcmd.ExecuteReader()
        While myreader.Read()


            Dim xIpNo As String = myreader.Item("ipno").ToString
            Dim xRecieptDoctorFeesDetailsQry As String = "SELECT ipno,doctorfees FROM ReceiptDoctorFeesDetails WHERE IPNo='" + xIpNo + "' and doctorname!='Dr. Meena' and doctorname!='Dr. Ramalaksmi' and doctorname!='Dr. Laksmanan'"
            xCon1.Open()

            Dim sqlcmd1 As New SqlCommand(xRecieptDoctorFeesDetailsQry, xCon1)
            Dim myreader1 As SqlDataReader
            myreader1 = sqlcmd1.ExecuteReader()
            While myreader1.Read()
                xDoctorFees += myreader1.Item("doctorfees").ToString
                rchDoctorFees.Text += myreader1.Item("ipno").ToString + "-" + myreader1.Item("doctorfees").ToString + Environment.NewLine
            End While
            xCon1.Close()
        End While
        lblDoctorFees.Text = xDoctorFees
        xCon.Close()
    End Sub

    Private Sub ShowRoomAmount()
        Dim xTotalRoomRent As Integer = 0
        Dim xDischargeQry As String = "SELECT ipno FROM AdmissionDetails " _
        & " WHERE (DischargeDateTime >= '" + dtpfromDate.Text + "' and DischargeDateTime <= '" + dtptoDate.Text + "')"
        xCon.Open()
        Dim sqlcmd As New SqlCommand(xDischargeQry, xCon)
        Dim myreader As SqlDataReader
        myreader = sqlcmd.ExecuteReader()
        While myreader.Read()
            Dim xIpNo As String = myreader.Item("ipno").ToString
            Dim xReceiptNumber As String
            xReceiptNumber = ""
            Dim xCheckClaimBillQry As String = "SELECT ReceiptNumber FROM ReceiptDetails WHERE IPNo ='" + xIpNo + "' and claimbill='n'"
            xCon1.Open()
            Dim sqlcmdReceiptNumber As New SqlCommand(xCheckClaimBillQry, xCon1)
            Dim myreaderReceiptNumber As SqlDataReader
            myreaderReceiptNumber = sqlcmdReceiptNumber.ExecuteReader()
            While myreaderReceiptNumber.Read()
                xReceiptNumber = myreaderReceiptNumber.Item("ReceiptNumber").ToString
            End While
            xCon1.Close()
            If xReceiptNumber <> "" Then
                Dim xRoomRentQuery As String = " SELECT     SUM(RoomRent) AS roomrent FROM RoomFullUsage_Receipt WHERE   IPNo = '" + xIpNo + "'"
                xCon1.Open()
                Dim sqlcmd2 As New SqlCommand(xRoomRentQuery, xCon1)
                Dim myreader2 As SqlDataReader
                myreader2 = sqlcmd2.ExecuteReader()
                While myreader2.Read()
                    xTotalRoomRent += myreader2.Item("roomrent").ToString
                End While
                lblTotalRoomRent.Text = xTotalRoomRent
                xCon1.Close()
            End If

        End While
        xCon.Close()
    End Sub


 
    Private Sub btnfinalProcessShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfinalProcessShow.Click
        rchFinalProcess.Text = ""
        rchFinalProcess.Text += "IPNO ADVANCE  EXPENSE" + Environment.NewLine
        Dim xAdvanceTotal As Integer = 0
        Dim xTotalExpense As Integer = 0

        Dim xDischargeQry As String = "SELECT ipno FROM AdmissionDetails " _
 & " WHERE (DischargeDateTime >= '" + dtpfromDate.Text + "' and DischargeDateTime <= '" + dtptoDate.Text + "')"
        xCon.Open()
        Dim sqlcmd As New SqlCommand(xDischargeQry, xCon)
        Dim myreader As SqlDataReader
        myreader = sqlcmd.ExecuteReader()
        While myreader.Read()
            Dim xIpNo As String = myreader.Item("ipno").ToString
            Dim xReceiptDetailsQry As String = " SELECT * FROM   ReceiptDetails WHERE   IPNo = '" + xIpNo + "'"
            xCon1.Open()
            Dim sqlcmd2 As New SqlCommand(xReceiptDetailsQry, xCon1)
            Dim myreader2 As SqlDataReader
            myreader2 = sqlcmd2.ExecuteReader()
            While myreader2.Read()
                xAdvanceTotal = myreader2.Item("advancetotal").ToString
                xTotalExpense = myreader2.Item("totalexpense").ToString
                If xAdvanceTotal > xTotalExpense Then
                    rchFinalProcess.Text += myreader2.Item("ipno").ToString + "-" + myreader2.Item("advancetotal").ToString + "-" + myreader2.Item("totalexpense").ToString + Environment.NewLine
                End If
            End While
            xCon1.Close()
        End While
        xCon.Close()

    End Sub

  
    Private Sub btnFinalProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalProcess.Click
        rchFinalProcess.Text = ""
        Dim xAdvanceTotal As Integer = 0
        Dim xTotalExpense As Integer = 0
        Dim xTotal As Integer = 0
        Dim xDischargeQry As String = "SELECT ipno FROM AdmissionDetails " _
 & " WHERE (DischargeDateTime >= '" + dtpfromDate.Text + "' and DischargeDateTime <= '" + dtptoDate.Text + "')"

        xCon.Open()
        Dim sqlcmd As New SqlCommand(xDischargeQry, xCon)
        Dim myreader As SqlDataReader
        myreader = sqlcmd.ExecuteReader()
        While myreader.Read()
            Dim xIpNo As String = myreader.Item("ipno").ToString
            Dim xReceiptDetailsQry As String = " SELECT * FROM   ReceiptDetails WHERE   IPNo = '" + xIpNo + "'"
            xCon1.Open()
            Dim sqlcmd2 As New SqlCommand(xReceiptDetailsQry, xCon1)
            Dim myreader2 As SqlDataReader
            myreader2 = sqlcmd2.ExecuteReader()
            While myreader2.Read()
                xAdvanceTotal = myreader2.Item("advancetotal").ToString
                xTotalExpense = myreader2.Item("totalexpense").ToString
                xTotal = xAdvanceTotal - xTotalExpense
                If xAdvanceTotal > xTotalExpense Then
                    Dim xRecieptStatusUpdateQry As String = "update  ReceiptDetails set returnorpaidstatus='R' , total=totalexpense-advancetotal WHERE IPNo ='" + xIpNo + "'"
                    xCon2.Open()
                    Dim sqlcmdRecieptStatusUpdate As New SqlCommand(xRecieptStatusUpdateQry, xCon2)
                    Dim myreaderRecieptStatusUpdate As SqlDataReader
                    myreaderRecieptStatusUpdate = sqlcmdRecieptStatusUpdate.ExecuteReader()
                    xCon2.Close()
                ElseIf xAdvanceTotal = xTotalExpense Then
                    Dim xRecieptStatusUpdateQry As String = "update  ReceiptDetails set returnorpaidstatus='N' WHERE IPNo ='" + xIpNo + "'"
                    xCon2.Open()
                    Dim sqlcmdRecieptStatusUpdate As New SqlCommand(xRecieptStatusUpdateQry, xCon2)
                    Dim myreaderRecieptStatusUpdate As SqlDataReader
                    myreaderRecieptStatusUpdate = sqlcmdRecieptStatusUpdate.ExecuteReader()
                    xCon2.Close()
                Else
                    Dim xRecieptStatusUpdateQry As String = "update  ReceiptDetails set total=totalexpense-advancetotal WHERE IPNo ='" + xIpNo + "'"
                    xCon2.Open()
                    Dim sqlcmdRecieptStatusUpdate As New SqlCommand(xRecieptStatusUpdateQry, xCon2)
                    Dim myreaderRecieptStatusUpdate As SqlDataReader
                    myreaderRecieptStatusUpdate = sqlcmdRecieptStatusUpdate.ExecuteReader()
                    xCon2.Close()
                End If
            End While
            xCon1.Close()
        End While
        xCon.Close()
    End Sub
End Class