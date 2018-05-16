Imports DAL
Imports DTO
Imports Utility
Public Class DocGiaBUS
    Private dgDAL As DocGiaDAL
    Public Sub New()
        dgDAL = New DocGiaDAL()
    End Sub
    Public Sub New(connectionString As String)
        dgDAL = New DocGiaDAL(connectionString)
    End Sub
    Public Function isValidName(dg As DocGiaDTO) As Boolean
        If (dg.Ten.Length < 1) Then
            Return False
        End If
        Return True
    End Function
    Public Function isValiOld(dg As DocGiaDTO) As Boolean
        If (DateTime.Now.Year - dg.NgaySinh.Year < 18 Or DateTime.Now.Year - dg.NgaySinh.Year > 55) Then
            Return False
        End If
        Return True
    End Function
    Public Function insert(dg As DocGiaDTO) As Result
        Return dgDAL.insert(dg)
    End Function

End Class
