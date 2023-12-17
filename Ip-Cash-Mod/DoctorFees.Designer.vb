<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorFees
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpfromDate = New System.Windows.Forms.DateTimePicker()
        Me.dtptoDate = New System.Windows.Forms.DateTimePicker()
        Me.btnInternalFeesShow = New System.Windows.Forms.Button()
        Me.btnInternalFeesProcess = New System.Windows.Forms.Button()
        Me.rchInternalFeesShow = New System.Windows.Forms.RichTextBox()
        Me.rchInternalProcessingFeesShow = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPercentage = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblBeforeFees = New System.Windows.Forms.Label()
        Me.lblAfterParticularFees = New System.Windows.Forms.Label()
        Me.lblAfterDoctorFees = New System.Windows.Forms.Label()
        Me.lblBeforeDoctorFees = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rchAfterDoctorFees = New System.Windows.Forms.RichTextBox()
        Me.rchBeforeDoctorFees = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotalRoomRent = New System.Windows.Forms.Label()
        Me.lblTotalParticulars = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTotalDoctorFees = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnfinalProcessShow = New System.Windows.Forms.Button()
        Me.btnFinalProcess = New System.Windows.Forms.Button()
        Me.rchFinalProcess = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(351, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "To Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "From Date"
        '
        'dtpfromDate
        '
        Me.dtpfromDate.CustomFormat = "MM/dd/yyyy hh:mm:ss tt"
        Me.dtpfromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfromDate.Location = New System.Drawing.Point(92, 23)
        Me.dtpfromDate.Name = "dtpfromDate"
        Me.dtpfromDate.Size = New System.Drawing.Size(221, 20)
        Me.dtpfromDate.TabIndex = 53
        '
        'dtptoDate
        '
        Me.dtptoDate.CustomFormat = "MM/dd/yyyy hh:mm:ss tt"
        Me.dtptoDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtptoDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptoDate.Location = New System.Drawing.Point(467, 20)
        Me.dtptoDate.Name = "dtptoDate"
        Me.dtptoDate.Size = New System.Drawing.Size(291, 20)
        Me.dtptoDate.TabIndex = 54
        '
        'btnInternalFeesShow
        '
        Me.btnInternalFeesShow.Location = New System.Drawing.Point(234, 60)
        Me.btnInternalFeesShow.Name = "btnInternalFeesShow"
        Me.btnInternalFeesShow.Size = New System.Drawing.Size(188, 23)
        Me.btnInternalFeesShow.TabIndex = 60
        Me.btnInternalFeesShow.Text = "INTERNAL FEES SHOW"
        Me.btnInternalFeesShow.UseVisualStyleBackColor = True
        '
        'btnInternalFeesProcess
        '
        Me.btnInternalFeesProcess.Location = New System.Drawing.Point(444, 61)
        Me.btnInternalFeesProcess.Name = "btnInternalFeesProcess"
        Me.btnInternalFeesProcess.Size = New System.Drawing.Size(183, 23)
        Me.btnInternalFeesProcess.TabIndex = 61
        Me.btnInternalFeesProcess.Text = "INTERNAL FEES PROCESS"
        Me.btnInternalFeesProcess.UseVisualStyleBackColor = True
        '
        'rchInternalFeesShow
        '
        Me.rchInternalFeesShow.Location = New System.Drawing.Point(12, 134)
        Me.rchInternalFeesShow.Name = "rchInternalFeesShow"
        Me.rchInternalFeesShow.Size = New System.Drawing.Size(357, 204)
        Me.rchInternalFeesShow.TabIndex = 62
        Me.rchInternalFeesShow.Text = ""
        '
        'rchInternalProcessingFeesShow
        '
        Me.rchInternalProcessingFeesShow.Location = New System.Drawing.Point(397, 133)
        Me.rchInternalProcessingFeesShow.Name = "rchInternalProcessingFeesShow"
        Me.rchInternalProcessingFeesShow.Size = New System.Drawing.Size(361, 204)
        Me.rchInternalProcessingFeesShow.TabIndex = 63
        Me.rchInternalProcessingFeesShow.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "PERCENTAGE"
        '
        'txtPercentage
        '
        Me.txtPercentage.Location = New System.Drawing.Point(128, 58)
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.Size = New System.Drawing.Size(100, 20)
        Me.txtPercentage.TabIndex = 65
        Me.txtPercentage.Text = "30"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(395, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 13)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "AFTER PARTICULARS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "BEFORE PARTICULARS"
        '
        'lblBeforeFees
        '
        Me.lblBeforeFees.AutoSize = True
        Me.lblBeforeFees.Location = New System.Drawing.Point(160, 108)
        Me.lblBeforeFees.Name = "lblBeforeFees"
        Me.lblBeforeFees.Size = New System.Drawing.Size(13, 13)
        Me.lblBeforeFees.TabIndex = 68
        Me.lblBeforeFees.Text = "0"
        '
        'lblAfterParticularFees
        '
        Me.lblAfterParticularFees.AutoSize = True
        Me.lblAfterParticularFees.Location = New System.Drawing.Point(551, 108)
        Me.lblAfterParticularFees.Name = "lblAfterParticularFees"
        Me.lblAfterParticularFees.Size = New System.Drawing.Size(13, 13)
        Me.lblAfterParticularFees.TabIndex = 69
        Me.lblAfterParticularFees.Text = "0"
        '
        'lblAfterDoctorFees
        '
        Me.lblAfterDoctorFees.AutoSize = True
        Me.lblAfterDoctorFees.Location = New System.Drawing.Point(557, 365)
        Me.lblAfterDoctorFees.Name = "lblAfterDoctorFees"
        Me.lblAfterDoctorFees.Size = New System.Drawing.Size(13, 13)
        Me.lblAfterDoctorFees.TabIndex = 75
        Me.lblAfterDoctorFees.Text = "0"
        '
        'lblBeforeDoctorFees
        '
        Me.lblBeforeDoctorFees.AutoSize = True
        Me.lblBeforeDoctorFees.Location = New System.Drawing.Point(160, 366)
        Me.lblBeforeDoctorFees.Name = "lblBeforeDoctorFees"
        Me.lblBeforeDoctorFees.Size = New System.Drawing.Size(13, 13)
        Me.lblBeforeDoctorFees.TabIndex = 74
        Me.lblBeforeDoctorFees.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(394, 365)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 13)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "AFTER DOCTOR FEES"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 366)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 13)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "BEFORE DOCTOR FEES"
        '
        'rchAfterDoctorFees
        '
        Me.rchAfterDoctorFees.Location = New System.Drawing.Point(397, 381)
        Me.rchAfterDoctorFees.Name = "rchAfterDoctorFees"
        Me.rchAfterDoctorFees.Size = New System.Drawing.Size(361, 228)
        Me.rchAfterDoctorFees.TabIndex = 71
        Me.rchAfterDoctorFees.Text = ""
        '
        'rchBeforeDoctorFees
        '
        Me.rchBeforeDoctorFees.Location = New System.Drawing.Point(15, 382)
        Me.rchBeforeDoctorFees.Name = "rchBeforeDoctorFees"
        Me.rchBeforeDoctorFees.Size = New System.Drawing.Size(348, 228)
        Me.rchBeforeDoctorFees.TabIndex = 70
        Me.rchBeforeDoctorFees.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 628)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "ROOM RENT"
        '
        'lblTotalRoomRent
        '
        Me.lblTotalRoomRent.AutoSize = True
        Me.lblTotalRoomRent.Location = New System.Drawing.Point(128, 628)
        Me.lblTotalRoomRent.Name = "lblTotalRoomRent"
        Me.lblTotalRoomRent.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalRoomRent.TabIndex = 79
        Me.lblTotalRoomRent.Text = "0"
        '
        'lblTotalParticulars
        '
        Me.lblTotalParticulars.AutoSize = True
        Me.lblTotalParticulars.Location = New System.Drawing.Point(128, 660)
        Me.lblTotalParticulars.Name = "lblTotalParticulars"
        Me.lblTotalParticulars.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalParticulars.TabIndex = 81
        Me.lblTotalParticulars.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(28, 660)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "PARTICULARS"
        '
        'lblTotalDoctorFees
        '
        Me.lblTotalDoctorFees.AutoSize = True
        Me.lblTotalDoctorFees.Location = New System.Drawing.Point(128, 698)
        Me.lblTotalDoctorFees.Name = "lblTotalDoctorFees"
        Me.lblTotalDoctorFees.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalDoctorFees.TabIndex = 83
        Me.lblTotalDoctorFees.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(28, 698)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 13)
        Me.Label14.TabIndex = 82
        Me.Label14.Text = "DOCTOR FEES"
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Location = New System.Drawing.Point(329, 660)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(13, 13)
        Me.lblGrandTotal.TabIndex = 85
        Me.lblGrandTotal.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(229, 660)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "GRAND TOTAL"
        '
        'btnfinalProcessShow
        '
        Me.btnfinalProcessShow.Location = New System.Drawing.Point(780, 86)
        Me.btnfinalProcessShow.Name = "btnfinalProcessShow"
        Me.btnfinalProcessShow.Size = New System.Drawing.Size(155, 23)
        Me.btnfinalProcessShow.TabIndex = 86
        Me.btnfinalProcessShow.Text = "FINAL PROCESS SHOW"
        Me.btnfinalProcessShow.UseVisualStyleBackColor = True
        '
        'btnFinalProcess
        '
        Me.btnFinalProcess.Location = New System.Drawing.Point(780, 415)
        Me.btnFinalProcess.Name = "btnFinalProcess"
        Me.btnFinalProcess.Size = New System.Drawing.Size(106, 23)
        Me.btnFinalProcess.TabIndex = 87
        Me.btnFinalProcess.Text = "FINAL PROCESS "
        Me.btnFinalProcess.UseVisualStyleBackColor = True
        '
        'rchFinalProcess
        '
        Me.rchFinalProcess.Location = New System.Drawing.Point(780, 134)
        Me.rchFinalProcess.Name = "rchFinalProcess"
        Me.rchFinalProcess.Size = New System.Drawing.Size(452, 265)
        Me.rchFinalProcess.TabIndex = 88
        Me.rchFinalProcess.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1018, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 24)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Date : 17/DEC/2023"
        '
        'DoctorFees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1285, 746)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rchFinalProcess)
        Me.Controls.Add(Me.btnFinalProcess)
        Me.Controls.Add(Me.btnfinalProcessShow)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblTotalDoctorFees)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblTotalParticulars)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblTotalRoomRent)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblAfterDoctorFees)
        Me.Controls.Add(Me.lblBeforeDoctorFees)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.rchAfterDoctorFees)
        Me.Controls.Add(Me.rchBeforeDoctorFees)
        Me.Controls.Add(Me.lblAfterParticularFees)
        Me.Controls.Add(Me.lblBeforeFees)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPercentage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rchInternalProcessingFeesShow)
        Me.Controls.Add(Me.rchInternalFeesShow)
        Me.Controls.Add(Me.btnInternalFeesProcess)
        Me.Controls.Add(Me.btnInternalFeesShow)
        Me.Controls.Add(Me.dtptoDate)
        Me.Controls.Add(Me.dtpfromDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DoctorFees"
        Me.Text = "DoctorFees"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpfromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtptoDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnInternalFeesShow As System.Windows.Forms.Button
    Friend WithEvents btnInternalFeesProcess As System.Windows.Forms.Button
    Friend WithEvents rchInternalFeesShow As System.Windows.Forms.RichTextBox
    Friend WithEvents rchInternalProcessingFeesShow As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPercentage As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblBeforeFees As System.Windows.Forms.Label
    Friend WithEvents lblAfterParticularFees As System.Windows.Forms.Label
    Friend WithEvents lblAfterDoctorFees As System.Windows.Forms.Label
    Friend WithEvents lblBeforeDoctorFees As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents rchAfterDoctorFees As System.Windows.Forms.RichTextBox
    Friend WithEvents rchBeforeDoctorFees As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTotalRoomRent As System.Windows.Forms.Label
    Friend WithEvents lblTotalParticulars As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblTotalDoctorFees As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnfinalProcessShow As System.Windows.Forms.Button
    Friend WithEvents btnFinalProcess As System.Windows.Forms.Button
    Friend WithEvents rchFinalProcess As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As Label
End Class
