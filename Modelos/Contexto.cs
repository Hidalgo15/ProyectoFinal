using Microsoft.EntityFrameworkCore;

public class ContextoDige : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public  DbSet<Multa> Multas { get; set; }
    public DbSet <Conceptos> Concepto { get; set; }
    public ContextoDige(DbContextOptions<ContextoDige> options) : base(options) { }
}