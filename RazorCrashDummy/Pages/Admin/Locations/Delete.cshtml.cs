using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCrashDummy.DataAccess.Data;
using RazorCrashDummy.DataAccess.Repository.IRepository;
using RazorCrashDummy.Models;

namespace RazorCrashDummy.Pages.Admin.Locations
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public Location Location { get; set; }

        public DeleteModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void OnGet(int id)
        {
            Location = _unitOfWork.Location.GetFirstOrDefault(u=>u.Id==id);
        }

        public async Task<IActionResult> OnPost()
        {
            var shiftFromDb = _unitOfWork.Location.GetFirstOrDefault(u=>u.Id==Location.Id);
            if (shiftFromDb!= null)
            {
                _unitOfWork.Location.Remove(shiftFromDb);
                _unitOfWork.Save();
                TempData["success"] = "Shift deleted successfully";
                return RedirectToPage("Index");
            }
            return Page();

        }
    }
}
