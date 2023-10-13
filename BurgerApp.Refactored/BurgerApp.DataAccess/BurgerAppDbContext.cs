using BurgerApp.Domain.Models;
using BurgerApp.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.DataAccess
{
    public class BurgerAppDbContext : DbContext
    {
        public BurgerAppDbContext(DbContextOptions options) : base(options) 
        {
            //Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BurgerAppDbContext).Assembly);
        }
        public DbSet<BestCombo> BestCombos => Set<BestCombo>();
        public DbSet<Burger> Burgers => Set<Burger>();     
        public DbSet<Fries> Fries => Set<Fries>();
        public DbSet<Drink> Drinks => Set<Drink>();
    }
}
