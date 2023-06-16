using Microsoft.EntityFrameworkCore;
using StudRec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudRec.Data
{
    public class StudRecContext : DbContext
    {
        public StudRecContext(DbContextOptions<StudRecContext> options) : base(options) 
        { 
        }
        public virtual DbSet<Studinfo> StudInfos { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual  DbSet<Major> Majors { get; set; }
    }
}
