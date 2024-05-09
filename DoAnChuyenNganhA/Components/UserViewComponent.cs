using DoAnChuyenNganhA.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoAnChuyenNganhA.Components
{
    public class UserViewComponent : ViewComponent
    {
        public readonly HotelDatabaseContext _dbContext;

        public UserViewComponent (HotelDatabaseContext dbContext)
        {
            _dbContext=dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var staff = await _dbContext.NhanViens.ToListAsync();
            return View(staff);
        }


    }
}
