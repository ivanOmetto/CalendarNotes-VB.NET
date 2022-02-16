'=========================================='
' Created by: Ivan Buragas Siqueira Ometto '
' My Github: https://github.com/ivanOmetto '
' =========== Date: 2022/02/02 =========== '
'=========================================='

Public Class CreateNote
    Dim objNotes As New ClsNotes
    Dim colourCode As Integer
    Friend id As Integer
    Friend newNote As Boolean

    Private Sub BtnExi_Click(sender As Object, e As EventArgs) Handles BtnExi.Click
        Close()
    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        If objNotes.Delete(id) Then
            Call CalendarNotes.btnToday_Click(Nothing, Nothing)
            Close()
        End If
    End Sub

    Private Sub BtnSav_Click(sender As Object, e As EventArgs) Handles BtnSav.Click
        With objNotes
            .Cod = id
            .Title = TxtTitle.Text
            .DateNote = DtpDate.Value
            .Description = RtbDes.Text
            .Colour = colourCode
            .Save(newNote)
        End With
        Close()
    End Sub

    Private Sub BtnCor_Click(sender As Object, e As EventArgs) Handles BtnCor.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            BtnCor.IconColor = ColorDialog1.Color
            colourCode = ColorDialog1.Color.ToArgb
        End If
    End Sub
End Class