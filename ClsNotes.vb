'=========================================='
' Created by: Ivan Buragas Siqueira Ometto '
' My Github: https://github.com/ivanOmetto '
' =========== Date: 2022/02/02 =========== '
'=========================================='

Public Class ClsNotes
    Dim m_cod, m_col As Integer
    Dim m_tit, m_des As String
    Dim m_dat As Date

    Dim sql As String
    Dim objBanco As New ClsDataBase
    Dim objDtLocal As New DataTable

    Public Property Cod() As Integer
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

    Public Sub Save(novo As Boolean)
        If novo Then
            sql = "insert into TabNote (titnot, datnot, desnot, colnot) values ('" & m_tit & "','" & m_dat & "', '" & m_des & "', '" & m_col & "')"
            objBanco.ExecuteComand(sql)
        Else
            sql = "update TabNote set titnot='" & m_tit & "', datnot='" & m_dat & "', desnot='" & m_des & "', colnot='" & m_col & "' where codnot=" & m_cod
            objBanco.ExecuteComand(sql)
        End If
    End Sub

    Public Function Delete(id As Integer) As Boolean
        If MessageBox.Show("Delete note?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "delete from TabNote where codnot=" & id
            objBanco.ExecuteComand(sql)
            Return True
        End If
    End Function

    Public Sub Loc(cod As Integer)
        Dim objds = objBanco.SearchQuery("ConNote", cod)

        m_cod = objds.Tables(0).Rows(0).Item(0)
        m_tit = objds.Tables(0).Rows(0).Item(1)
        m_dat = objds.Tables(0).Rows(0).Item(2)
        m_des = objds.Tables(0).Rows(0).Item(3)
        m_col = objds.Tables(0).Rows(0).Item(4)
    End Sub
End Class
