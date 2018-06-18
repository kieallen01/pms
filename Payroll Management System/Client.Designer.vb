<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client
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
        Me.user = New System.Windows.Forms.Label
        Me.lblwelcome = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dateto = New System.Windows.Forms.DateTimePicker
        Me.datefrom = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.allowance = New System.Windows.Forms.Label
        Me.loans = New System.Windows.Forms.Label
        Me.philhealth = New System.Windows.Forms.Label
        Me.wtax = New System.Windows.Forms.Label
        Me.sss = New System.Windows.Forms.Label
        Me.tot_sallary = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.total_netpay = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.absent_deduction = New System.Windows.Forms.Label
        Me.total_deduction = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.daily_rate = New System.Windows.Forms.TextBox
        Me.number_overtime = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.number_days = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.days_absent = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.overtime_pay = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblempname = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.search_emp = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.ListView = New System.Windows.Forms.ListView
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.ename = New System.Windows.Forms.ColumnHeader
        Me.drate = New System.Windows.Forms.ColumnHeader
        Me.dwork = New System.Windows.Forms.ColumnHeader
        Me.dabsent = New System.Windows.Forms.ColumnHeader
        Me.days_ot = New System.Windows.Forms.ColumnHeader
        Me.otpay = New System.Windows.Forms.ColumnHeader
        Me.dsss = New System.Windows.Forms.ColumnHeader
        Me.dwhtax = New System.Windows.Forms.ColumnHeader
        Me.dph = New System.Windows.Forms.ColumnHeader
        Me.absent_deductions = New System.Windows.Forms.ColumnHeader
        Me.dloans = New System.Windows.Forms.ColumnHeader
        Me.tot_deduct = New System.Windows.Forms.ColumnHeader
        Me.sallary = New System.Windows.Forms.ColumnHeader
        Me.netpay = New System.Windows.Forms.ColumnHeader
        Me.d_from = New System.Windows.Forms.ColumnHeader
        Me.d_to = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'user
        '
        Me.user.BackColor = System.Drawing.Color.Transparent
        Me.user.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.White
        Me.user.Location = New System.Drawing.Point(90, 9)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(158, 23)
        Me.user.TabIndex = 27
        Me.user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblwelcome
        '
        Me.lblwelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblwelcome.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcome.ForeColor = System.Drawing.Color.White
        Me.lblwelcome.Location = New System.Drawing.Point(12, 9)
        Me.lblwelcome.Name = "lblwelcome"
        Me.lblwelcome.Size = New System.Drawing.Size(100, 23)
        Me.lblwelcome.TabIndex = 26
        Me.lblwelcome.Text = "Welcome , "
        Me.lblwelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Maroon
        Me.Button2.Location = New System.Drawing.Point(813, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 31)
        Me.Button2.TabIndex = 79
        Me.Button2.Text = "LOGOUT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.dateto)
        Me.GroupBox1.Controls.Add(Me.datefrom)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.allowance)
        Me.GroupBox1.Controls.Add(Me.loans)
        Me.GroupBox1.Controls.Add(Me.philhealth)
        Me.GroupBox1.Controls.Add(Me.wtax)
        Me.GroupBox1.Controls.Add(Me.sss)
        Me.GroupBox1.Controls.Add(Me.tot_sallary)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.total_netpay)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.absent_deduction)
        Me.GroupBox1.Controls.Add(Me.total_deduction)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.daily_rate)
        Me.GroupBox1.Controls.Add(Me.number_overtime)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.number_days)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.days_absent)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.overtime_pay)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblempname)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.search_emp)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.ListView)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(4, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(905, 507)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        '
        'dateto
        '
        Me.dateto.Enabled = False
        Me.dateto.Location = New System.Drawing.Point(679, 232)
        Me.dateto.Name = "dateto"
        Me.dateto.Size = New System.Drawing.Size(200, 20)
        Me.dateto.TabIndex = 124
        '
        'datefrom
        '
        Me.datefrom.Enabled = False
        Me.datefrom.Location = New System.Drawing.Point(435, 231)
        Me.datefrom.Name = "datefrom"
        Me.datefrom.Size = New System.Drawing.Size(200, 20)
        Me.datefrom.TabIndex = 123
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(8, 471)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(891, 30)
        Me.Button1.TabIndex = 122
        Me.Button1.Text = "PRINT PAYSLIP"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'allowance
        '
        Me.allowance.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.allowance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.allowance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allowance.Location = New System.Drawing.Point(217, 319)
        Me.allowance.Name = "allowance"
        Me.allowance.Size = New System.Drawing.Size(170, 21)
        Me.allowance.TabIndex = 119
        Me.allowance.Text = "1000"
        Me.allowance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'loans
        '
        Me.loans.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.loans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.loans.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loans.Location = New System.Drawing.Point(641, 346)
        Me.loans.Name = "loans"
        Me.loans.Size = New System.Drawing.Size(170, 21)
        Me.loans.TabIndex = 118
        Me.loans.Text = "400"
        Me.loans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'philhealth
        '
        Me.philhealth.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.philhealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.philhealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.philhealth.Location = New System.Drawing.Point(641, 319)
        Me.philhealth.Name = "philhealth"
        Me.philhealth.Size = New System.Drawing.Size(170, 21)
        Me.philhealth.TabIndex = 117
        Me.philhealth.Text = "150"
        Me.philhealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'wtax
        '
        Me.wtax.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.wtax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wtax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wtax.Location = New System.Drawing.Point(641, 293)
        Me.wtax.Name = "wtax"
        Me.wtax.Size = New System.Drawing.Size(170, 21)
        Me.wtax.TabIndex = 116
        Me.wtax.Text = "200"
        Me.wtax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sss
        '
        Me.sss.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sss.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sss.Location = New System.Drawing.Point(641, 267)
        Me.sss.Name = "sss"
        Me.sss.Size = New System.Drawing.Size(170, 21)
        Me.sss.TabIndex = 115
        Me.sss.Text = "200"
        Me.sss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tot_sallary
        '
        Me.tot_sallary.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tot_sallary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tot_sallary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tot_sallary.ForeColor = System.Drawing.Color.DarkRed
        Me.tot_sallary.Location = New System.Drawing.Point(641, 440)
        Me.tot_sallary.Name = "tot_sallary"
        Me.tot_sallary.Size = New System.Drawing.Size(170, 25)
        Me.tot_sallary.TabIndex = 114
        Me.tot_sallary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(509, 444)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 20)
        Me.Label17.TabIndex = 113
        Me.Label17.Text = "TOTAL SALLARY :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(50, 320)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(163, 20)
        Me.Label16.TabIndex = 112
        Me.Label16.Text = "Allowance :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'total_netpay
        '
        Me.total_netpay.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.total_netpay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.total_netpay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_netpay.Location = New System.Drawing.Point(217, 432)
        Me.total_netpay.Name = "total_netpay"
        Me.total_netpay.Size = New System.Drawing.Size(170, 32)
        Me.total_netpay.TabIndex = 111
        Me.total_netpay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(98, 432)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(137, 32)
        Me.Label23.TabIndex = 110
        Me.Label23.Text = "NET PAY "
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'absent_deduction
        '
        Me.absent_deduction.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.absent_deduction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.absent_deduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.absent_deduction.Location = New System.Drawing.Point(641, 374)
        Me.absent_deduction.Name = "absent_deduction"
        Me.absent_deduction.Size = New System.Drawing.Size(170, 21)
        Me.absent_deduction.TabIndex = 109
        Me.absent_deduction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'total_deduction
        '
        Me.total_deduction.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.total_deduction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.total_deduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_deduction.Location = New System.Drawing.Point(641, 407)
        Me.total_deduction.Name = "total_deduction"
        Me.total_deduction.Size = New System.Drawing.Size(170, 25)
        Me.total_deduction.TabIndex = 108
        Me.total_deduction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label25.Location = New System.Drawing.Point(509, 407)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(126, 20)
        Me.Label25.TabIndex = 107
        Me.Label25.Text = "TOTAL DEDUCTIONS :"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label24.Location = New System.Drawing.Point(509, 346)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(126, 20)
        Me.Label24.TabIndex = 106
        Me.Label24.Text = "LOANS :"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(498, 375)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(137, 20)
        Me.Label19.TabIndex = 105
        Me.Label19.Text = "ABSENCES DEDUCTION :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(535, 319)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 20)
        Me.Label20.TabIndex = 104
        Me.Label20.Text = "PHILHEALTH :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(509, 294)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(126, 20)
        Me.Label21.TabIndex = 103
        Me.Label21.Text = "W/HOLDING TAX :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.Location = New System.Drawing.Point(509, 268)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(126, 20)
        Me.Label22.TabIndex = 102
        Me.Label22.Text = "SSS CONTRIBUTION :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(75, 401)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(138, 20)
        Me.Label15.TabIndex = 101
        Me.Label15.Text = "Number of Days Absent :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'daily_rate
        '
        Me.daily_rate.Location = New System.Drawing.Point(217, 347)
        Me.daily_rate.Name = "daily_rate"
        Me.daily_rate.Size = New System.Drawing.Size(170, 20)
        Me.daily_rate.TabIndex = 100
        Me.daily_rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'number_overtime
        '
        Me.number_overtime.Location = New System.Drawing.Point(217, 294)
        Me.number_overtime.Name = "number_overtime"
        Me.number_overtime.Size = New System.Drawing.Size(170, 20)
        Me.number_overtime.TabIndex = 99
        Me.number_overtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(50, 294)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(163, 20)
        Me.Label13.TabIndex = 98
        Me.Label13.Text = "Enter Number of Overtime :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'number_days
        '
        Me.number_days.Location = New System.Drawing.Point(217, 267)
        Me.number_days.Name = "number_days"
        Me.number_days.Size = New System.Drawing.Size(170, 20)
        Me.number_days.TabIndex = 97
        Me.number_days.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(50, 268)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(163, 20)
        Me.Label12.TabIndex = 96
        Me.Label12.Text = "Enter Number of Days Work :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'days_absent
        '
        Me.days_absent.Location = New System.Drawing.Point(217, 401)
        Me.days_absent.Name = "days_absent"
        Me.days_absent.Size = New System.Drawing.Size(170, 20)
        Me.days_absent.TabIndex = 95
        Me.days_absent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(90, 374)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 20)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "Overtime Pay :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'overtime_pay
        '
        Me.overtime_pay.Location = New System.Drawing.Point(217, 375)
        Me.overtime_pay.Name = "overtime_pay"
        Me.overtime_pay.Size = New System.Drawing.Size(170, 20)
        Me.overtime_pay.TabIndex = 93
        Me.overtime_pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(133, 347)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 20)
        Me.Label10.TabIndex = 92
        Me.Label10.Text = "Daily Rate :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(612, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "To :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(358, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "From :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblempname
        '
        Me.lblempname.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblempname.ForeColor = System.Drawing.Color.Red
        Me.lblempname.Location = New System.Drawing.Point(93, 234)
        Me.lblempname.Name = "lblempname"
        Me.lblempname.Size = New System.Drawing.Size(202, 23)
        Me.lblempname.TabIndex = 87
        Me.lblempname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(44, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 23)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Name :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'search_emp
        '
        Me.search_emp.Location = New System.Drawing.Point(66, 15)
        Me.search_emp.Name = "search_emp"
        Me.search_emp.Size = New System.Drawing.Size(205, 20)
        Me.search_emp.TabIndex = 84
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(5, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 14)
        Me.Label18.TabIndex = 85
        Me.Label18.Text = "SEARCH :"
        '
        'ListView
        '
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.ename, Me.drate, Me.dwork, Me.dabsent, Me.days_ot, Me.otpay, Me.dsss, Me.dwhtax, Me.dph, Me.absent_deductions, Me.dloans, Me.tot_deduct, Me.sallary, Me.netpay, Me.d_from, Me.d_to})
        Me.ListView.FullRowSelect = True
        Me.ListView.GridLines = True
        Me.ListView.Location = New System.Drawing.Point(8, 41)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(890, 179)
        Me.ListView.TabIndex = 83
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 84
        '
        'ename
        '
        Me.ename.Text = "Name"
        Me.ename.Width = 124
        '
        'drate
        '
        Me.drate.Text = "Daily Rate"
        '
        'dwork
        '
        Me.dwork.Text = "Days Work"
        '
        'dabsent
        '
        Me.dabsent.Text = "Days Absent"
        '
        'days_ot
        '
        Me.days_ot.Text = "# of Overtime"
        '
        'otpay
        '
        Me.otpay.Text = "OT Rate"
        '
        'dsss
        '
        Me.dsss.Text = "SSS"
        '
        'dwhtax
        '
        Me.dwhtax.Text = "Withholding Tax"
        '
        'dph
        '
        Me.dph.Text = "PhilHealth"
        '
        'absent_deductions
        '
        Me.absent_deductions.Text = "Absent Deductions"
        '
        'dloans
        '
        Me.dloans.Text = "Loans"
        '
        'tot_deduct
        '
        Me.tot_deduct.Text = "Total Deductions"
        '
        'sallary
        '
        Me.sallary.Text = "Total Sallary"
        '
        'netpay
        '
        Me.netpay.Text = "Total Netpay"
        '
        'd_from
        '
        Me.d_from.Text = "Date From"
        '
        'd_to
        '
        Me.d_to.Text = "Date To"
        '
        'Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(914, 562)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.lblwelcome)
        Me.Name = "Client"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Management System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents user As System.Windows.Forms.Label
    Friend WithEvents lblwelcome As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents search_emp As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ListView As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents ename As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblempname As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents allowance As System.Windows.Forms.Label
    Friend WithEvents loans As System.Windows.Forms.Label
    Friend WithEvents philhealth As System.Windows.Forms.Label
    Friend WithEvents wtax As System.Windows.Forms.Label
    Friend WithEvents sss As System.Windows.Forms.Label
    Friend WithEvents tot_sallary As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents total_netpay As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents absent_deduction As System.Windows.Forms.Label
    Friend WithEvents total_deduction As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents daily_rate As System.Windows.Forms.TextBox
    Friend WithEvents number_overtime As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents number_days As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents days_absent As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents overtime_pay As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents drate As System.Windows.Forms.ColumnHeader
    Friend WithEvents dwork As System.Windows.Forms.ColumnHeader
    Friend WithEvents dabsent As System.Windows.Forms.ColumnHeader
    Friend WithEvents days_ot As System.Windows.Forms.ColumnHeader
    Friend WithEvents otpay As System.Windows.Forms.ColumnHeader
    Friend WithEvents dsss As System.Windows.Forms.ColumnHeader
    Friend WithEvents dwhtax As System.Windows.Forms.ColumnHeader
    Friend WithEvents dph As System.Windows.Forms.ColumnHeader
    Friend WithEvents absent_deductions As System.Windows.Forms.ColumnHeader
    Friend WithEvents dloans As System.Windows.Forms.ColumnHeader
    Friend WithEvents tot_deduct As System.Windows.Forms.ColumnHeader
    Friend WithEvents sallary As System.Windows.Forms.ColumnHeader
    Friend WithEvents netpay As System.Windows.Forms.ColumnHeader
    Friend WithEvents d_from As System.Windows.Forms.ColumnHeader
    Friend WithEvents d_to As System.Windows.Forms.ColumnHeader
    Friend WithEvents datefrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateto As System.Windows.Forms.DateTimePicker
End Class
