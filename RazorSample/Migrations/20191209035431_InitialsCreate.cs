using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorSample.Migrations
{
    public partial class InitialsCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DanhSachCapBac",
                columns: table => new
                {
                    CapBacID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaCapBac = table.Column<string>(nullable: true),
                    TenCapBac = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachCapBac", x => x.CapBacID);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachChucVu",
                columns: table => new
                {
                    ChucVuID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaChucVu = table.Column<string>(nullable: true),
                    TenChucVu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachChucVu", x => x.ChucVuID);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachChuyenDe",
                columns: table => new
                {
                    ChuyenDeID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaChuyenDe = table.Column<string>(nullable: true),
                    KhuVuc = table.Column<string>(nullable: true),
                    NgayBatDau = table.Column<DateTime>(nullable: false),
                    NgayKetThuc = table.Column<DateTime>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachChuyenDe", x => x.ChuyenDeID);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachDieuLuat",
                columns: table => new
                {
                    DieuLuatID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaDieuLuat = table.Column<string>(nullable: true),
                    Ten = table.Column<string>(nullable: true),
                    TienPhat = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachDieuLuat", x => x.DieuLuatID);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachKhuVuc",
                columns: table => new
                {
                    KhuVucID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaKhuVuc = table.Column<string>(nullable: true),
                    TenKhuVuc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachKhuVuc", x => x.KhuVucID);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachNguoiDieuKhien",
                columns: table => new
                {
                    NguoiDieuKhienID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cmnd = table.Column<string>(nullable: true),
                    Ten = table.Column<string>(nullable: true),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    DiaChi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachNguoiDieuKhien", x => x.NguoiDieuKhienID);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachQuyen",
                columns: table => new
                {
                    QuyenID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaQuyen = table.Column<string>(nullable: true),
                    TenQuyen = table.Column<string>(nullable: true),
                    MoTaQuyen = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachQuyen", x => x.QuyenID);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachTheLoaiPhuongTien",
                columns: table => new
                {
                    TheLoaiPhuongTienID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaTheLoai = table.Column<string>(nullable: true),
                    TenTheLoai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachTheLoaiPhuongTien", x => x.TheLoaiPhuongTienID);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachDoi",
                columns: table => new
                {
                    DoiID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChuyenDeID = table.Column<int>(nullable: false),
                    MaDoi = table.Column<string>(nullable: true),
                    TenDoi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachDoi", x => x.DoiID);
                    table.ForeignKey(
                        name: "FK_DanhSachDoi_DanhSachChuyenDe_ChuyenDeID",
                        column: x => x.ChuyenDeID,
                        principalTable: "DanhSachChuyenDe",
                        principalColumn: "ChuyenDeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachTuyenDuong",
                columns: table => new
                {
                    TuyenDuongID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KhuVucID = table.Column<int>(nullable: false),
                    MaTuyenDuong = table.Column<string>(nullable: true),
                    TenTuyenDuong = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachTuyenDuong", x => x.TuyenDuongID);
                    table.ForeignKey(
                        name: "FK_DanhSachTuyenDuong_DanhSachKhuVuc_KhuVucID",
                        column: x => x.KhuVucID,
                        principalTable: "DanhSachKhuVuc",
                        principalColumn: "KhuVucID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachBangLai",
                columns: table => new
                {
                    BangLaiID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NguoiDieuKhienID = table.Column<int>(nullable: false),
                    MaBangLai = table.Column<string>(nullable: true),
                    NgayCap = table.Column<DateTime>(nullable: false),
                    HanSuDung = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachBangLai", x => x.BangLaiID);
                    table.ForeignKey(
                        name: "FK_DanhSachBangLai_DanhSachNguoiDieuKhien_NguoiDieuKhienID",
                        column: x => x.NguoiDieuKhienID,
                        principalTable: "DanhSachNguoiDieuKhien",
                        principalColumn: "NguoiDieuKhienID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachTaiKhoan",
                columns: table => new
                {
                    TaiKhoanID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QuyenID = table.Column<int>(nullable: false),
                    TenTaiKhoan = table.Column<string>(nullable: true),
                    MatKhau = table.Column<string>(nullable: true),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachTaiKhoan", x => x.TaiKhoanID);
                    table.ForeignKey(
                        name: "FK_DanhSachTaiKhoan_DanhSachQuyen_QuyenID",
                        column: x => x.QuyenID,
                        principalTable: "DanhSachQuyen",
                        principalColumn: "QuyenID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachPhuongTien",
                columns: table => new
                {
                    PhuongTienID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TheLoaiPhuongTienID = table.Column<int>(nullable: false),
                    CaVet = table.Column<string>(nullable: true),
                    BKS = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachPhuongTien", x => x.PhuongTienID);
                    table.ForeignKey(
                        name: "FK_DanhSachPhuongTien_DanhSachTheLoaiPhuongTien_TheLoaiPhuongTienID",
                        column: x => x.TheLoaiPhuongTienID,
                        principalTable: "DanhSachTheLoaiPhuongTien",
                        principalColumn: "TheLoaiPhuongTienID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachCanBo",
                columns: table => new
                {
                    CanBoID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChucVuID = table.Column<int>(nullable: false),
                    DoiID = table.Column<int>(nullable: false),
                    TaiKhoanID = table.Column<int>(nullable: false),
                    CapBacID = table.Column<int>(nullable: false),
                    MaCanBo = table.Column<string>(nullable: true),
                    Ten = table.Column<string>(nullable: true),
                    TrangThai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachCanBo", x => x.CanBoID);
                    table.ForeignKey(
                        name: "FK_DanhSachCanBo_DanhSachCapBac_CapBacID",
                        column: x => x.CapBacID,
                        principalTable: "DanhSachCapBac",
                        principalColumn: "CapBacID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhSachCanBo_DanhSachChucVu_ChucVuID",
                        column: x => x.ChucVuID,
                        principalTable: "DanhSachChucVu",
                        principalColumn: "ChucVuID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhSachCanBo_DanhSachDoi_DoiID",
                        column: x => x.DoiID,
                        principalTable: "DanhSachDoi",
                        principalColumn: "DoiID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhSachCanBo_DanhSachTaiKhoan_TaiKhoanID",
                        column: x => x.TaiKhoanID,
                        principalTable: "DanhSachTaiKhoan",
                        principalColumn: "TaiKhoanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachBienBan",
                columns: table => new
                {
                    BienBanID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PhuongTienID = table.Column<int>(nullable: false),
                    NguoiDieuKhienID = table.Column<int>(nullable: false),
                    TuyenDuongID = table.Column<int>(nullable: false),
                    MaBienBan = table.Column<string>(nullable: true),
                    ThoiGian = table.Column<DateTime>(nullable: false),
                    TienPhat = table.Column<double>(nullable: false),
                    CanBoID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachBienBan", x => x.BienBanID);
                    table.ForeignKey(
                        name: "FK_DanhSachBienBan_DanhSachCanBo_CanBoID",
                        column: x => x.CanBoID,
                        principalTable: "DanhSachCanBo",
                        principalColumn: "CanBoID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DanhSachBienBan_DanhSachNguoiDieuKhien_NguoiDieuKhienID",
                        column: x => x.NguoiDieuKhienID,
                        principalTable: "DanhSachNguoiDieuKhien",
                        principalColumn: "NguoiDieuKhienID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhSachBienBan_DanhSachPhuongTien_PhuongTienID",
                        column: x => x.PhuongTienID,
                        principalTable: "DanhSachPhuongTien",
                        principalColumn: "PhuongTienID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhSachBienBan_DanhSachTuyenDuong_TuyenDuongID",
                        column: x => x.TuyenDuongID,
                        principalTable: "DanhSachTuyenDuong",
                        principalColumn: "TuyenDuongID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachChiTietBienBan",
                columns: table => new
                {
                    ChiTietBienBanID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DieuLuatID = table.Column<int>(nullable: false),
                    BienBanID = table.Column<int>(nullable: false),
                    MaChiTietBienBan = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachChiTietBienBan", x => x.ChiTietBienBanID);
                    table.ForeignKey(
                        name: "FK_DanhSachChiTietBienBan_DanhSachBienBan_BienBanID",
                        column: x => x.BienBanID,
                        principalTable: "DanhSachBienBan",
                        principalColumn: "BienBanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhSachChiTietBienBan_DanhSachDieuLuat_DieuLuatID",
                        column: x => x.DieuLuatID,
                        principalTable: "DanhSachDieuLuat",
                        principalColumn: "DieuLuatID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachBangLai_NguoiDieuKhienID",
                table: "DanhSachBangLai",
                column: "NguoiDieuKhienID");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachBienBan_CanBoID",
                table: "DanhSachBienBan",
                column: "CanBoID");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachBienBan_NguoiDieuKhienID",
                table: "DanhSachBienBan",
                column: "NguoiDieuKhienID");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachBienBan_PhuongTienID",
                table: "DanhSachBienBan",
                column: "PhuongTienID");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachBienBan_TuyenDuongID",
                table: "DanhSachBienBan",
                column: "TuyenDuongID");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachCanBo_CapBacID",
                table: "DanhSachCanBo",
                column: "CapBacID");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachCanBo_ChucVuID",
                table: "DanhSachCanBo",
                column: "ChucVuID");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachCanBo_DoiID",
                table: "DanhSachCanBo",
                column: "DoiID");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachCanBo_TaiKhoanID",
                table: "DanhSachCanBo",
                column: "TaiKhoanID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachChiTietBienBan_BienBanID",
                table: "DanhSachChiTietBienBan",
                column: "BienBanID");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachChiTietBienBan_DieuLuatID",
                table: "DanhSachChiTietBienBan",
                column: "DieuLuatID");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachDoi_ChuyenDeID",
                table: "DanhSachDoi",
                column: "ChuyenDeID");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachPhuongTien_TheLoaiPhuongTienID",
                table: "DanhSachPhuongTien",
                column: "TheLoaiPhuongTienID");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachTaiKhoan_QuyenID",
                table: "DanhSachTaiKhoan",
                column: "QuyenID");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachTuyenDuong_KhuVucID",
                table: "DanhSachTuyenDuong",
                column: "KhuVucID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DanhSachBangLai");

            migrationBuilder.DropTable(
                name: "DanhSachChiTietBienBan");

            migrationBuilder.DropTable(
                name: "DanhSachBienBan");

            migrationBuilder.DropTable(
                name: "DanhSachDieuLuat");

            migrationBuilder.DropTable(
                name: "DanhSachCanBo");

            migrationBuilder.DropTable(
                name: "DanhSachNguoiDieuKhien");

            migrationBuilder.DropTable(
                name: "DanhSachPhuongTien");

            migrationBuilder.DropTable(
                name: "DanhSachTuyenDuong");

            migrationBuilder.DropTable(
                name: "DanhSachCapBac");

            migrationBuilder.DropTable(
                name: "DanhSachChucVu");

            migrationBuilder.DropTable(
                name: "DanhSachDoi");

            migrationBuilder.DropTable(
                name: "DanhSachTaiKhoan");

            migrationBuilder.DropTable(
                name: "DanhSachTheLoaiPhuongTien");

            migrationBuilder.DropTable(
                name: "DanhSachKhuVuc");

            migrationBuilder.DropTable(
                name: "DanhSachChuyenDe");

            migrationBuilder.DropTable(
                name: "DanhSachQuyen");
        }
    }
}
