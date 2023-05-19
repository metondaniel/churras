using ChurrasDomain.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChurrasRepository
{
    public partial class ChurrasDBContext : DbContext
    {
        public ChurrasDBContext(DbContextOptions<ChurrasDBContext> options) : base(options)
        {
        }
        public DbSet<Churrasco> Churras { get; set; }
        public DbSet<Participante> Participante { get; set; }
        public DbSet<ChurrasParticipante> ChurrasParticipante { get; set; }
        public DbSet<User> User { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Churrasco>().HasKey(c => c.Id);
            modelBuilder.Entity<Participante>().HasKey(c => c.Id);
            modelBuilder.Entity<User>().HasKey(c => c.Id);
            modelBuilder.Entity<ChurrasParticipante>().HasKey(c => c.Id);
            modelBuilder.Entity<ChurrasParticipante>().HasOne(x => x.Churras).WithMany(y => y.ChurrasParticipante);
            modelBuilder.Entity<ChurrasParticipante>().HasOne(x => x.Participante).WithMany(y => y.ChurrasParticipante);
            modelBuilder.Entity<User>().HasKey(c => c.Id);
        }
    }
}
