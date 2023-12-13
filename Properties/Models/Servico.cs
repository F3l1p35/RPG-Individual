using ApiProjeto.Properties.Models.Enuns;
using Microsoft.EntityFrameworkCore;

namespace ApiProjeto.Properties.Models

{
    public class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Obra { get; set; } = string.Empty;
        public string Cliente { get; set; } = string.Empty;
        public int Preco { get; set; }
        public ClasseEscopo Classe { get; set; }

    }
}