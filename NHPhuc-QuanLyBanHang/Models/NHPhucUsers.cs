using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHPhuc_QuanLyBanHang.Models
{
    public class NHPhucUsers
    {
        public string Username { get; set; }
        public string Password { get; set; }

        // Giả sử danh sách tài khoản để kiểm tra đăng nhập
        public static bool ValidateUser(string username, string password)
        {
            // Ở đây, bạn có thể thay thế bằng logic kiểm tra từ cơ sở dữ liệu
            if (username == "admin" && password == "password123")
            {
                return true;
            }
            return false;
        }
    }
}

