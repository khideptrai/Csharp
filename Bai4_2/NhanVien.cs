using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_2
{
    public abstract class NhanVien
    {
        public string Ten;
        public string DiaChi;
        public abstract void TinhLuong();
        public abstract void HienThi();
    }
     class NhanVienBanHang : NhanVien
    {
        public int SoLuongBanDuoc;
        public override void TinhLuong()
        {
        }
        public override void HienThi()
        {
        }
    }
     class CongNhan : NhanVien
    {
        public int SoLuongSanpham;
        public override void TinhLuong()
        {
        }
        public override void HienThi()
        {
        }
    }
}
