using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLHĐSolotion.Data.Migrations
{
    public partial class khachhang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "CtrCongNos",
                columns: table => new
                {
                    CtrCongNoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCongNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TongNo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DaThanhToan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DuNo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KhauTru = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Kyhan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trangthai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CtrCongNos", x => x.CtrCongNoID);
                });

            migrationBuilder.CreateTable(
                name: "CtrDoiTac",
                columns: table => new
                {
                    CtrDoiTacID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDoitac = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenDoiTac = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MaSoThueDT = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    DienThoai = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    TaiKhoanDangNhap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CtrDoiTac", x => x.CtrDoiTacID);
                });

            migrationBuilder.CreateTable(
                name: "CtrKhachHang",
                columns: table => new
                {
                    CtrKhachHangID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenKhachHang = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaSothueKH = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Dienthoai = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Skype = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NgayDangKy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CtrKhachHang", x => x.CtrKhachHangID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CtrHopDongs",
                columns: table => new
                {
                    CtrHopDongID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHĐ = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TenHopDong = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    NoiDungHD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayNghiemThu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiPhuTrachHopDong = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DonViHDDT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LinkHDDT = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TaiKhoanHDDT = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LinkPhanMem = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    GiaTriGoiDV = table.Column<decimal>(type: "money", nullable: false),
                    CtrDoiTacID = table.Column<int>(type: "int", nullable: false),
                    CtrKhachHangID = table.Column<int>(type: "int", nullable: false),
                    CtrCongNoID = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CtrHopDongs", x => x.CtrHopDongID);
                    table.ForeignKey(
                        name: "FK_CtrHopDongs_CtrCongNos_CtrCongNoID",
                        column: x => x.CtrCongNoID,
                        principalTable: "CtrCongNos",
                        principalColumn: "CtrCongNoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CtrHopDongs_CtrDoiTac_CtrDoiTacID",
                        column: x => x.CtrDoiTacID,
                        principalTable: "CtrDoiTac",
                        principalColumn: "CtrDoiTacID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CtrHopDongs_CtrKhachHang_CtrKhachHangID",
                        column: x => x.CtrKhachHangID,
                        principalTable: "CtrKhachHang",
                        principalColumn: "CtrKhachHangID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CtrHopDongs_Users_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "CtrDoiTac",
                columns: new[] { "CtrDoiTacID", "DiaChi", "DienThoai", "MaDoitac", "MaSoThueDT", "TaiKhoanDangNhap", "TenDoiTac" },
                values: new object[] { 1, "phạm văn mạnh", 1555555, "01", 777, "ADMIN", "phạm văn mạnh" });

            migrationBuilder.InsertData(
                table: "CtrDoiTac",
                columns: new[] { "CtrDoiTacID", "DiaChi", "DienThoai", "MaDoitac", "MaSoThueDT", "TaiKhoanDangNhap", "TenDoiTac" },
                values: new object[] { 2, "phạm văn mạnh", 1555555, "02", 777, "ADMIN", "phạm văn mạnh" });

            migrationBuilder.CreateIndex(
                name: "IX_CtrHopDongs_AppUserId",
                table: "CtrHopDongs",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CtrHopDongs_CtrCongNoID",
                table: "CtrHopDongs",
                column: "CtrCongNoID");

            migrationBuilder.CreateIndex(
                name: "IX_CtrHopDongs_CtrDoiTacID",
                table: "CtrHopDongs",
                column: "CtrDoiTacID");

            migrationBuilder.CreateIndex(
                name: "IX_CtrHopDongs_CtrKhachHangID",
                table: "CtrHopDongs",
                column: "CtrKhachHangID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "CtrHopDongs");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "CtrCongNos");

            migrationBuilder.DropTable(
                name: "CtrDoiTac");

            migrationBuilder.DropTable(
                name: "CtrKhachHang");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
