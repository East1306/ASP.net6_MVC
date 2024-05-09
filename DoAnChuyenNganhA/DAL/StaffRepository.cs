using DoAnChuyenNganhA.Data;
using DoAnChuyenNganhA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;

namespace DoAnChuyenNganhA.DAL
{
    public class StaffRepository : IStaffRepository, IDisposable
    {
        private HotelDatabaseContext context;


        public StaffRepository()
        {
        }

        public StaffRepository (HotelDatabaseContext context)
        {
            this.context = context;
        }

        public void DeleteNhanVien(NhanVien nhanVien)
        {
            throw new NotImplementedException();
        }

        public NhanVien GetStaffByID(int id)
        {
            return context.NhanViens.Find(id);
        }

        public IEnumerable<NhanVien> GetStaffs()
        {
            return context.NhanViens.ToList();
        }

        public void InsertNhanVien(NhanVien nhanVien)
        {
            context.NhanViens.Add(nhanVien);
        }

        public void Save()
        {
            context.SaveChanges ();
        }

        public void UpdateNhanVien(NhanVien nhanVien)
        {
            context.Entry(nhanVien).State = EntityState.Modified;
        }

        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue=true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~StaffRepository()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
