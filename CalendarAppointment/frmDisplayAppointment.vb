Public Class frmDisplayAppointment
    Private listFlDay As New List(Of FlowLayoutPanel)
    Private currentDate As DateTime = DateTime.Today
    Private Sub frmDisplayAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateDayPanel(42)
        DisplayCurrentDate()
    End Sub

    Private Sub AddNewAppointment(ByVal sender As Object, e As EventArgs)
        'Try
        'Dim prdate As DateTime = currentDate
        'If (prdate > currentDate) Then
        Dim day As Integer = CType(sender, FlowLayoutPanel).Tag
        If day <> 0 Then
            With frmManageAppointment
                .AppID = 0
                .txtregid.Text = ""
                .txtPname.Text = ""
                .dtpAppdate.Value = New Date(currentDate.Year, currentDate.Month, day)
                .txtTime.Text = ""
                .txtresponse.Text = ""
                .txtCasetype.Text = ""
                .txtboxremark.Text = ""
                .ShowDialog()
            End With
            DisplayCurrentDate()
        End If
        'End If
        'Catch ex As Exception
        'MsgBox("Please select the the date greater than today to add new appointment", MsgBoxStyle.Critical)
        'End Try
    End Sub

    Private Sub ShowAppointmentDetail(sender As Object, e As EventArgs)
        Dim appID As Integer = CType(sender, LinkLabel).Tag
        Dim sql As String = $"select * from appointmenttbl where id = {appID} and status = 'ongoing'"
        Dim dt As DataTable = QueryAsDataTable(sql)
        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            With frmManageAppointment
                .AppID = appID
                .txtregid.Text = row("patientid")
                .txtPname.Text = row("patientname")
                .dtpAppdate.Value = row("startedappdate")
                .txtTime.Text = row("apptime")
                .txtresponse.Text = row("responseorworkdone")
                .txtCasetype.Text = row("casetype")
                .txtboxremark.Text = row("remarkorother")
                .ShowDialog()
            End With
            DisplayCurrentDate()
        End If
    End Sub

    Private Sub AddAppointmentToFlDay(ByVal startDayAtFlNumber As Integer)
        Dim startDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)
        'MsgBox(currentDate, MsgBoxStyle.Critical)
        'MsgBox(endDate.ToShortDateString(), MsgBoxStyle.Critical)
        Dim sql As String = $"select * from appointmenttbl where startedappdate between '{startDate.ToShortDateString()}' and '{endDate.ToShortDateString()}' and status = 'ongoing'"
        Dim dt As DataTable = QueryAsDataTable(sql)
        For Each row As DataRow In dt.Rows
            Dim appDay As DateTime = DateTime.Parse(row("startedappdate"))
            Dim link As New LinkLabel
            link.Tag = row("id")
            link.Name = $"link{row("id")}"
            link.Text = row("patientname")
            AddHandler link.Click, AddressOf ShowAppointmentDetail
            listFlDay((appDay.Day - 1) + (startDayAtFlNumber - 1)).Controls.Add(link)
        Next
    End Sub

    Private Function GetFirstDayOfWeekOfCurrentDate() As Integer
        Dim firstDayOfMonth As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfMonth.DayOfWeek + 1
    End Function

    Private Function GetTotalDaysOfCurrentDate() As Integer
        Dim firstDayOfCurrentDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day
    End Function

    Private Sub DisplayCurrentDate()
        lblMonthAndYear.Text = currentDate.ToString("MMMM, yyyy")
        Dim firstDayAtFlNumber As Integer = GetFirstDayOfWeekOfCurrentDate()
        Dim totalDay As Integer = GetTotalDaysOfCurrentDate()
        AddLabelDayToFlDay(firstDayAtFlNumber, totalDay)
        AddAppointmentToFlDay(firstDayAtFlNumber)
    End Sub

    Private Sub PrevMonth()
        currentDate = currentDate.AddMonths(-1)
        DisplayCurrentDate()
    End Sub

    Private Sub NextMonth()
        currentDate = currentDate.AddMonths(1)
        DisplayCurrentDate()
    End Sub

    Private Sub Today()
        currentDate = DateTime.Today
        DisplayCurrentDate()
    End Sub

    Private Sub GenerateDayPanel(ByVal totalDays As Integer)
        flDays.Controls.Clear()
        listFlDay.Clear()
        For i As Integer = 1 To totalDays
            Dim fl As New FlowLayoutPanel
            fl.Name = $"flDay{i}"
            fl.Size = New Size(128, 99)
            fl.BackColor = Color.White
            fl.BorderStyle = BorderStyle.FixedSingle
            fl.Cursor = Cursors.Hand
            fl.AutoScroll = True
            AddHandler fl.Click, AddressOf AddNewAppointment
            flDays.Controls.Add(fl)
            listFlDay.Add(fl)
        Next
    End Sub

    Private Sub AddLabelDayToFlDay(ByVal startDayAtFlNumber As Integer, ByVal totalDaysInMonth As Integer)
        For Each fl As FlowLayoutPanel In listFlDay
            fl.Controls.Clear()
            fl.Tag = 0
            fl.BackColor = Color.White
        Next

        For i As Integer = 1 To totalDaysInMonth
            Dim lbl As New Label
            lbl.Name = $"lblDay{i}"
            lbl.AutoSize = False
            lbl.TextAlign = ContentAlignment.MiddleRight
            lbl.Size = New Size(110, 22)
            lbl.Text = i
            lbl.Font = New Font("Microsoft Sans Serif", 12)
            listFlDay((i - 1) + (startDayAtFlNumber - 1)).Tag = i
            listFlDay((i - 1) + (startDayAtFlNumber - 1)).Controls.Add(lbl)

            If New Date(currentDate.Year, currentDate.Month, i) = Date.Today Then
                listFlDay((i - 1) + (startDayAtFlNumber - 1)).BackColor = Color.Aqua
            End If

        Next
    End Sub

    Private Sub btnPrevMonth_Click(sender As Object, e As EventArgs) Handles btnPrevMonth.Click
        PrevMonth()
    End Sub

    Private Sub btnNextMonth_Click(sender As Object, e As EventArgs) Handles btnNextMonth.Click
        NextMonth()
    End Sub

    Private Sub btnToday_Click(sender As Object, e As EventArgs) Handles btnToday.Click
        Today()
    End Sub
End Class