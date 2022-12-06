using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class bugcf0342021222 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ban",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "varchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ban", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "CaLv",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "varchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ThoiGianBatDau = table.Column<DateTime>(type: "date", nullable: true),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "date", nullable: true),
                    SoTien = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaLv", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "varchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "varchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    SDT = table.Column<string>(type: "varchar(30)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiemTL = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "varchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPham", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "varchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "date", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "date", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    GiamGia = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voucher", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "varchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "date", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    MatKhau = table.Column<string>(type: "varchar(max)", nullable: false),
                    MaCV = table.Column<string>(type: "varchar(20)", nullable: false),
                    MaCLV = table.Column<string>(type: "varchar(20)", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Ma);
                    table.ForeignKey(
                        name: "FK_NhanVien_CaLv_MaCLV",
                        column: x => x.MaCLV,
                        principalTable: "CaLv",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_MaCV",
                        column: x => x.MaCV,
                        principalTable: "ChucVu",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "varchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<decimal>(type: "money", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MaLsp = table.Column<string>(type: "varchar(20)", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Ma);
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSanPham_MaLsp",
                        column: x => x.MaLsp,
                        principalTable: "LoaiSanPham",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "varchar(20)", nullable: false),
                    MaKH = table.Column<string>(type: "varchar(20)", nullable: true),
                    MaNV = table.Column<string>(type: "varchar(20)", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "date", nullable: true),
                    MaVC = table.Column<string>(type: "varchar(20)", nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MaBan = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Ma);
                    table.ForeignKey(
                        name: "FK_HoaDon_Ban_MaBan",
                        column: x => x.MaBan,
                        principalTable: "Ban",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KhachHang",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDon_Voucher_MaVC",
                        column: x => x.MaVC,
                        principalTable: "Voucher",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonCT",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "varchar(20)", nullable: false),
                    MaSP = table.Column<string>(type: "varchar(20)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "money", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonCT", x => new { x.MaSP, x.MaHD });
                    table.ForeignKey(
                        name: "FK_HoaDonCT_HoaDon_MaHD",
                        column: x => x.MaHD,
                        principalTable: "HoaDon",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonCT_SanPham_MaSP",
                        column: x => x.MaSP,
                        principalTable: "SanPham",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaBan",
                table: "HoaDon",
                column: "MaBan");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaKH",
                table: "HoaDon",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaNV",
                table: "HoaDon",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaVC",
                table: "HoaDon",
                column: "MaVC");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCT_MaHD",
                table: "HoaDonCT",
                column: "MaHD");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaCLV",
                table: "NhanVien",
                column: "MaCLV");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaCV",
                table: "NhanVien",
                column: "MaCV");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaLsp",
                table: "SanPham",
                column: "MaLsp");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonCT");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "Ban");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "Voucher");

            migrationBuilder.DropTable(
                name: "LoaiSanPham");

            migrationBuilder.DropTable(
                name: "CaLv");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}
