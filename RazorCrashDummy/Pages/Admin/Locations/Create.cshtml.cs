using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorCrashDummy.DataAccess.Data;
using RazorCrashDummy.DataAccess.Repository.IRepository;
using RazorCrashDummy.Models;

namespace RazorCrashDummy.Pages.Admin.Locations
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public Location Location { get; set; }

        public CreateModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                _unitOfWork.Location.Add(Location);
                _unitOfWork.Save();
                TempData["success"] = "Shift created successfully";
                return RedirectToPage("Index");
            }

            return Page();
            
        }
    }
}
