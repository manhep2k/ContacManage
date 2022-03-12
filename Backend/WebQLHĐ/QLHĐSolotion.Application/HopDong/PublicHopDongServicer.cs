using QLHĐSolotion.Data.EF;
using QLHĐSolotion.Data.Entity;
using QLHĐSolotion.Data.Extensions;
using QLHĐSolotion.ViewModel.HopDong;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHĐSolotion.Application.HopDong
{
    public class PublicHopDongServicer : IPublicHopDongServicer
    {

        private readonly testDbontext _context;
        //private readonly IStorageService _storageService;

        public PublicHopDongServicer(testDbontext context/*, IStorageService storageService*/)
        {
            _context = context;
            //_storageService= storageService;
        }
        public async Task<List<HopDongViewModel>> GetAll()
        {
            var query = from dt in _context.CtrHopDongs
                        select dt;
            var doitac = await query.Select(x => new HopDongViewModel()
            {
   
                MaHĐ = x.MaHĐ,
                TenHopDong = x.TenHopDong,
                NoiDungHD = x.NoiDungHD,
                NgayLap = x.NgayLap,
                NgayNghiemThu = x.NgayNghiemThu,
                NguoiPhuTrachHopDong = x.NguoiPhuTrachHopDong,
                DonViHDDT = x.DonViHDDT,
                LinkHDDT = x.LinkHDDT,
                TaiKhoanHDDT = x.TaiKhoanHDDT,
                LinkPhanMem = x.LinkPhanMem,
                GiaTriGoiDV = x.GiaTriGoiDV,
                CtrDoiTacID = x.CtrDoiTacID,      
                CtrKhachHangID = x.CtrKhachHangID,
                CtrCongNoID=x.CtrCongNoID,
                TrangThai = x.TrangThai
            }).ToListAsync();

            return doitac;
        }

        //public Task<PagedResult<HopDongViewModels>> GetAllByCategoryId(GetPublicKhachHangPagingRequest request)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<int> Create(HopDongCreateRequest x)
        {
            //x.CtrKhachHangID = Guid.NewGuid();
            var khachHang = new CtrHopDong()
            {
                //CtrKhachHangID = x.CtrKhachHangID,
                MaHĐ = x.MaHĐ,
                TenHopDong = x.TenHopDong,
                NoiDungHD = x.NoiDungHD,
                NgayLap = x.NgayLap,
                NgayNghiemThu = x.NgayNghiemThu,
                NguoiPhuTrachHopDong = x.NguoiPhuTrachHopDong,
                DonViHDDT = x.DonViHDDT,
                LinkHDDT = x.LinkHDDT,
                TaiKhoanHDDT = x.TaiKhoanHDDT,
                LinkPhanMem = x.LinkPhanMem,
                GiaTriGoiDV = x.GiaTriGoiDV,
                CtrDoiTacID = x.CtrDoiTacID,
                CtrKhachHangID = x.CtrKhachHangID,
                CtrCongNoID = x.CtrCongNoID,
                TrangThai = x.TrangThai
            };
            _context.CtrHopDongs.Add(khachHang);
            await _context.SaveChangesAsync();
            return khachHang.CtrHopDongID;
        }

        public async Task<int> Delete(int KhachHangID)
        {

            var khachhang = await _context.CtrHopDongs.FindAsync(KhachHangID);
            if (khachhang == null) throw new EShopException($"Cannot find a product: {KhachHangID}");

            //var images = _context.ProductImages.Where(i => i.ProductId == productId);
            //foreach (var image in images)
            //{
            //    await _storageService.DeleteFileAsync(image.ImagePath);
            //}

            _context.CtrHopDongs.Remove(khachhang);

            return await _context.SaveChangesAsync();
        }

        //public List<DoiTacViewModels> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        public List<HopDongViewModel> GetAllPaging(string keywork, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(HopDongUpdateRequest x)
        {
            var product = await _context.CtrHopDongs.FindAsync(x.CtrHopDongID);
            if (product == null) throw new EShopException($"Cannot find a product with id: {x.CtrHopDongID}");

            {
                {
                    product.MaHĐ = x.MaHĐ;
                    product.TenHopDong = x.TenHopDong;
                    product.NoiDungHD = x.NoiDungHD;
                    product.NgayLap = x.NgayLap;
                    product.NgayNghiemThu = x.NgayNghiemThu;
                    product.NguoiPhuTrachHopDong = x.NguoiPhuTrachHopDong;
                    product.DonViHDDT = x.DonViHDDT;
                    product.LinkHDDT = x.LinkHDDT;
                    product.TaiKhoanHDDT = x.TaiKhoanHDDT;
                    product.LinkPhanMem = x.LinkPhanMem;
                    product.GiaTriGoiDV = x.GiaTriGoiDV;
                    product.CtrDoiTacID = x.CtrDoiTacID;
                    product.CtrKhachHangID = x.CtrKhachHangID;
                    product.CtrCongNoID = x.CtrCongNoID;
                    product.TrangThai = x.TrangThai;
                    _context.CtrHopDongs.Update(product);
                    await _context.SaveChangesAsync();
                    return product.CtrKhachHangID;

                }

            }
        }
    }
}

