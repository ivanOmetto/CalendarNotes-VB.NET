'=========================================='
' Created by: Ivan Buragas Siqueira Ometto '
' My Github: https://github.com/ivanOmetto '
' =========== Date: 2022/02/02 =========== '
'=========================================='

Public Class ClsDataBase
    Dim con As String = "Provider=microsoft.ace.oledb.12.0;data source=NotesDB.mdb"
    Dim objcon As New OleDb.OleDbConnection(con)

    Private Sub OpenConnection()
        objcon.Open()
    End Sub

    Private Sub CloseConnection()
        If objcon.State = ConnectionState.Open Then
            objcon.Close()
        End If
    End Sub

    Public Sub ExecuteComand(sql As String)
        OpenConnection()
        Dim objcmd As New OleDb.OleDbCommand(sql, objcon)
        objcmd.ExecuteNonQuery()

        CloseConnection()
    End Sub

    ' Returns the sql search as a Data Table
    Public Function QueryAsDataTable(sql As String) As DataTable
        Dim objda As New OleDb.OleDbDataAdapter(sql, objcon)
        Dim objdt As New DataSet
        objda.Fill(objdt, "result")
        Return objdt.Tables("result")
    End Function

    ' Searchs for sql query through id
    Public Function SearchQuery(tabela As String, campo As Integer) As DataSet
        Dim objds As New DataSet

        Dim objda = (New OleDb.OleDbDataAdapter(tabela, objcon))
        objda.SelectCommand.CommandType = CommandType.StoredProcedure
        objda.SelectCommand.Parameters.Add(New OleDb.OleDbParameter("cod", OleDb.OleDbType.Integer))
        objda.SelectCommand.Parameters("cod").Value = campo

        objds.Tables.Clear()
        objda.Fill(objds)

        Select Case objds.Tables(0).Rows.Count
            Case 0
                Console.WriteLine("ERRO DATA SET!")
            Case Else
                Return objds
        End Select
    End Function
End Class
