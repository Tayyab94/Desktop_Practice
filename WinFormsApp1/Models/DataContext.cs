using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class DataContext :DbContext
    {
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        
              optionsBuilder.UseSqlServer("Data Source=TAYYAB; initial Catalog=desktopDb; Integrated Security=true");
        }
        public DbSet<Student> Students { get; set; }
    }
}
