Public Class DocGiaDTO
    Private strMaThe As String
    Private strTen As String
    Private strEmail As String
    Private strLoaiDocgia As String
    Private strDiaChi As String
    Private strNguoiLap As String
    Private dateNgaySinh As DateTime
    Private dateNgayLap As DateTime
    Private dateNgayHetHan As DateTime
    Public Sub New()

    End Sub
    Public Sub New(Ten As String, Email As String, LoaiDocGia As String, DiaChi As String, NguoiLap As String, NgaySinh As DateTime, NgayLap As DateTime, NgayHetHan As DateTime, MaThe As String)
        Me.strTen = Ten
        Me.strEmail = Email
        Me.strLoaiDocgia = LoaiDocGia
        Me.strDiaChi = DiaChi
        Me.strNguoiLap = NguoiLap
        Me.dateNgaySinh = NgaySinh
        Me.dateNgayLap = NgayLap
        Me.dateNgayHetHan = NgayHetHan
        Me.strMaThe = MaThe

    End Sub
    Property Ten() As String
        Get
            Return Me.strTen
        End Get
        Set(value As String)
            Me.strTen = value
        End Set
    End Property
    Property Email() As String
        Get
            Return Me.strEmail
        End Get
        Set(value As String)
            Me.strEmail = value
        End Set
    End Property
    Property LoaiDocGia() As String
        Get
            Return Me.strLoaiDocgia
        End Get
        Set(value As String)
            Me.strLoaiDocgia = value
        End Set
    End Property
    Property DiaChi() As String
        Get
            Return Me.strDiaChi
        End Get
        Set(value As String)
            Me.strDiaChi = value
        End Set
    End Property
    Property NguoiLap() As String
        Get
            Return Me.strNguoiLap
        End Get
        Set(value As String)
            Me.strNguoiLap = value
        End Set
    End Property
    Property NgaySinh() As DateTime
        Get
            Return Me.dateNgaySinh
        End Get
        Set(value As DateTime)
            Me.dateNgaySinh = value
        End Set
    End Property
    Property NgayLap() As DateTime
        Get
            Return Me.dateNgayLap
        End Get
        Set(value As DateTime)
            Me.dateNgayLap = value
        End Set
    End Property
    Property NgayHetHan() As DateTime
        Get
            Return Me.dateNgayHetHan
        End Get
        Set(value As DateTime)
            Me.dateNgayHetHan = value
        End Set
    End Property
    Property MaThe() As String
        Get
            Return Me.strMaThe
        End Get
        Set(value As String)
            Me.strMaThe = value
        End Set
    End Property
End Class
