using ConsoleApp5.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Contexts
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-47DGCU6\\SQL;Initial Catalog=MyLibrary;User ID=MySql;Password=pervina9266_1;Connect Timeout=30;");

            base.OnConfiguring(optionsBuilder);
        }


        public DbSet<Curator>? Curators{ get; set; }
        public DbSet<Deparment>? Deparments{ get; set; }
        public DbSet<Faculity>? Faculities{ get; set; }
        public DbSet<Group>? Groups{ get; set; }
        public DbSet<GroupAndCurator>? GroupAndCurators{ get; set; }
        public DbSet<GroupAndLecture>? GroupAndLectures{ get; set; }
        public DbSet<GroupAndStudent>? GroupAndStudents{ get; set; }
        public DbSet<Lecture>? Lectures{ get; set; }
        public DbSet<Student>? Students{ get; set; }
        public DbSet<Subject>? Subjects{ get; set; }
        public DbSet<Teacher>? Teachers{ get; set; }
    }
}
