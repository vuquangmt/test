using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace test.Models
{
    public partial class TestDbContext : DbContext
    {
        public TestDbContext()
            : base("name=TestDbContext")
        {
        }
        public virtual DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
