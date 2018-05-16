Imports System.Configuration
Imports System.Configuration.ConfigurationSettings
Imports System.Data.SqlClient
Imports DTO
Imports Utility
Public Class DocGiaDAL
    Private connectionString As String
    Public Sub New()
    End Sub

    Private Function ConfigurationManager() As String
        Throw New NotImplementedException()
    End Function

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function insert(dg As DocGiaDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblDocGia]([mathe],[hoten],[loaithe],[ngaysinh],[diachi],[email],[ngaylapthe],[nguoilapthe],[hansudung])"
        query &= "VALUES (@mathe,@hoten,@loaithe,@ngaysinh,@diachi,@email,@ngaylapthe,@nguoilapthe,@hansudung)"
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@mathe", dg.MaThe)
                    .Parameters.AddWithValue("@hoten", dg.Ten)
                    .Parameters.AddWithValue("@loaithe", dg.LoaiDocGia)
                    .Parameters.AddWithValue("@ngaysinh", dg.NgaySinh)
                    .Parameters.AddWithValue("@diachi", dg.DiaChi)
                    .Parameters.AddWithValue("@email", dg.Email)
                    .Parameters.AddWithValue("@ngaylapthe", dg.NgayLap)
                    .Parameters.AddWithValue("@nguoilapthe", dg.NguoiLap)
                    .Parameters.AddWithValue("@hansudung", dg.NgayHetHan)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lap the doc gai khong thanh cong ", ex.StackTrace)

                End Try

            End Using
        End Using
        Return New Result(True)
    End Function

End Class
