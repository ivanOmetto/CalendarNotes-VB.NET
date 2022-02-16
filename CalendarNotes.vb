'=========================================='
' Created by: Ivan Buragas Siqueira Ometto '
' My Github: https://github.com/ivanOmetto '
' =========== Date: 2022/02/02 =========== '
'=========================================='

Public Class CalendarNotes
    Dim objCalendario As New ClsCalendar
    Private Sub CalendarNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objCalendario.GenerateDashboard(flDays)
        objCalendario.ShowCurrentDate()
    End Sub

    Friend Sub btnToday_Click(sender As Object, e As EventArgs) Handles BtnToday.Click
        objCalendario.Today()
    End Sub

    Private Sub btnNextMonth_Click(sender As Object, e As EventArgs) Handles btnNextMonth.Click
        objCalendario.NewMonth()
    End Sub

    Private Sub btnPrevMonth_Click(sender As Object, e As EventArgs) Handles btnPrevMonth.Click
        objCalendario.LastMonth()
    End Sub
End Class