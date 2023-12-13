using Microsoft.AspNetCore.Mvc;
using ApiProjeto.Properties.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace ApiProjeto.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ServicoExemploController : ControllerBase
    {

        private static List<Servico> servicos = new List<Servico>()
        {
            new Servico() { Id = 1, Nome = "Projeto de Piso", Obra = "Decathlon", Cliente = "Helbor", Preco = 5000, Classe=Properties.Models.Enuns.ClasseEscopo.Piso},
            new Servico() { Id = 2, Nome = "Projeto de Drenagem", Obra = "Green Park", Cliente = "NF Contrutora", Preco = 7000, Classe=Properties.Models.Enuns.ClasseEscopo.Drenagem},
            new Servico() { Id = 3, Nome = "Consultoria", Obra = "Hadock Lobo", Cliente = "Mitre Realty", Preco = 10000, Classe=Properties.Models.Enuns.ClasseEscopo.Consultoria},
            new Servico() { Id = 1, Nome = "Projeto de Piso", Obra = "Oscar Freire", Cliente = "RFM", Preco = 15000, Classe=Properties.Models.Enuns.ClasseEscopo.Piso},
            new Servico() { Id = 2, Nome = "Projeto de Drenagem", Obra = "Bunge", Cliente = "Costa Feitosa", Preco = 27000, Classe=Properties.Models.Enuns.ClasseEscopo.Drenagem},
            new Servico() { Id = 3, Nome = "Projeto de Drenagem", Obra = "Takeda", Cliente = "MPD", Preco = 3000, Classe=Properties.Models.Enuns.ClasseEscopo.Consultoria}

        };

        [HttpGet("Get")]
        public IActionResult GetFirst()
        {
            Servico s = servicos[0];
            return Ok(s);
        }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(servicos);
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(servicos.FirstOrDefault(se => se.Id == id));
        }

        [HttpPost]
        public IActionResult AddPersonagem(Servico novoServico)
        {
            servicos.Add(novoServico);
            return Ok(servicos);
        }

        [HttpPut]
        public IActionResult UpdateServico(Servico s)
        {
            Servico servicoAlterado = servicos.Find(serv => serv.Id == s.Id);
            servicoAlterado.Nome = s.Nome;
            servicoAlterado.Obra = s.Obra;
            servicoAlterado.Cliente = s.Cliente;
            servicoAlterado.Preco = s.Preco;

            return Ok(servicos);

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            servicos.RemoveAll(serv => serv.Id == id);

            return Ok(servicos);
        }

        



    }
    
        
        
    
}