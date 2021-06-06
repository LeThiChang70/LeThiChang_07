using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LeThiChang_07.Models
{
    public partial class LTQLDbcontext : DbContext
    {
        public LTQLDbcontext()
            : base("name=LTQLDbcontext")
        {
        }
        public virtual DbSet<PhongBan> PhongBans { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
