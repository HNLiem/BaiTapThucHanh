Imports BUS
Imports DTO
Imports Utility
Public Class Form1
    Private dgBUS As DocGiaBUS
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Khoitao()
    End Sub
    Private Sub Khoitao()
        loaidocgia.Items.Add("x")
        loaidocgia.Items.Add("y")
    End Sub

    Private Sub nhap_Click(sender As Object, e As EventArgs) Handles nhap.Click

        Dim docgia As DocGiaDTO
        docgia = New DocGiaDTO()
        docgia.MaThe = mathe.Text
        docgia.Ten = hoten.Text
        docgia.DiaChi = diachi.Text
        docgia.Email = email.Text
        docgia.NgaySinh = ngaysinh.Value
        docgia.NguoiLap = nguoilapthe.Text
        docgia.NgayLap = ngaylapthe.Value
        docgia.NgayHetHan = ngayhethan.Value
        docgia.LoaiDocGia = loaidocgia.Text
        If (dgBUS.isValidName(docgia) = False) Then
            MessageBox.Show("ho ten khong hop le")
            hoten.Focus()
            Return
        End If
        If (dgBUS.isValiOld(docgia) = False) Then
            MessageBox.Show("tuoi hong hop le")
            ngaysinh.Focus()
            Return
        End If
        Dim result As Result
        result = dgBUS.insert(docgia)
        If (result.FlagResult = True) Then
            MessageBox.Show("lap the doc gia thanh cong", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
        MessageBox.Show("Thêm doc gia không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        System.Console.WriteLine(result.SystemMessage)
        End If



    End Sub
    Private Function ngayhethanthe()

    End Function

    Private Sub thoat_Click(sender As Object, e As EventArgs) Handles thoat.Click
        Application.Exit()
    End Sub
End Class
