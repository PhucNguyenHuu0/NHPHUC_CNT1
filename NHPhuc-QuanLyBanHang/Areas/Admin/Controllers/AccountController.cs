using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using NHPhuc_QuanLyBanHang.Models;
using NHPhuc_QuanLyBanHang.Areas.Admin.Data;

namespace NHPhuc_QuanLyBanHang.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        private Data.ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin/Account
        public ActionResult Index()
        {
            return View(db.Accounts.ToList());
        }

        // GET: Admin/Account/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Username,Password,FullName,Email,Phone,IsAdmin,Status")] Account account)
        {
            if (ModelState.IsValid)
            {
                // Mã hóa mật khẩu trước khi lưu
                account.Password = HashPassword(account.Password);
                db.Accounts.Add(account);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(account);
        }

        private string HashPassword(string password)
        {
            throw new NotImplementedException();
        }
    }
}