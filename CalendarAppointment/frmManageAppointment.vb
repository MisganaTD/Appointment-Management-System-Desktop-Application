Imports System.Data.SqlClient
Public Class frmManageAppointment
    'declare global variable
    Dim conn As New SqlConnection("Server = DESKTOP-QKNE475; Database = PharmacySys; Integrated Security = true")
    Public AppID As Integer = 0
    Private Function vld(ByVal ParamArray ctl() As Object) As Boolean
        'function for validation that check empty
        For i As Integer = 0 To UBound(ctl)
            If ctl(i).text = "" Then
                ErrorProviderMngeApp.SetError(ctl(i), ctl(i).Tag)
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
    Private Sub frmManageAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' btnDelete.Enabled = False
        ' btnDelete.Visible = AppID <> 0
        '-----------------Fill Auto Complete for patientid ------------------------------
        Try
            Dim command As New SqlCommand("select patientid from patienttbl", cn)
            Dim da As New SqlClient.SqlDataAdapter(command)
            Dim ds As New DataSet
            da.Fill(ds, "patienttbl")
            Dim coltel As New AutoCompleteStringCollection
            For i = 0 To ds.Tables(0).Rows.Count - 1
                coltel.Add(ds.Tables(0).Rows(i)(0).ToString)
            Next
            txtregid.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtregid.AutoCompleteCustomSource = coltel
            txtregid.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MsgBox("SQL Conifiguration error", MsgBoxStyle.Information)
        End Try
        '----------------------------------------------------------------------------------------------
    End Sub
    Private Sub btnSaveappont_Click(sender As Object, e As EventArgs) Handles btnSaveappont.Click
        'If String.IsNullOrWhiteSpace(txtPname.Text) Then
        '    MsgBox("Customer or Contact name is required.")
        '    Return
        'End If

        'If IsConfirm("Do you want to save ?") Then
        If vld(txtTime, txtresponse, txtCasetype, txtPname, txtregid) = False Then
            'Exit Sub
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
        Else
            '===========================================================================================
            conn.Open()
            Dim cmder As SqlCommand = New SqlCommand("select patientid from appointmenttbl where patientid=@epd and status = 'ongoing'", conn)
            cmder.Parameters.AddWithValue("@epd", txtregid.Text)
            Dim rdrr As SqlDataReader = cmder.ExecuteReader()
            If rdrr.HasRows Then
                'Dim updateuery As String = "update physiciantbl set status = 0 where physicianid ='" & txtregid.Text & "'"
                'InsertUpdateDelete(updateuery)
                MsgBox("Patient for this id is already have an appointment or no data found", MsgBoxStyle.Critical)
                'MessageBox.Show("Successfully updated!"
                txtregid.Clear()
                txtPname.Clear()
                txtpacampus.Clear()
                Me.Close()
            Else
                '=============================================================================================
                If AppID = 0 Then
                    Dim physiname As String = Mainmenu.lblusername.Text
                    Dim appeidby As String = Mainmenu.lblEID.Text 'employeeid.ToString()
                    Dim pstatus As String = "ongoing"
                    Dim sqlad As String = $"insert into appointmenttbl(patientid,patientname,startedappdate,apptime,physician,casetype,responseorworkdone,remarkorother,status,appeidby) values('" & txtregid.Text & "', '" & txtPname.Text & "', '" & dtpAppdate.Value.ToShortDateString() & "', '" & txtTime.Text & "', '" & physiname & "', '" & txtCasetype.Text & "', '" & txtresponse.Text & "', '" & txtboxremark.Text & "', '" & pstatus & "', '" & appeidby & "')"
                    If InsertUpdateDelete(sqlad) Then
                        MessageBox.Show("Data successfully added", "Data added - Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                        txtregid.Clear()
                        txtPname.Clear()
                        txtpacampus.Clear()
                    Else
                        MsgBox("Failed")
                    End If
                End If
            End If
        End If
        conn.Close()
        'Else
        'Dim sqled As String = $"update appointmenttbl set startedappdate = '{dtpAppdate.Value.ToShortDateString()}', 
        '                                    patientname = '{txtPname.Text}', apptime = '{txtTime.Text}', 
        '                                    responseorworkdone = '{txtresponse.Text}', remarkorother = '{txtboxremark.Text}'
        '                          where id = {AppID}"
        'If InsertUpdateDelete(sqled) Then
        '    'MsgBox("Updated")
        '    MessageBox.Show("Data successfully Updated", "Data updated - Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Close()
        '    Else
        '        MsgBox("Update Failed")
        '    End If
        'End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
#Region "DELETE APPOINTMENT"
    'Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
    '    If IsConfirm("Do you want to delete this appointment ?") Then
    '        Dim sql As String = $"delete from appointmenttbl where id = {AppID}"
    '        If InsertUpdateDelete(sql) Then
    '            'MsgBox("Deleted")
    '            MessageBox.Show("Data successfully Deleted", "Data added - Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Close()
    '        Else
    '            MsgBox("Delete Failed")
    '        End If
    '    End If
    'End Sub
#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim searchCommand As New SqlCommand("select * from patienttbl where patientid=@RegID", cn)
        searchCommand.Parameters.Add("@RegID", SqlDbType.VarChar).Value = txtregid.Text
        Dim da As New SqlDataAdapter(searchCommand)
        Dim table As New DataTable()
        da.Fill(table)
        If table.Rows.Count > 0 Then
            txtPname.Text = table(0)(1)
            txtpacampus.Text = table(0)(5)
        Else
            txtregid.Clear()
            txtPname.Clear()
            txtpacampus.Clear()

            'MsgBox("Patient for this id is already have an appointment or no data found", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtregid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtregid.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, e)
        End If
    End Sub
    Private Sub btnendappont_Click(sender As Object, e As EventArgs) Handles btnendappont.Click
        If vld(txtTime, txtresponse, txtCasetype, txtPname, txtregid) = False Then
            'Exit Sub
            MsgBox("Please select patient form the current month to end appointment for", MsgBoxStyle.Critical)
        ElseIf IsConfirm("Do you want to end this appointment for the selected patient ?") Then
            'Else
            Dim tday As DateTime = DateTime.Today
            Dim sta As String = "ended"
            Dim appendedeidby As String = Mainmenu.lblEID.Text 'employeeid.ToString()
            Dim sql As String = $"update appointmenttbl set endedappdate = '{tday.ToShortDateString()}', 
                                                responseorworkdone = '{txtresponse.Text}',appendeidby='{appendedeidby}',remarkorother = '{txtboxremark.Text}',status = '{sta}'
                                      where id = {AppID}"
            If InsertUpdateDelete(sql) Then
                'MsgBox("Updated")
                MessageBox.Show("Appointment successfully ended", "Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtregid.Clear()
                txtPname.Clear()
                txtpacampus.Clear()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btncont_Click(sender As Object, e As EventArgs) Handles btncont.Click
        If vld(txtTime, txtresponse, txtCasetype, txtPname, txtregid) = False Then
            'Exit Sub
            MsgBox("Please complete the form first ", MsgBoxStyle.Critical)
        Else
            Dim appcontdeidby As String = Mainmenu.lblEID.Text 'employeeid.ToString()
            Dim sqled As String = $"update appointmenttbl set startedappdate = '{dtpAppdate.Value.ToShortDateString()}', 
                                                patientname = '{txtPname.Text}',appcontdeidby='{appcontdeidby}', apptime = '{txtTime.Text}', 
                                                responseorworkdone = '{txtresponse.Text}', remarkorother = '{txtboxremark.Text}'
                                      where id = {AppID}"
            If InsertUpdateDelete(sqled) Then
                'MsgBox("Updated")
                MessageBox.Show("Data successfully Updated", "Data updated - Student Clinic System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtregid.Clear()
                txtPname.Clear()
                txtpacampus.Clear()
                Me.Close()
            Else
                'MsgBox("Update Failed")
                MsgBox("Patient for this id is already have an appointment or no data found", MsgBoxStyle.Critical)
                txtregid.Clear()
                txtPname.Clear()
                txtpacampus.Clear()
            End If
        End If
    End Sub
End Class
