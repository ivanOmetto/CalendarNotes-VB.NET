Public Class CalendarNotes
    Dim objCalendario As New ClsCalendar
    Private Sub CalendarNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objCalendario.GeraPainelDeDias(flDays)
        objCalendario.MostraDataAtual()
    End Sub

    Friend Sub btnToday_Click(sender As Object, e As EventArgs) Handles btnToday.Click
        objCalendario.Hoje()
    End Sub

    Private Sub btnNextMonth_Click(sender As Object, e As EventArgs) Handles btnNextMonth.Click
        objCalendario.ProximoMes()
    End Sub

    Private Sub btnPrevMonth_Click(sender As Object, e As EventArgs) Handles btnPrevMonth.Click
        objCalendario.MesAnterior()
    End Sub
End Class