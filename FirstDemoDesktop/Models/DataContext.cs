﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoDesktop.Models
{
    public class DataContext :DbContext
    {
        public DataContext():base("name:con")
        {
            
        }

        public DbSet<Student> Students { get; set; }    
    }
}
