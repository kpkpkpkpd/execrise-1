﻿using ConsoleApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Activity> Activities { get; set; }
        public DbSet<StationExit> StationExits { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
