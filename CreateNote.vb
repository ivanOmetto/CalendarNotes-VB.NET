Public Class CreateNote
    Dim objNotes As New ClsNotes
    Dim codigoCor As Integer
    Friend id As Integer
    Friend n As Boolean

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Close()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        If objNotes.Excluir(id) Then
            Call CalendarNotes.btnToday_Click(Nothing, Nothing)
            Close()
        End If
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        With objNotes
            .Codigo = id
            .Title = TxtTitle.Text
            .DateNote = DtpDate.Value
            .Description = RtbDes.Text
            .Colour = codigoCor
            .Gravar(True)
        End With
    End Sub

    Private Sub BtnCor_Click(sender As Object, e As EventArgs) Handles BtnCor.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            BtnCor.IconColor = ColorDialog1.Color
            codigoCor = ColorDialog1.Color.ToArgb
        End If
    End Sub
End Class