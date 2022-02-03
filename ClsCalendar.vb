'=========================================='
' Created by: Ivan Buragas Siqueira Ometto '
' My Github: https://github.com/ivanOmetto '
' =========== Date: 2022/02/02 =========== '
'=========================================='

Public Class ClsCalendar
    Dim sql As String
    Dim objDtLocal As New DataTable
    Dim objbanco As New ClsDataBase
    Private listFlDay As New List(Of FlowLayoutPanel)
    Private currentDate As Date = Date.Today

    Public Sub GeraPainelDeDias(flDays As FlowLayoutPanel)
        Dim totalDays As Integer = 42 ' tamanho do array da tela
        flDays.Controls.Clear()
        listFlDay.Clear()
        For i As Integer = 1 To totalDays
            Dim fl As New FlowLayoutPanel
            fl.Name = $"flDay{i}" ' Adiciona nome a cada caixa
            fl.Size = New Size(128, 99) ' tamanho para cada caixa
            fl.BackColor = Color.FromArgb(64, 64, 64) ' cor de fundo de cada caixa
            fl.BorderStyle = BorderStyle.FixedSingle ' estilo da borda da caixa
            fl.Cursor = Cursors.Hand ' modifica o estilo do cursor
            fl.AutoScroll = True
            AddHandler fl.Click, AddressOf AddNewAppointment
            flDays.Controls.Add(fl)
            listFlDay.Add(fl)
        Next
    End Sub

    Public Sub MostraDataAtual()
        Dim lblMonthAndYear As Label = CalendarNotes.lblMonthAndYear
        lblMonthAndYear.Text = currentDate.ToString("MMMM, yyyy").ToUpper
        Dim firstDayAtFlNumber As Integer = PegaPrimeiroDiaDaSemanaDaDataAtual()
        Dim totalDay As Integer = PegaQuantidadeTotalDeDiasDoMes()

        AdicionaTextoParaFlDay(firstDayAtFlNumber, totalDay)
        AddAppointmentToFlDay(firstDayAtFlNumber)
    End Sub

    Private Function PegaPrimeiroDiaDaSemanaDaDataAtual() As Integer
        Dim firstDayOfMonth As Date = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfMonth.DayOfWeek + 1
    End Function

    Private Function PegaQuantidadeTotalDeDiasDoMes() As Integer
        Dim firstDayOfCurrentDate As Date = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day
    End Function

    Public Sub Hoje()
        currentDate = Date.Today
        MostraDataAtual()
    End Sub
    Public Sub ProximoMes()
        currentDate = currentDate.AddMonths(1)
        MostraDataAtual()
    End Sub
    Public Sub MesAnterior()
        currentDate = currentDate.AddMonths(-1)
        MostraDataAtual()
    End Sub

    Private Sub AdicionaTextoParaFlDay(startDayAtFlNumber As Integer, totalDaysInMonth As Integer)
        For Each fl As FlowLayoutPanel In listFlDay
            fl.Controls.Clear()
            fl.Tag = 0
        Next

        For i As Integer = 1 To totalDaysInMonth
            Dim lbl As New Label
            lbl.Name = $"lblDay{i}"
            lbl.ForeColor = Color.White
            lbl.Padding = New Padding(0, 0, 0, 2)
            lbl.AutoSize = False
            lbl.TextAlign = ContentAlignment.TopCenter
            lbl.Size = New Size(120, 22)
            lbl.Text = i
            lbl.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            listFlDay((i - 1) + (startDayAtFlNumber - 1)).Tag = i
            listFlDay((i - 1) + (startDayAtFlNumber - 1)).Controls.Add(lbl)

            If New Date(currentDate.Year, currentDate.Month, i) = Date.Today Then
                lbl.ForeColor = Color.FromArgb(26, 115, 232)
            End If
        Next
    End Sub

    Friend Sub AddNewAppointment(sender As Object, e As EventArgs)
        Dim day = CType(sender, FlowLayoutPanel).Tag

        If day <> 0 Then
            With CreateNote
                .ShowDialog()
            End With
            MostraDataAtual()
        End If
    End Sub

    Private Sub AddAppointmentToFlDay(startDayAtFlNumber As Integer)
        Dim startDate As Date = New Date(currentDate.Year, currentDate.Month, 1)
        Dim endDate As Date = startDate.AddMonths(1).AddDays(-1)

        sql = $"select * from Note where date between #" & Format(startDate, "yyyy/MM/dd") & "# And #" & Format(endDate, "yyyy/MM/dd") & "#"

        ' objDtLocal = objbanco.QueryAsDataTable(sql)

        For Each row As DataRow In objDtLocal.Rows
            MostraNoCalendario(row, startDayAtFlNumber)
        Next
    End Sub

    Private Sub MostraNoCalendario(row As DataRow, startDayAtFlNumber As Integer)
        Dim datIni As Date = Date.Parse(row("date"))
        Dim link As New LinkLabel
        link.Tag = row("id")
        link.Name = $"link{row("id")}"
        link.Text = row("title")
        link.Font = New Font("Microsoft Sans Serif", 12)
        link.LinkColor = Color.FromArgb(row("colour"))
        ' AddHandler link.Click, AddressOf ShowAppointmentDetail
        listFlDay((datIni.Day - 1) + (startDayAtFlNumber - 1)).Controls.Add(link)
    End Sub
End Class
