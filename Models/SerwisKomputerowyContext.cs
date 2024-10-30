using System;
using Microsoft.EntityFrameworkCore;

namespace Serwis.Models;

public class SerwisKomputerowyContext : DbContext
    {
        public SerwisKomputerowyContext(DbContextOptions<SerwisKomputerowyContext> options)
            : base(options)
        {
        }

        public DbSet<Serwiss> Serwisy { get; set; }
        public DbSet<Klient> Klienci { get; set; }
        public DbSet<Sprzet> Sprzety { get; set; }
        public DbSet<Naprawa> Naprawy { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }