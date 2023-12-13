using Microsoft.EntityFrameworkCore;
using ApiProjeto.Properties.Models.Enuns;
using Microsoft.AspNetCore.Mvc;
using ApiProjeto.Properties.Models;
using System.Collections.Generic;


namespace RpgApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Servico> TB_SERVICOS { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Servico>().HasData
        (
            new Servico() { Id = 1, Nome = "Projeto de Piso", Obra = "Decathlon", Cliente = "Helbor", Preco = 5000, Classe=Properties.Models.Enuns.ClasseEscopo.Piso},
            new Servico() { Id = 2, Nome = "Projeto de Drenagem", Obra = "Green Park", Cliente = "NF Contrutora", Preco = 7000, Classe=Properties.Models.Enuns.ClasseEscopo.Drenagem},
            new Servico() { Id = 3, Nome = "Consultoria", Obra = "Hadock Lobo", Cliente = "Mitre Realty", Preco = 10000, Classe=Properties.Models.Enuns.ClasseEscopo.Consultoria},
            new Servico() { Id = 1, Nome = "Projeto de Piso", Obra = "Oscar Freire", Cliente = "RFM", Preco = 15000, Classe=Properties.Models.Enuns.ClasseEscopo.Piso},
            new Servico() { Id = 2, Nome = "Projeto de Drenagem", Obra = "Bunge", Cliente = "Costa Feitosa", Preco = 27000, Classe=Properties.Models.Enuns.ClasseEscopo.Drenagem},
            new Servico() { Id = 3, Nome = "Projeto de Drenagem", Obra = "Takeda", Cliente = "MPD", Preco = 3000, Classe=Properties.Models.Enuns.ClasseEscopo.Consultoria}

        );
        }
    }
}