Public Class Admin

    Private Sub Admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        user.Text = FormLogin.wname
        Dim d As Date = Date.Today


        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_payroll")
        Dim sql As String = "select * from tbl_userManagement "
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader
        While data.Read
            Dim lv1 As New ListViewItem
            lv1 = ListView1.Items.Add(data(0))
            With lv1
                .SubItems.Add(data(1))
                .SubItems.Add(data(2))
                .SubItems.Add(data(3))
            End With
        End While
        conn.Close()

        Dim aconn As New MySqlConnection("server = localhost; uid = root ; database = db_payroll")
        Dim asql As String = "select * from tbl_employee "
        Dim acmd As New MySqlCommand(asql, aconn)
        aconn.Open()
        Dim adata As MySqlDataReader = acmd.ExecuteReader
        While adata.Read
            Dim lv As New ListViewItem
            lv = ListView2.Items.Add(adata(0))
            With lv
                .SubItems.Add(adata(10))
                .SubItems.Add(adata(1))
            End With
        End While
        aconn.Close()

        Dim bconn As New MySqlConnection("server = localhost; uid = root ; database = db_payroll")
        Dim bsql As String = "select * from tbl_payroll "
        Dim bcmd As New MySqlCommand(bsql, bconn)
        bconn.Open()
        Dim bdata As MySqlDataReader = bcmd.ExecuteReader
        While bdata.Read
            Dim lv As New ListViewItem
            lv = ListView3.Items.Add(bdata(0))
            With lv
                .SubItems.Add(bdata(1))
                .SubItems.Add(bdata(15))
                .SubItems.Add(bdata(16))

            End With
        End While
        bconn.Close()
    End Sub



    Private Sub UserSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserSave.Click
        If uusergroup.Text = "" Or uuname.Text = "" Or upword.Text = "" Or urepw.Text = "" Or ufname.Text = "" Or umname.Text = "" Or ulname.Text = "" Then
            MsgBox("Please Fill All Fields", MsgBoxStyle.Critical)
        ElseIf upword.Text <> urepw.Text Then
            MsgBox("Password did not match!", MsgBoxStyle.Critical)

        Else
            Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_payroll")
            Dim sql As String = "select * from tbl_userManagement where username = '" & uuname.Text & "'"
            Dim cmd As New MySqlCommand(sql, conn)
            conn.Open()
            Dim data As MySqlDataReader = cmd.ExecuteReader

            If data.Read Then
                MsgBox("Username is already use!!", MsgBoxStyle.Critical)
            Else
                Dim a As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ufname.Text)
                Dim b As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(umname.Text)
                Dim c As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ulname.Text)
                Dim conn1 As New MySqlConnection("server = localhost;uid=root;database=db_payroll")
                Dim sql1 As String = "INSERT INTO tbl_userManagement values('" & uuname.Text & "','" & upword.Text & "','" & uusergroup.Text & "','" & (c + ", " + a + " " + b) & "')"
                Dim cmd1 As New MySqlCommand(sql1, conn1)
                conn1.Open()
                cmd1.ExecuteNonQuery()

                ListView1.Items.Clear()
                Dim bconn As New MySqlConnection("server = localhost; uid = root ; database = db_payroll")
                Dim bsql As String = "select * from tbl_userManagement "
                Dim bcmd As New MySqlCommand(bsql, bconn)
                bconn.Open()
                Dim bdata As MySqlDataReader = bcmd.ExecuteReader
                While bdata.Read
                    Dim lv2 As New ListViewItem
                    lv2 = ListView1.Items.Add(bdata(0))
                    With lv2
                        .SubItems.Add(bdata(1))
                        .SubItems.Add(bdata(2))
                        .SubItems.Add(bdata(3))
                    End With
                End While
                bconn.Close()

                MsgBox("You Are Now Registered", MsgBoxStyle.Information)
                uusergroup.Text = ""
                uuname.Clear()
                upword.Clear()
                urepw.Clear()
                ufname.Clear()
                umname.Clear()
                ulname.Clear()
                conn1.Close()

            End If
            conn.Close()

        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        ListView1.Items.Clear()
        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_payroll")
        Dim sql As String = "select * from tbl_userManagement where usergroup like '" & TextBox7.Text & "%' or fullname like '" & TextBox7.Text & "%' or username like '" & TextBox7.Text & "%'"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        While data.Read
            Dim lv As New ListViewItem
            lv = ListView1.Items.Add(data(0))
            With lv
                .SubItems.Add(data(1))
                .SubItems.Add(data(2))
                .SubItems.Add(data(3))
            End With
        End While
        conn.Close()
    End Sub

    Private Sub ListView1_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.ItemActivate
        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_payroll")
        Dim sql As String = "select * from tbl_userManagement where username = '" & ListView1.SelectedItems(0).Text & "'"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        If data.Read Then
            lblacclvl.Text = data(2)
            vufname.Text = data(3)
            vuuname.Text = data(0)
            vuuname.Enabled = False
            vupword.Text = data(1)
            vupword.Enabled = False
            vuup.Enabled = False
            vuedit.Enabled = True


        End If
        conn.Close()
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            vupword.UseSystemPasswordChar = False
        Else
            vupword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub vuedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vuedit.Click
        vuedname.Enabled = True
        vuuname.Enabled = True
        vupword.Enabled = True
        vuup.Enabled = True
        vucancel.Enabled = True
        vuedit.Enabled = False
    End Sub

    Private Sub vucancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vucancel.Click
        vufname.Clear()
        vuedname.Enabled = False
        vuuname.Clear()
        vuuname.Enabled = False
        vupword.Clear()
        vupword.Enabled = False
        vuup.Enabled = False
        vucancel.Enabled = False
        vuedit.Enabled = False
        lblacclvl.Text = ""
    End Sub

    Private Sub vuup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vuup.Click
        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_payroll")
        Dim sql As String = "select * from tbl_userManagement where username = '" & vuuname.Text & "'"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        If vuuname.Text = " " Or vupword.Text = " " Or vuuname.Text = "" Or vupword.Text = "" Then
            MsgBox("Please fill all Fields!", MsgBoxStyle.Critical)
        ElseIf data.Read Then
            MsgBox("Username is Already Used!! Try another Username", MsgBoxStyle.Critical)
        Else
            at = ListView1.SelectedItems(0).Text
            updates("update tbl_userManagement set username = '" & vuuname.Text & "',password = '" & vupword.Text & "',fullname = '" & vufname.Text & "' where username = '" & at & "'")
            MsgBox("Successfully Updated!", MsgBoxStyle.Information)

            ListView1.Items.Clear()
            Dim aconn1 As New MySqlConnection("server = localhost; uid = root ; database = db_payroll")
            Dim asql1 As String = "select * from tbl_userManagement "
            Dim acmd1 As New MySqlCommand(asql1, aconn1)
            aconn1.Open()
            Dim adata1 As MySqlDataReader = acmd1.ExecuteReader
            While adata1.Read
                Dim lv As New ListViewItem
                lv = ListView1.Items.Add(adata1(0))
                With lv
                    .SubItems.Add(adata1(1))
                    .SubItems.Add(adata1(2))
                    .SubItems.Add(adata1(3))
                End With
            End While
            aconn1.Close()
            vufname.Text = ""
            vuuname.Clear()
            vuuname.Enabled = False
            lblacclvl.Text = ""
            vupword.Clear()
            vupword.Enabled = False
            vuedname.Enabled = False
            vuup.Enabled = False
            vuedit.Enabled = False
            vucancel.Enabled = False
        End If
    End Sub

    Private Sub dbirth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dbirth.ValueChanged
        Dim d As Date = dbirth.Text
        Age.Text = ""
        Age.Text = Today.Year - d.Year
    End Sub
    Private Sub aempsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aempsave.Click
        If idno.Text = "" Or fname.Text = "" Or mname.Text = "" Or lname.Text = "" Or add.Text = "" Or Age.Text = "" Or pnumber.Text = "" Or dbirth.Text = "" Or pbirth.Text = "" Or gender.Text = "" Or cstatus.Text = "" Or email.Text = "" Then
            MsgBox("Please Fill all Fields", MsgBoxStyle.Critical)
        Else
            Dim conn As New MySqlConnection("server = localhost;uid=root;database=db_payroll")
            Dim sql As String = "Select * from tbl_employee where emp_id = '" & idno.Text & "'"
            Dim cmd As New MySqlCommand(sql, conn)
            conn.Open()
            Dim data As MySqlDataReader = cmd.ExecuteReader

            If data.Read Then
                MsgBox("ID Number is Already in Use", MsgBoxStyle.Critical)
            Else
                'clear and insert
                ListView2.Items.Clear()
                Dim a As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fname.Text)
                Dim b As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(mname.Text)
                Dim c As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lname.Text)

                Dim conn1 As New MySqlConnection("server = localhost;uid=root;database=db_payroll")
                Dim sql1 As String = "INSERT INTO tbl_employee values('" & idno.Text & "','" & (c + ", " + a + " " + b) & "','" & add.Text & "','" & pnumber.Text & "','" & email.Text & "','" & dbirth.Text & "','" & Age.Text & "','" & pbirth.Text & "','" & gender.Text & "','" & cstatus.Text & "','" & startDate.Text & "')"
                Dim cmd1 As New MySqlCommand(sql1, conn1)
                conn1.Open()
                cmd1.ExecuteNonQuery()
                MsgBox("Successfully Saved", MsgBoxStyle.Information)
                fname.Clear()
                mname.Clear()
                lname.Clear()
                add.Clear()
                email.Clear()
                pnumber.Clear()
                Age.Clear()
                dbirth.ResetText()
                startDate.ResetText()
                pbirth.Clear()
                gender.Text = ""
                cstatus.Text = ""
                idno.Text = ""
                conn1.Close()

                'refresh
                Dim aconn As New MySqlConnection("server = localhost; uid = root ; database = db_payroll")
                Dim asql As String = "select * from tbl_employee "
                Dim acmd As New MySqlCommand(asql, aconn)
                aconn.Open()
                Dim adata As MySqlDataReader = acmd.ExecuteReader
                While adata.Read
                    Dim lv As New ListViewItem
                    lv = ListView2.Items.Add(adata(0))
                    With lv
                        .SubItems.Add(adata(10))
                        .SubItems.Add(adata(1))

                    End With
                End While
                aconn.Close()
            End If

            conn.Close()

        End If

    End Sub

    Private Sub ListView2_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView2.ItemActivate
        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_payroll")
        Dim sql As String = "select * from tbl_employee where emp_id = '" & ListView2.SelectedItems(0).Text & "' "
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        If data.Read Then
            empidno.Text = data(0)
            empfname.Text = data(1)
            empadd.Text = data(2)
            empcp.Text = data(3)
            empemail.Text = data(4)
            empdbirth.Text = data(5)
            empage.Text = data(6)
            emppbirth.Text = data(7)
            empgender.Text = data(8)
            empcstatus.Text = data(9)
            empstartdate.Text = data(10)
            emp_up.Enabled = False
            emp_edit.Enabled = True
        End If
        conn.Close()
    End Sub

    Private Sub emp_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emp_edit.Click
        emp_cancel.Enabled = True
        empidno.Enabled = True
        empadd.Enabled = True
        empcp.Enabled = True
        empemail.Enabled = True
        empdbirth.Enabled = True
        empage.Enabled = True
        emppbirth.Enabled = True
        empgender.Enabled = True
        empcstatus.Enabled = True
        emp_up.Enabled = True
        cednm.Enabled = True
        emp_edit.Enabled = False
    End Sub

    Private Sub emp_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emp_cancel.Click
        empfname.Clear()
        empfname.Enabled = False
        cednm.Enabled = False
        empadd.Clear()
        empadd.Enabled = False
        empcp.Clear()
        empcp.Enabled = False
        empage.Text = ""
        empage.Enabled = False
        empdbirth.ResetText()
        empdbirth.Enabled = False
        emppbirth.Clear()
        emppbirth.Enabled = False
        empemail.Clear()
        empemail.Enabled = False
        empgender.Text = ""
        empgender.Enabled = False
        empcstatus.Text = ""
        empcstatus.Enabled = False
        empidno.Text = ""
        empidno.Enabled = False
        empstartdate.Text = ""
        empstartdate.Enabled = False
        emp_up.Enabled = False
        emp_edit.Enabled = False
        emp_cancel.Enabled = False
    End Sub

    Private Sub search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.TextChanged
        ListView2.Items.Clear()
        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_payroll")
        Dim sql As String = "select * from tbl_employee where emp_id like '" & search.Text & "%' or fullname like '" & search.Text & "%' or datestarted like '" & search.Text & "%'"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        While data.Read
            Dim lv As New ListViewItem
            lv = ListView2.Items.Add(data(0))
            With lv
                .SubItems.Add(data(10))
                .SubItems.Add(data(1))
            End With
        End While
        conn.Close()
    End Sub

    Private Sub aeclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aeclear.Click
        fname.Clear()
        mname.Clear()
        lname.Clear()
        add.Clear()
        email.Clear()
        pnumber.Clear()
        Age.Clear()
        dbirth.ResetText()
        startDate.ResetText()
        pbirth.Clear()
        gender.Text = ""
        cstatus.Text = ""
        idno.Text = ""
    End Sub

    Private Sub emp_up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emp_up.Click
        If empadd.Text = "" Or empadd.Text = "" Or empcp.Text = "" Or empemail.Text = "" Or empdbirth.Text = "" Or empage.Text = "" Or emppbirth.Text = "" Or empcstatus.Text = "" Or empgender.Text = "" Then
            MsgBox("Please fill all Fields!", MsgBoxStyle.Critical)

        Else
            an = ListView2.SelectedItems(0).Text
            updates("update tbl_employee set fullname = '" & empfname.Text & "',address = '" & empadd.Text & "',phone_number = '" & empcp.Text & "',email = '" & empemail.Text & "',dateofbirth = '" & empdbirth.Text & "',age = '" & empage.Text & "',placeofbirth = '" & emppbirth.Text & "',gender = '" & empgender.Text & "',civilstatus = '" & empcstatus.Text & "' where emp_id = '" & an & "'")
            MsgBox("Successfully Updated!", MsgBoxStyle.Information)

            ListView2.Items.Clear()
            Dim aconn1 As New MySqlConnection("server = localhost; uid = root ; database = db_payroll")
            Dim asql1 As String = "select * from tbl_employee "
            Dim acmd1 As New MySqlCommand(asql1, aconn1)
            aconn1.Open()
            Dim adata1 As MySqlDataReader = acmd1.ExecuteReader
            While adata1.Read
                Dim lv As New ListViewItem
                lv = ListView2.Items.Add(adata1(0))
                With lv
                    .SubItems.Add(adata1(10))
                    .SubItems.Add(adata1(1))
                End With
            End While
            aconn1.Close()

            empfname.Clear()
            empfname.Enabled = False
            cednm.Enabled = False
            empadd.Clear()
            empadd.Enabled = False
            empcp.Clear()
            empcp.Enabled = False
            empage.Clear()
            empage.Enabled = False
            empdbirth.ResetText()
            empdbirth.Enabled = False
            emppbirth.Clear()
            emppbirth.Enabled = False
            empemail.Clear()
            empemail.Enabled = False
            empgender.Text = ""
            empgender.Enabled = False
            empcstatus.Text = ""
            empcstatus.Enabled = False
            empidno.Text = ""
            empidno.Enabled = False
            emp_up.Enabled = False
            emp_edit.Enabled = False
            emp_cancel.Enabled = False

        End If
    End Sub

    Private Sub vuedname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vuedname.Click
        Edit_User_FullName.Show()
    End Sub

    Private Sub cednm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cednm.Click
        Edit_Employee_FullName.Show()
    End Sub

    Private Sub empdbirth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empdbirth.ValueChanged
        If empdbirth.Enabled = True Then
            Dim d As Date = empdbirth.Text
            empage.Text = Today.Year - d.Year
        End If
    End Sub

    Private Sub emp_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emp_Ok.Click
        Dim conn As New MySqlConnection("server = localhost;uid=root;database=db_payroll")
        Dim sql As String = "Select * from tbl_employee where emp_id = '" & emp_searchID.Text & "'"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        If data.Read Then
            GroupBox1.Enabled = True
            lblempname.Text = data(1)
        ElseIf emp_searchID.Text = "" Then
            MsgBox("Please Enter Employee Account Number", MsgBoxStyle.Critical)
        Else
            MsgBox("Account Number Invalid", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If number_days.Text = "" Or number_overtime.Text = "" Or allowance.Text = "" Or daily_rate.Text = "" Or overtime_pay.Text = "" Or days_absent.Text = "" Then
            MsgBox("Oooops!!! Please Fill all Fields Above", MsgBoxStyle.Critical)
        Else
            Dim date1 As Date = datefrom.Text
            Dim date2 As Date = dateto.Text
            Dim span = date2.AddDays(1.0#) - date1
            Dim days As Double = span.TotalDays '=1

            If days = Val(number_days.Text) Then
                Dim dpays As Decimal = Val(number_days.Text) * Val(daily_rate.Text)
                Dim num_ot As Decimal = Val(number_overtime.Text) * Val(overtime_pay.Text)
                Dim dd_absent As Decimal = Val(days_absent.Text) * Val(daily_rate.Text)
                Dim total_deduct As Decimal = Val(sss.Text) + Val(wtax.Text) + Val(philhealth.Text) + Val(loans.Text) + dd_absent

                tot_sallary.Text = dpays + num_ot
                total_deduction.Text = total_deduct
                total_netpay.Text = (dpays + num_ot) - total_deduct
                save.Enabled = True
            Else
                MsgBox("Please set date of work!", MsgBoxStyle.Critical)
            End If
        End If

    End Sub
    Private Sub days_absent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles days_absent.TextChanged
        absent_deduction.Text = Val(days_absent.Text) * Val(daily_rate.Text)
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Dim regDate As DateTime = DateTime.Now
        Dim strDate As String = regDate.ToString("yyyy-MM-dd HH:mm:ss")
        Dim conn As New MySqlConnection("server = localhost;uid=root;database=db_payroll")
        Dim sql As String = "INSERT INTO tbl_payroll values('" & emp_searchID.Text & "','" & lblempname.Text & "','" & daily_rate.Text & "','" & number_days.Text & "','" & days_absent.Text & "','" & number_overtime.Text & "','" & overtime_pay.Text & "','" & sss.Text & "','" & wtax.Text & "','" & philhealth.Text & "','" & absent_deduction.Text & "','" & loans.Text & "','" & total_deduction.Text & "','" & tot_sallary.Text & "','" & total_netpay.Text & "','" & datefrom.Text & "','" & dateto.Text & "','" & "" & "')"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        cmd.ExecuteNonQuery()
        MsgBox("Employee's Payroll has been Successfuly Saved!!", MsgBoxStyle.Information)
        number_days.Clear()
        number_overtime.Clear()
        daily_rate.Clear()
        overtime_pay.Clear()
        days_absent.Clear()
        absent_deduction.Text = ""
        total_deduction.Text = ""
        tot_sallary.Text = ""
        total_netpay.Text = ""
        datefrom.ResetText()
        dateto.ResetText()
        emp_searchID.Clear()
        GroupBox1.Enabled = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        FormLogin.Show()
    End Sub

    Private Sub search_emp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search_emp.TextChanged
        ListView3.Items.Clear()
        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_payroll")
        Dim sql As String = "select * from tbl_payroll where employee_id like '" & search_emp.Text & "%' or employee_name like '" & search_emp.Text & "%' or datefrom like '" & search_emp.Text & "%' or dateto like '" & search_emp.Text & "%'"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader
        While data.Read
            Dim lv As New ListViewItem
            lv = ListView3.Items.Add(data(0))
            With lv
                .SubItems.Add(data(1))
                .SubItems.Add(data(14))
                .SubItems.Add(data(15))
            End With
        End While
        conn.Close()
    End Sub
    Private Sub ListView3_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView3.ItemActivate
        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_payroll")
        Dim sql As String = "select * from tbl_payroll where employee_id = '" & ListView3.SelectedItems(0).Text & "' "
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        If data.Read Then
            lblid.Text = data(0)
            lblname.Text = data(1)
            d_from.Text = data(15)
            d_to.Text = data(16)
            days_work.Text = data(3)
            overtime.Text = data(5)
            drate.Text = data(2)
            otpay.Text = data(6)
            num_absent.Text = data(4)
            absent_deductions.Text = data(10)
            total_deductions.Text = data(12)
            total_sallary.Text = data(13)
            netpay.Text = data(14)
            Button5.Enabled = True
            Button6.Enabled = True
        End If
        conn.Close()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If days_work.Text = "" Or overtime.Text = "" Or drate.Text = "" Or otpay.Text = "" Or num_absent.Text = "" Then
            MsgBox("Oooops!!! Please Fill all Fields Above", MsgBoxStyle.Critical)
        Else
            Dim dpays As Decimal = Val(days_work.Text) * Val(drate.Text)
            Dim num_ot As Decimal = Val(overtime.Text) * Val(otpay.Text)
            Dim dd_absent As Decimal = Val(num_absent.Text) * Val(drate.Text)
            Dim total_deduct As Decimal = Val(dsss.Text) + Val(dwtax.Text) + Val(dph.Text) + Val(dloans.Text) + dd_absent

            total_sallary.Text = dpays + num_ot
            total_deductions.Text = total_deduct
            netpay.Text = (dpays + num_ot) - total_deduct
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        GroupBox2.Enabled = True
        Button6.Enabled = False
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        an = ListView3.SelectedItems(0).Text
        updates("update tbl_payroll set dateto = '" & d_to.Text & "',datefrom = '" & d_from.Text & "',days_work = '" & days_work.Text & "',days_ot = '" & overtime.Text & "',otpay = '" & otpay.Text & "',days_absent = '" & num_absent.Text & "',absent_deductions = '" & absent_deductions.Text & "',total_deductions = '" & total_deductions.Text & "',total_sallary = '" & total_sallary.Text & "',netpay = '" & netpay.Text & "' where employee_id = '" & an & "'")
        MsgBox("Successfully Updated!", MsgBoxStyle.Information)

        lblid.Text = ""
        lblname.Text = ""
        d_from.ResetText()
        d_to.ResetText()
        days_work.Clear()
        overtime.Clear()
        drate.Clear()
        otpay.Clear()
        num_absent.Clear()
        absent_deductions.Text = ""
        total_deductions.Text = ""
        total_sallary.Text = ""
        netpay.Text = ""
        GroupBox2.Enabled = False
        Button5.Enabled = False

        ListView3.Items.Clear()
        Dim aconn1 As New MySqlConnection("server = localhost; uid = root ; database = db_payroll")
        Dim asql1 As String = "select * from tbl_payroll "
        Dim acmd1 As New MySqlCommand(asql1, aconn1)
        aconn1.Open()
        Dim adata1 As MySqlDataReader = acmd1.ExecuteReader
        While adata1.Read
            Dim lv As New ListViewItem
            lv = ListView3.Items.Add(adata1(0))
            With lv
                .SubItems.Add(adata1(1))
                .SubItems.Add(adata1(15))
                .SubItems.Add(adata1(16))
            End With
        End While
        aconn1.Close()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Form1.Show()
    End Sub

    Private Sub dateto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateto.ValueChanged
        Dim dfrom As Date = datefrom.Text
        Dim dto As Date = dateto.Text
        number_days.Text = ""
        number_days.Text = dto.Day - dfrom.Day
    End Sub

End Class