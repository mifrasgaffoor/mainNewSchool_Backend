﻿using Microsoft.EntityFrameworkCore;
using NewSchool.Model;

namespace NewSchool.Database
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options):base(options) 
        {


        }


        public DbSet<Students> Students { get; set; }

    }
}
