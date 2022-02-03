Public Class ClsNotes
    Dim m_cod, m_col As Integer
    Dim m_tit, m_des As String
    Dim m_dat As Date

    Dim sql As String
    Dim objbanco As New ClsDataBase
    Dim objDtLocal As New DataTable

    Public Property Codigo() As Integer
        Get
            Return m_cod
        End Get
        Set(value As Integer)
            m_cod = value
        End Set
    End Property
    Public Property Colour() As Integer
        Get
            Return m_col
        End Get
        Set(value As Integer)
            m_col = value
        End Set
    End Property
    Public Property Title() As String
        Get
            Return m_tit
        End Get
        Set(value As String)
            m_tit = value
        End Set
    End Property
    Public Property Description() As String
        Get
            Return m_des
        End Get
        Set(value As String)
            m_des = value
        End Set
    End Property
    Public Property DateNote() As Date
        Get
            Return m_dat
        End Get
        Set(value As Date)
            m_dat = value
        End Set
    End Property

    ' gravar dados na database
    Public Sub Gravar(novo As Boolean)
        If novo Then
            sql = "insert into Note " &
                "(title" &
                ",description" &
                ",date" &
                ",colour" &
                ") values " &
                "('" & m_tit & "'" &
                ",'" & m_des & "'" &
                ",'" & m_dat & "'" &
                ",'" & m_col & "'" &
                ")"

            objbanco.executarComando(sql)
            sql = "select max(id) as id from Note"
            m_cod = objbanco.buscarUltimoRegistro(sql)
        Else
            sql = "update Note set " &
                "title='" & m_tit & "'" &
                ", description='" & m_des & "'" &
                ", date='" & m_dat & "'" &
                ", colour=" & m_col & "" &
                " where codnot=" & m_cod
            objbanco.executarComando(sql)
        End If
    End Sub

    Public Function Excluir(chave As Integer) As Boolean
        If MessageBox.Show("Delete note?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "Delete from Note where id=" & chave
            objbanco.executarComando(sql)
            Return True
        End If
    End Function
End Class
