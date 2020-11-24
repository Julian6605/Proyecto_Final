using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp1.Model;
using WebApp1.Pages;
using static System.Net.Mime.MediaTypeNames;

namespace WebApp1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Subastas> Subastas {get;set;}
        public DbSet<Ofertar> Ofertar {get;set;}
        public DbSet<ImageModel> Images {get;set;}
        public object ImageModel { get; internal set; }
    }
}
