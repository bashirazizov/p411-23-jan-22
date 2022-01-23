﻿using Datatofront.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Datatofront.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {}
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
