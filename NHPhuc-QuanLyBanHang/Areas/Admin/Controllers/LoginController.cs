using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHPhuc_QuanLyBanHang.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // Trang login
        public ActionResult Index()
        {
            return View();
        }

        // Xử lý đăng nhập
        [HttpPost]
        public ActionResult Authenticate(string username, string password)
        {
            // Kiểm tra thông tin người dùng
            bool isValidUser = Models.NHPhucUsers.ValidateUser(username, password);

            if (isValidUser)
            {
                // Nếu đăng nhập thành công, điều hướng tới trang chính
                return RedirectToAction("Dashboard", "Home");
            }
            else
            {
                // Nếu đăng nhập thất bại, hiển thị thông báo lỗi
                ViewBag.ErrorMessage = "Invalid username or password.";
                return View("Index");
            }
        }
    }
}