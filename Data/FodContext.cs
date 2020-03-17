using Microsoft.EntityFrameworkCore;
using FodApi.Model;
namespace FodApi.Data
{
    public class FodContext : DbContext {
    public FodContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder) {
        builder.Entity<Candidat>().Property(p => p.id).HasMaxLength(40);
        builder.Entity<Competence>().Property(p => p.id).HasMaxLength(40);
        builder.Entity<Candidature>().Property(p => p.id).HasMaxLength(40);
        builder.Entity<Role>().Property(p => p.id).HasMaxLength(40);
        builder.Entity<Utilisateur>().Property(p => p.id).HasMaxLength(40);

        builder.Entity<Candidat>().ToTable("Candidat");
        builder.Entity<Competence>().ToTable("Competence");
        builder.Entity<Candidature>().ToTable("Candidature");
        builder.Entity<Role>().ToTable("Role");
        builder.Entity<Utilisateur>().ToTable("Utilisateur");
       


    }

    public DbSet<Candidat> Candidats { get; set; }
    public DbSet<Competence> Competences { get; set; }
    public DbSet<Candidature> Candidatures { get; set; }

    public DbSet<Role> Roles { get; set; }
    public DbSet<Utilisateur> Utilisateurs { get; set; }
 
}

}