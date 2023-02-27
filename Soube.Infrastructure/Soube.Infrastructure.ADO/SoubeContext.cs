using Microsoft.EntityFrameworkCore;
using Soube.Infrastructure.ADO.Data;

namespace Soube.Infrastructure.ADO;

public partial class SoubeContext : DbContext
{
    public SoubeContext(DbContextOptions<SoubeContext> options) : base(options)
    {
    }

    public virtual DbSet<Aluno> Aluno { get; set; }

    public virtual DbSet<Autenticar> Autenticar { get; set; }

    public virtual DbSet<Endereco> Endereco { get; set; }

    public virtual DbSet<Materia> Materia { get; set; }

    public virtual DbSet<Pessoa> Pessoa { get; set; }

    public virtual DbSet<PessoaFisica> PessoaFisica { get; set; }

    public virtual DbSet<PessoaJuridica> PessoaJuridica { get; set; }

    public virtual DbSet<Questao> Questao { get; set; }

    public virtual DbSet<Simulado> Simulado { get; set; }

    public virtual DbSet<SimuladoQuestao> SimuladoQuestao { get; set; }

    public virtual DbSet<Situacao> Situacao { get; set; }

    public virtual DbSet<WeatherForecast> WeatherForecast { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aluno__3214EC07D44AA67A");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.PessoaFisica).WithMany(p => p.Aluno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Aluno__PessoaFis__1AD3FDA4");
        });

        modelBuilder.Entity<Autenticar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Autentic__3214EC07A1816FAA");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Endereco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Endereco__3214EC07BFAAE0ED");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Pais).HasDefaultValueSql("('Brasil')");
            entity.Property(e => e.UF).IsFixedLength();
            entity.Property(e => e.ZonaUrbana).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<Materia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Materia__3214EC07308B0759");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Situacao).WithMany(p => p.Materia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Materia__Situaca__02FC7413");
        });

        modelBuilder.Entity<Pessoa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC073F863CDF");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Autenticar).WithMany(p => p.Pessoa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pessoa__Autentic__160F4887");

            entity.HasOne(d => d.Endereco).WithMany(p => p.Pessoa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pessoa__Endereco__7D439ABD");

            entity.HasOne(d => d.Situacao).WithMany(p => p.Pessoa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pessoa__Situacao__7E37BEF6");
        });

        modelBuilder.Entity<PessoaFisica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC0770DFC09B");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CPF).IsFixedLength();
            entity.Property(e => e.EstadoCivil).HasDefaultValueSql("('Solteiro')");
            entity.Property(e => e.Nacionalidade).HasDefaultValueSql("('Brasileira')");
            entity.Property(e => e.Passaporte).IsFixedLength();
            entity.Property(e => e.Sexo).IsFixedLength();

            entity.HasOne(d => d.Pessoa).WithMany(p => p.PessoaFisica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PessoaFis__Pesso__1BC821DD");
        });

        modelBuilder.Entity<PessoaJuridica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PessoaJu__3214EC07C714BD86");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Matriz).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Pessoa).WithMany(p => p.PessoaJuridica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PessoaJur__Pesso__01142BA1");
        });

        modelBuilder.Entity<Questao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07D88EBC00");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Banca).WithMany(p => p.Questao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Questao__BancaId__03F0984C");

            entity.HasOne(d => d.Materia).WithMany(p => p.Questao).HasConstraintName("FK__Questao__Materia__5EBF139D");

            entity.HasOne(d => d.Simulado).WithMany(p => p.Questao).HasConstraintName("FK__Questao__Simulad__5DCAEF64");

            entity.HasOne(d => d.Situacao).WithMany(p => p.Questao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Questao__Situaca__04E4BC85");
        });

        modelBuilder.Entity<Simulado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Simulado__3214EC07D690ACE9");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SimuladoQuestao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Simulado__3214EC07EF4ADB30");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Aluno).WithMany(p => p.SimuladoQuestao).HasConstraintName("FK__SimuladoQ__Aluno__6E01572D");

            entity.HasOne(d => d.Questao).WithMany(p => p.SimuladoQuestao).HasConstraintName("FK__SimuladoQ__Quest__5FB337D6");

            entity.HasOne(d => d.Simulado).WithMany(p => p.SimuladoQuestao).HasConstraintName("FK__SimuladoQ__Simul__59063A47");
        });

        modelBuilder.Entity<Situacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Situacao__3214EC07908B4B30");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Ativo).HasDefaultValueSql("((1))");
            entity.Property(e => e.Criado).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Administrador).WithMany(p => p.Situacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Situacao__Admini__1CBC4616");
        });

        modelBuilder.Entity<WeatherForecast>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WeatherF__3214EC071949EF2E");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}