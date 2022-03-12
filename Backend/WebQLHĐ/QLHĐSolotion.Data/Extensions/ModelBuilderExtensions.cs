using Microsoft.EntityFrameworkCore;
using QLHĐSolotion.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHĐSolotion.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CtrDoiTac>().HasData(
              new CtrDoiTac()
              {
                  CtrDoiTacID = 1,
                  MaDoitac = "01",
                  TenDoiTac = "phạm văn mạnh",
                  DiaChi = "phạm văn mạnh", 
                  MaSoThueDT = 777,
                  DienThoai = 1555555,
                  TaiKhoanDangNhap ="ADMIN"

              },
               new CtrDoiTac()
               {
                   CtrDoiTacID = 2,
                   MaDoitac = "02",
                   TenDoiTac = "phạm văn mạnh",
                   DiaChi = "phạm văn mạnh",
                   MaSoThueDT = 777,
                   DienThoai = 1555555,
                   TaiKhoanDangNhap = "ADMIN"
               });

        }
    }
}
