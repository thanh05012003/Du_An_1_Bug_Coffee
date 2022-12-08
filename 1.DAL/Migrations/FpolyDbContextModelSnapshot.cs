﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Context;

namespace _1.DAL.Migrations
{
    [DbContext(typeof(FpolyDbContext))]
    partial class FpolyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_1.DAL.DomainClass.Ban", b =>
                {
                    b.Property<string>("Ma")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Ma");

                    b.ToTable("Ban");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.CaLV", b =>
                {
                    b.Property<string>("Ma")
                        .HasColumnType("varchar(20)");

                    b.Property<decimal?>("SoTien")
                        .HasColumnType("money");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("ThoiGianBatDau")
                        .HasColumnType("date");

                    b.Property<DateTime?>("ThoiGianKetThuc")
                        .HasColumnType("date");

                    b.HasKey("Ma");

                    b.ToTable("CaLv");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.ChucVu", b =>
                {
                    b.Property<string>("Ma")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Ma");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.HoaDon", b =>
                {
                    b.Property<string>("Ma")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MaBan")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("MaKH")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("MaNV")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("MaVC")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime");

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Ma");

                    b.HasIndex("MaBan");

                    b.HasIndex("MaKH");

                    b.HasIndex("MaNV");

                    b.HasIndex("MaVC");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.HoaDonCT", b =>
                {
                    b.Property<string>("MaSP")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("MaHD")
                        .HasColumnType("varchar(20)");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("money");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaSP", "MaHD");

                    b.HasIndex("MaHD");

                    b.ToTable("HoaDonCT");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.KhachHang", b =>
                {
                    b.Property<string>("Ma")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiemTL")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Ma");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.LoaiSanPham", b =>
                {
                    b.Property<string>("Ma")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Ma");

                    b.ToTable("LoaiSanPham");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.NhanVien", b =>
                {
                    b.Property<string>("Ma")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MaCLV")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("MaCV")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("date");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ma");

                    b.HasIndex("MaCLV");

                    b.HasIndex("MaCV");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.SanPham", b =>
                {
                    b.Property<string>("Ma")
                        .HasColumnType("varchar(20)");

                    b.Property<decimal>("Gia")
                        .HasColumnType("money");

                    b.Property<string>("MaLsp")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ma");

                    b.HasIndex("MaLsp");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.Voucher", b =>
                {
                    b.Property<string>("Ma")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("GiamGia")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("NgayBatDau")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<DateTime?>("NgayKetThuc")
                        .IsRequired()
                        .HasColumnType("date");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Ma");

                    b.ToTable("Voucher");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.HoaDon", b =>
                {
                    b.HasOne("_1.DAL.DomainClass.Ban", "Ban")
                        .WithMany()
                        .HasForeignKey("MaBan");

                    b.HasOne("_1.DAL.DomainClass.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("MaKH");

                    b.HasOne("_1.DAL.DomainClass.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("MaNV");

                    b.HasOne("_1.DAL.DomainClass.Voucher", "Voucher")
                        .WithMany()
                        .HasForeignKey("MaVC");

                    b.Navigation("Ban");

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");

                    b.Navigation("Voucher");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.HoaDonCT", b =>
                {
                    b.HasOne("_1.DAL.DomainClass.HoaDon", "HoaDon")
                        .WithMany()
                        .HasForeignKey("MaHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.DomainClass.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("MaSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.NhanVien", b =>
                {
                    b.HasOne("_1.DAL.DomainClass.CaLV", "CaLv")
                        .WithMany()
                        .HasForeignKey("MaCLV");

                    b.HasOne("_1.DAL.DomainClass.ChucVu", "ChucVu")
                        .WithMany()
                        .HasForeignKey("MaCV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CaLv");

                    b.Navigation("ChucVu");
                });

            modelBuilder.Entity("_1.DAL.DomainClass.SanPham", b =>
                {
                    b.HasOne("_1.DAL.DomainClass.LoaiSanPham", "LoaiSanPham")
                        .WithMany()
                        .HasForeignKey("MaLsp");

                    b.Navigation("LoaiSanPham");
                });
#pragma warning restore 612, 618
        }
    }
}
