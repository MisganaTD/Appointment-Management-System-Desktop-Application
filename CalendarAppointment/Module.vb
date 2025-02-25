Imports System.Data.SqlClient

Module Module1
    Public cn As New SqlConnection("Server = DESKTOP-QKNE475; Database = PharmacySys; Integrated Security = true")
#Region "Conn for Server"
    'Public State As String
    'Public command As New SqlCommand, da As New SqlDataAdapter, rd As SqlDataReader, ds As New DataSet, table As New DataTable
    'Public Sub Connect()
    '    Cursor.Current = Cursors.WaitCursor
    '    Try
    '        If conn.State = ConnectionState.Closed Then
    '            conn.Open()
    '            Cursor.Current = Cursors.Default
    '            MsgBox("Connected", MsgBoxStyle.Information)
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ErrorToString)
    '    End Try
    'End Sub
    'Public Sub Disconnect()
    '    cn.Close()
    'End Sub
#End Region
    Public Sub Connect()
        If cn.State = ConnectionState.Closed Then cn.Open()
        'If con.State = ConnectionState.Closed Then con.Open()
        'Cursor.Current=Cursors.Default
    End Sub
    Public Function InsertUpdateDelete(ByVal sql As String) As Boolean
        Connect()
        Dim cmd As New SqlCommand(sql, cn)
        Return cmd.ExecuteNonQuery() > 0
    End Function

    Public Function IsConfirm(ByVal message As String) As Boolean
        Return MessageBox.Show(message, "Confirm ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
    End Function
    Public Function QueryAsDataTable(ByVal sql As String) As DataTable
        Dim das As New SqlDataAdapter(sql, cn)
        Dim dss As New DataSet
        das.Fill(dss, "result")
        Return dss.Tables("result")
    End Function
End Module
