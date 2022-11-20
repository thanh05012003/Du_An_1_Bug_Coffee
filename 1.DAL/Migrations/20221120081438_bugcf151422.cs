using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class bugcf151422 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ban",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "varchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false),
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
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ThoiGianBatDau = table.Column<DateTime>(type: "date", nullable: false),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "date", nullable: false),
                    SoTien = table.Column<decimal>(type: "money", nullable: false)
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
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "LoaiKhachHang",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "varchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiKhachHang", x => x.Ma);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "varchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false)
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
                    MoTa = table.Column<string>(type: "nvarchar(100)", nullable: false)
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
                    GioiTinh = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    MatKhau = table.Column<string>(type: "varchar(max)", nullable: false),
                    MaCV = table.Column<string>(type: "varchar(20)", nullable: false),
                    MaCLV = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Ma);
                    table.ForeignKey(
                        name: "FK_NhanVien_CaLv_MaCLV",
                        column: x => x.MaCLV,
                        principalTable: "CaLv",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_MaCV",
                        column: x => x.MaCV,
                        principalTable: "ChucVu",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "varchar(20)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SDT = table.Column<string>(type: "varchar(30)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiemTL = table.Column<int>(type: "int", nullable: false),
                    MaLKH = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Ma);
                    table.ForeignKey(
                        name: "FK_KhachHang_LoaiKhachHang_MaLKH",
                        column: x => x.MaLKH,
                        principalTable: "LoaiKhachHang",
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
                    MoTa = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    MaLsp = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Ma);
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSanPham_MaLsp",
                        column: x => x.MaLsp,
                        principalTable: "LoaiSanPham",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Ma = table.Column<string>(type: "varchar(20)", nullable: false),
                    MaKH = table.Column<string>(type: "varchar(20)", nullable: false),
                    MaNV = table.Column<string>(type: "varchar(20)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "date", nullable: false),
                    MaVC = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Ma);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KhachHang",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
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
                    MaBan = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonCT", x => new { x.MaSP, x.MaHD });
                    table.ForeignKey(
                        name: "FK_HoaDonCT_Ban_MaBan",
                        column: x => x.MaBan,
                        principalTable: "Ban",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_HoaDonCT_MaBan",
                table: "HoaDonCT",
                column: "MaBan");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonCT_MaHD",
                table: "HoaDonCT",
                column: "MaHD");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_MaLKH",
                table: "KhachHang",
                column: "MaLKH");

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
                name: "Ban");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "Voucher");

            migrationBuilder.DropTable(
                name: "LoaiSanPham");

            migrationBuilder.DropTable(
                name: "LoaiKhachHang");

            migrationBuilder.DropTable(
                name: "CaLv");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}
