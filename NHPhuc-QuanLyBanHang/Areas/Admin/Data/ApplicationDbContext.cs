using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NHPhuc_QuanLyBanHang.Areas.Admin.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=DefaultConnection")
        {
        }

        public DbSet<Models.Account> Accounts { get; set; }
    }
}