﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCrudApp.Models
{
    public class CrudDbContext : DbContext
    {
        public CrudDbContext(DbContextOptions <CrudDbContext> options ):base(options)
        {

        }

        public DbSet <Patient> Patients { get; set; }
    }
}
