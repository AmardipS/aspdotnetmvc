using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CRUD_Practice.Models
{
    // StudentContext class sets all the data from Student model class to the database
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}