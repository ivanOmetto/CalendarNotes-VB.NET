Public Class ClsDataBase
    Private relese As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Notes.mdb"
    Public objcon As New OleDb.OleDbConnection(relese)
    Public objclone As New DataTable

    ' abre a conexão com o banco
    Private Sub abrirBanco()
        objcon.Open()
    End Sub

    ' fecha a conexão com o banco
    Private Sub fecharBanco()
        Select Case objcon.State
            Case ConnectionState.Open
                objcon.Close()
        End Select
    End Sub

    ' executa um comando sql
    Public Sub executarComando(sql As String)
        abrirBanco()
        'comando para executar o sql de todas as classes 
        Dim objcmd As New OleDb.OleDbCommand(sql, objcon)
        objcmd.ExecuteNonQuery()
        fecharBanco()
    End Sub

    ' busca ultimo registro da tabela determinada 
    Public Function buscarUltimoRegistro(sql As String) As Integer
        Dim objda As New OleDb.OleDbDataAdapter(sql, objcon)
        Dim objdt As New DataTable
        objda.Fill(objdt)
        Return objdt.Rows(0).Item(0)
    End Function

    ' localiza registro no banco atravez de sql, devolve como datatable
    Public Function localizar(sql As String) As DataTable
        Dim objda As New OleDb.OleDbDataAdapter(sql, objcon)
        Dim objdt As New DataTable
        objda.Fill(objdt)
        Return objdt
    End Function

    ' localiza registro no banco e retorna um dataset
    Public Function QueryAsDataTable(sql As String) As DataTable
        Dim objda As New OleDb.OleDbDataAdapter(sql, objcon)
        Dim objdt As New DataSet
        objda.Fill(objdt, "result")
        Return objdt.Tables("result")
    End Function
End Class
