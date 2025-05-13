using System.Text;
using DaiLyTuanTu.Models;

namespace DaiLyTuanTu
{
    public class DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
    }
}