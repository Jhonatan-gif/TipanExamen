using System;
using Microsoft.EntityFrameworkCore;
using TipanProyecto.Models;

public class TipanProyectoBD : DbContext
{
    public TipanProyectoBD(DbContextOptions<TipanProyectoBD> options)
        : base(options)
    {
    }

    public DbSet<Cliente> Cliente { get; set; } = default!;
    public DbSet<PlanRecompensas> PlanRecompensas { get; set; } = default!;
    public DbSet<Reserva> Reserva { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configura precisión decimal para ValorPagar en Reserva
        modelBuilder.Entity<Reserva>()
            .Property(r => r.ValorPagar)
            .HasPrecision(18, 2);

        // Configura precisión decimal para IngresoMensual en Cliente
        modelBuilder.Entity<Cliente>()
            .Property(c => c.IngresoMensual)
            .HasPrecision(18, 2);

        base.OnModelCreating(modelBuilder);
    }
}
