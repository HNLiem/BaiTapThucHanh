<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.mathe = New System.Windows.Forms.TextBox()
        Me.loaidocgia = New System.Windows.Forms.ComboBox()
        Me.hoten = New System.Windows.Forms.TextBox()
        Me.diachi = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.nguoilapthe = New System.Windows.Forms.TextBox()
        Me.ngaysinh = New System.Windows.Forms.DateTimePicker()
        Dim form11 As Form1 = Me
        form11.ngayhethan = New System.Windows.Forms.DateTimePicker()
        Me.ngaylapthe = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.nhap = New System.Windows.Forms.Button()
        Me.thoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Thẻ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Họ Tên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Địa Chỉ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ngày Sinh"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 459)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Ngày Lập Thẻ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 533)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 17)
        Me.Label7.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 533)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Ngày Hết Hạn"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 607)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Loại Độc Giả"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 255)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Email"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 400)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 17)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Người Lập thẻ"
        '
        'mathe
        '
        Me.mathe.Location = New System.Drawing.Point(239, 46)
        Me.mathe.Name = "mathe"
        Me.mathe.Size = New System.Drawing.Size(300, 22)
        Me.mathe.TabIndex = 2
        '
        'loaidocgia
        '
        Me.loaidocgia.FormattingEnabled = True
        Me.loaidocgia.Location = New System.Drawing.Point(239, 600)
        Me.loaidocgia.Name = "loaidocgia"
        Me.loaidocgia.Size = New System.Drawing.Size(300, 24)
        Me.loaidocgia.TabIndex = 3
        '
        'hoten
        '
        Me.hoten.Location = New System.Drawing.Point(239, 109)
        Me.hoten.Name = "hoten"
        Me.hoten.Size = New System.Drawing.Size(300, 22)
        Me.hoten.TabIndex = 2
        '
        'diachi
        '
        Me.diachi.Location = New System.Drawing.Point(239, 184)
        Me.diachi.Name = "diachi"
        Me.diachi.Size = New System.Drawing.Size(300, 22)
        Me.diachi.TabIndex = 2
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(239, 250)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(300, 22)
        Me.email.TabIndex = 2
        '
        'nguoilapthe
        '
        Me.nguoilapthe.Location = New System.Drawing.Point(239, 395)
        Me.nguoilapthe.Name = "nguoilapthe"
        Me.nguoilapthe.Size = New System.Drawing.Size(300, 22)
        Me.nguoilapthe.TabIndex = 2
        '
        'ngaysinh
        '
        Me.ngaysinh.Location = New System.Drawing.Point(239, 331)
        Me.ngaysinh.Name = "ngaysinh"
        Me.ngaysinh.Size = New System.Drawing.Size(300, 22)
        Me.ngaysinh.TabIndex = 4
        '
        'ngayhethan
        '
        Me.ngayhethan.Location = New System.Drawing.Point(239, 533)
        Me.ngayhethan.Name = "ngayhethan"
        Me.ngayhethan.Size = New System.Drawing.Size(300, 22)
        Me.ngayhethan.TabIndex = 5
        '
        'ngaylapthe
        '
        Me.ngaylapthe.Location = New System.Drawing.Point(239, 459)
        Me.ngaylapthe.Name = "ngaylapthe"
        Me.ngaylapthe.Size = New System.Drawing.Size(300, 22)
        Me.ngaylapthe.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(288, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(187, 26)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Lập Thẻ Độc Giả"
        '
        'nhap
        '
        Me.nhap.Location = New System.Drawing.Point(25, 688)
        Me.nhap.Name = "nhap"
        Me.nhap.Size = New System.Drawing.Size(185, 23)
        Me.nhap.TabIndex = 8
        Me.nhap.Text = "Nhập"
        Me.nhap.UseVisualStyleBackColor = True
        '
        'thoat
        '
        Me.thoat.Location = New System.Drawing.Point(499, 688)
        Me.thoat.Name = "thoat"
        Me.thoat.Size = New System.Drawing.Size(185, 23)
        Me.thoat.TabIndex = 8
        Me.thoat.Text = "Thoát"
        Me.thoat.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 740)
        Me.Controls.Add(Me.thoat)
        Me.Controls.Add(Me.nhap)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ngaylapthe)
        Me.Controls.Add(Me.ngayhethan)
        Me.Controls.Add(Me.ngaysinh)
        Me.Controls.Add(Me.loaidocgia)
        Me.Controls.Add(Me.nguoilapthe)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.diachi)
        Me.Controls.Add(Me.hoten)
        Me.Controls.Add(Me.mathe)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents mathe As TextBox
    Friend WithEvents loaidocgia As ComboBox
    Friend WithEvents hoten As TextBox
    Friend WithEvents diachi As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents nguoilapthe As TextBox
    Friend WithEvents ngaysinh As DateTimePicker
    Friend WithEvents ngayhethan As DateTimePicker
    Friend WithEvents ngaylapthe As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents nhap As Button
    Friend WithEvents thoat As Button
End Class
