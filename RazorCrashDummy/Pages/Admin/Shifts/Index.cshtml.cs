using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCrashDummy.DataAccess.Repository.IRepository;
using RazorCrashDummy.Models;

namespace RazorCrashDummy.Pages.Admin.Shifts
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IEnumerable<Shift> ShiftList { get; set; }
        public static IEnumerable<User> UserList { get; set; }
        public static IEnumerable<Location> LocationList { get; set; }

        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void OnGet()
        {
            ShiftList = _unitOfWork.Shift.GetAll();
            UserList = _unitOfWork.User.GetAll();
            LocationList = _unitOfWork.Location.GetAll();
        }

        public static string FindUser(int id)
        {
            var user = UserList.FirstOrDefault(u => u.Id == id);
            return user.Name;
        }
        public static string FindLocation(int id)
        {
            var location = LocationList.FirstOrDefault(u => u.Id == id);
            return location.Name;
        }
    }
}
