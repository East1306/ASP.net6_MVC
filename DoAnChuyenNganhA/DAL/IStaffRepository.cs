using DoAnChuyenNganhA.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoAnChuyenNganhA.DAL
{
    public interface IStaffRepository : IDisposable
    {
        IEnumerable<NhanVien> GetStaffs();
        NhanVien GetStaffByID(int id);
        void InsertNhanVien (NhanVien nhanVien);
        void DeleteNhanVien(NhanVien nhanVien);
        void UpdateNhanVien(NhanVien nhanVien);
        void Save();

    }
}
