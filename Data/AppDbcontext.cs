using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using System.Collections.Generic;
using Digital_Marketing_Agency.Models;
using Microsoft.EntityFrameworkCore;


namespace Digital_Marketing_Agency.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {

        }

        public DbSet<Form> Form { get; set; }
    }
}

