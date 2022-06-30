using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorCrashDummy.DataAccess.Data;
using RazorCrashDummy.DataAccess.Repository.IRepository;
using RazorCrashDummy.Models;

namespace RazorCrashDummy.Pages.Admin.Shifts;

[BindProperties]
public class UpsertModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;
    public Shift Shift { get; set; }
    public IEnumerable<SelectListItem> UserList { get; set; }
    public IEnumerable<SelectListItem> LocationList { get; set; }


    public UpsertModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        Shift = new();
    }

    public void OnGet()
    {
        UserList = _unitOfWork.User.GetAll().Select(i => new SelectListItem()
        {
            Text = i.Name,
            Value = i.Id.ToString()
        });
        LocationList = _unitOfWork.Location.GetAll().Select(i => new SelectListItem()
        {
            Text = i.Name,
            Value = i.Id.ToString()
        });
    }

    public async Task<IActionResult> OnPost()
    {
        _unitOfWork.Shift.Add(Shift);
        _unitOfWork.Save();
        TempData["success"] = "Shift created successfully";
        return RedirectToPage("Index");
    }
}
