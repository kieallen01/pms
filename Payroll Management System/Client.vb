Public Class Client
    Private Sub Client_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        user.Text = FormLogin.wname

        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_payroll")
        Dim sql As String = "select * from tbl_payroll "
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader
        While data.Read
            Dim lv1 As New ListViewItem
            lv1 = ListView.Items.Add(data(0))
            With lv1
                .SubItems.Add(data(1))
                .SubItems.Add(data(2))
                .SubItems.Add(data(3))
                .SubItems.Add(data(4))
                .SubItems.Add(data(5))
                .SubItems.Add(data(6))
                .SubItems.Add(data(7))
                .SubItems.Add(data(8))
                .SubItems.Add(data(9))
                .SubItems.Add(data(10))
                .SubItems.Add(data(11))
                .SubItems.Add(data(12))
                .SubItems.Add(data(13))
                .SubItems.Add(data(14))
                .SubItems.Add(data(15))
                .SubItems.Add(data(16))
            End With
        End While
        conn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        FormLogin.Show()
    End Sub

    Private Sub search_emp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search_emp.TextChanged
        ListView.Items.Clear()
        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_payroll")
        Dim sql As String = "select * from tbl_payroll where employee_id like '" & search_emp.Text & "%' or employee_name like '" & search_emp.Text & "%' or datefrom like '" & search_emp.Text & "%' or dateto like '" & search_emp.Text & "%'"
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader
        While data.Read
            Dim lv As New ListViewItem
            lv = ListView.Items.Add(data(0))
            With lv
                .SubItems.Add(data(1))
                .SubItems.Add(data(2))
                .SubItems.Add(data(3))
                .SubItems.Add(data(4))
                .SubItems.Add(data(5))
                .SubItems.Add(data(6))
                .SubItems.Add(data(7))
                .SubItems.Add(data(8))
                .SubItems.Add(data(9))
                .SubItems.Add(data(10))
                .SubItems.Add(data(11))
                .SubItems.Add(data(12))
                .SubItems.Add(data(13))
                .SubItems.Add(data(14))
                .SubItems.Add(data(15))
                .SubItems.Add(data(16))
            End With
        End While
        conn.Close()
    End Sub

    Private Sub ListView_ItemActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView.ItemActivate
        Dim conn As New MySqlConnection("server = localhost; uid = root ; database = db_payroll")
        Dim sql As String = "select * from tbl_payroll where employee_id = '" & ListView.SelectedItems(0).Text & "' "
        Dim cmd As New MySqlCommand(sql, conn)
        conn.Open()
        Dim data As MySqlDataReader = cmd.ExecuteReader

        If data.Read Then
            lblempname.Text = data(1)
            datefrom.Text = data(15)
            dateto.Text = data(16)
            number_days.Text = data(3)
            number_overtime.Text = data(5)
            daily_rate.Text = data(2)
            overtime_pay.Text = data(6)
            days_absent.Text = data(4)
            absent_deduction.Text = data(10)
            total_deduction.Text = data(12)
            tot_sallary.Text = data(13)
            total_netpay.Text = data(14)
        End If
        conn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    End Sub
End Class