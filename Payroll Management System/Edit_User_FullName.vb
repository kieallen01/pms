Public Class Edit_User_FullName

    Private Sub Eok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eok.Click
        Dim full As String
        If Ufname.Text = "" Or Umname.Text = "" Or Ulname.Text = "" Then
            MsgBox("Please Fill all Fields", MsgBoxStyle.Critical)
        Else
            full = Ulname.Text + ", " + Ufname.Text + " " + Umname.Text
            Dim a As String = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(full)
            Admin.vufname.Text = a
            Me.Close()
        End If
    End Sub

    Private Sub Ecancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ecancel.Click
        Me.Close()
    End Sub
End Class