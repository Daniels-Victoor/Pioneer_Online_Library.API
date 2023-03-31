using Microsoft.AspNetCore.Mvc;
using Pioneer_Online_Library.Core.Interface;
using Pioneer_Online_Library.Core.Services;
using Pioneer_Online_Library.Domain.Model;
using Pioneer_Online_Library.MVC.Interface;

namespace Pioneer_Online_Library.MVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService ?? throw new ArgumentNullException(nameof(_adminService));
        }

        public async Task<ActionResult> CreateBook(Book book)
        {
            try
            {
                var books = await _adminService.CreateBook(book);
                return View(book);

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }

        }

        public IActionResult CreateBook()
        {
            return View();
        }



        public async Task<ActionResult> UpdateBook(Book book)
        {
            try
            {
                var books = await _adminService.UpdateBook(book);
                return View(book);

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }

        }

        public IActionResult UpdateBook()
        {
            return View();
        }


        public async Task<ActionResult> DeleteBook(Book book)
        {
            try
            {
                var books = await _adminService.DeleteBook(book);
                return View(book);

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }

        }

        public IActionResult DeleteBook()
        {
            return View();
        }

    }
}
