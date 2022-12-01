CREATE TABLE [Ban] (
    [Ma] varchar(20) NOT NULL,
    [Ten] nvarchar(100) NULL,
    [TrangThai] int NOT NULL,
    CONSTRAINT [PK_Ban] PRIMARY KEY ([Ma])
);
GO


CREATE TABLE [CaLv] (
    [Ma] varchar(20) NOT NULL,
    [Ten] nvarchar(100) NULL,
    [ThoiGianBatDau] date NULL,
    [ThoiGianKetThuc] date NULL,
    [SoTien] money NULL,
    CONSTRAINT [PK_CaLv] PRIMARY KEY ([Ma])
);
GO


CREATE TABLE [ChucVu] (
    [Ma] varchar(20) NOT NULL,
    [Ten] nvarchar(100) NULL,
    CONSTRAINT [PK_ChucVu] PRIMARY KEY ([Ma])
);
GO


CREATE TABLE [KhachHang] (
    [Ma] varchar(20) NOT NULL,
    [Ten] nvarchar(100) NULL,
    [SDT] varchar(30) NULL,
    [NgaySinh] datetime2 NULL,
    [DiemTL] int NOT NULL,
    [MaLKH] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_KhachHang] PRIMARY KEY ([Ma])
);
GO


CREATE TABLE [LoaiSanPham] (
    [Ma] varchar(20) NOT NULL,
    [Ten] nvarchar(100) NULL,
    CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY ([Ma])
);
GO


CREATE TABLE [Voucher] (
    [Ma] varchar(20) NOT NULL,
    [Ten] nvarchar(20) NOT NULL,
    [NgayBatDau] date NOT NULL,
    [NgayKetThuc] date NOT NULL,
    [TrangThai] int NOT NULL,
    [GiamGia] int NOT NULL,
    [MoTa] nvarchar(100) NULL,
    CONSTRAINT [PK_Voucher] PRIMARY KEY ([Ma])
);
GO


CREATE TABLE [NhanVien] (
    [Ma] varchar(20) NOT NULL,
    [Ten] nvarchar(100) NOT NULL,
    [GioiTinh] nvarchar(10) NULL,
    [NgaySinh] date NOT NULL,
    [DiaChi] nvarchar(100) NULL,
    [SDT] nvarchar(30) NOT NULL,
    [Email] varchar(100) NULL,
    [TrangThai] int NOT NULL,
    [MatKhau] varchar(max) NOT NULL,
    [MaCV] varchar(20) NOT NULL,
    [MaCLV] varchar(20) NULL,
    CONSTRAINT [PK_NhanVien] PRIMARY KEY ([Ma]),
    CONSTRAINT [FK_NhanVien_CaLv_MaCLV] FOREIGN KEY ([MaCLV]) REFERENCES [CaLv] ([Ma]) ON DELETE NO ACTION,
    CONSTRAINT [FK_NhanVien_ChucVu_MaCV] FOREIGN KEY ([MaCV]) REFERENCES [ChucVu] ([Ma]) ON DELETE CASCADE
);
GO


CREATE TABLE [SanPham] (
    [Ma] varchar(20) NOT NULL,
    [Ten] nvarchar(100) NOT NULL,
    [TrangThai] int NOT NULL,
    [Gia] money NOT NULL,
    [MoTa] nvarchar(100) NULL,
    [MaLsp] varchar(20) NULL,
    CONSTRAINT [PK_SanPham] PRIMARY KEY ([Ma]),
    CONSTRAINT [FK_SanPham_LoaiSanPham_MaLsp] FOREIGN KEY ([MaLsp]) REFERENCES [LoaiSanPham] ([Ma]) ON DELETE NO ACTION
);
GO


CREATE TABLE [HoaDon] (
    [Ma] varchar(20) NOT NULL,
    [MaKH] varchar(20) NULL,
    [MaNV] varchar(20) NULL,
    [NgayTao] date NULL,
    [MaVC] varchar(20) NULL,
    CONSTRAINT [PK_HoaDon] PRIMARY KEY ([Ma]),
    CONSTRAINT [FK_HoaDon_KhachHang_MaKH] FOREIGN KEY ([MaKH]) REFERENCES [KhachHang] ([Ma]) ON DELETE NO ACTION,
    CONSTRAINT [FK_HoaDon_NhanVien_MaNV] FOREIGN KEY ([MaNV]) REFERENCES [NhanVien] ([Ma]) ON DELETE NO ACTION,
    CONSTRAINT [FK_HoaDon_Voucher_MaVC] FOREIGN KEY ([MaVC]) REFERENCES [Voucher] ([Ma]) ON DELETE NO ACTION
);
GO


CREATE TABLE [HoaDonCT] (
    [MaHD] varchar(20) NOT NULL,
    [MaSP] varchar(20) NOT NULL,
    [SoLuong] int NOT NULL,
    [DonGia] money NULL,
    [MaBan] varchar(20) NULL,
    CONSTRAINT [PK_HoaDonCT] PRIMARY KEY ([MaSP], [MaHD]),
    CONSTRAINT [FK_HoaDonCT_Ban_MaBan] FOREIGN KEY ([MaBan]) REFERENCES [Ban] ([Ma]) ON DELETE NO ACTION,
    CONSTRAINT [FK_HoaDonCT_HoaDon_MaHD] FOREIGN KEY ([MaHD]) REFERENCES [HoaDon] ([Ma]) ON DELETE CASCADE,
    CONSTRAINT [FK_HoaDonCT_SanPham_MaSP] FOREIGN KEY ([MaSP]) REFERENCES [SanPham] ([Ma]) ON DELETE CASCADE
);
GO


CREATE INDEX [IX_HoaDon_MaKH] ON [HoaDon] ([MaKH]);
GO


CREATE INDEX [IX_HoaDon_MaNV] ON [HoaDon] ([MaNV]);
GO


CREATE INDEX [IX_HoaDon_MaVC] ON [HoaDon] ([MaVC]);
GO


CREATE INDEX [IX_HoaDonCT_MaBan] ON [HoaDonCT] ([MaBan]);
GO


CREATE INDEX [IX_HoaDonCT_MaHD] ON [HoaDonCT] ([MaHD]);
GO


CREATE INDEX [IX_NhanVien_MaCLV] ON [NhanVien] ([MaCLV]);
GO


CREATE INDEX [IX_NhanVien_MaCV] ON [NhanVien] ([MaCV]);
GO


CREATE INDEX [IX_SanPham_MaLsp] ON [SanPham] ([MaLsp]);
GO


