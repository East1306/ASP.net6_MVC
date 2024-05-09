using DoAnChuyenNganhA.DAL;
using DoAnChuyenNganhA.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DoAnChuyenNganhA.Controllers
{
    public class StaffController: Controller
    {
        //private readonly HotelDatabaseContext _dbContext;
        private IStaffRepository _staffRepository;

        public StaffController(IStaffRepository staffRepository)
        {
            this._staffRepository = staffRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult User(string name)
        {   

            var stf = from s in _staffRepository.GetStaffs()
                      select s;
            if (!String.IsNullOrEmpty(name))
            {
                stf = stf.Where(s => s.TenNv.ToUpper().Contains(name.ToUpper()));
            }
            return View(stf);
        }



    }
}
