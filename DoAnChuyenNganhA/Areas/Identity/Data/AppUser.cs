using Microsoft.AspNetCore.Identity;

namespace DoAnChuyenNganhA.Areas.Identity.Data
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Address { get; set; }

    }
}
