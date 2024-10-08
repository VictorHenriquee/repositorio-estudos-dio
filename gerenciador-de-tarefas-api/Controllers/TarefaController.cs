using gerenciador_de_tarefas_api.Context;
using gerenciador_de_tarefas_api.Entities;
using gerenciador_de_tarefas_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace gerenciador_de_tarefas_api.Controllers;

[ApiController]
[Route("[controller]")]
public class TarefaController : ControllerBase
{
    private readonly GerenciadorTarefasContext _context;

    public TarefaController(GerenciadorTarefasContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult Criar(Tarefa tarefa)
    {
        _context.tarefas.Add(tarefa);
        _context.SaveChanges();

        return CreatedAtAction(nameof(ObterPorId), new { id = tarefa.Id }, tarefa);
    }

    [HttpGet("ObterTodos")]
    public IActionResult ObterTodos()
    {
        var dadosExistente = _context.tarefas;

        if (!dadosExistente.Any())
        {
            return NotFound();
        }

        return Ok(dadosExistente);
    }

    [HttpGet("{id}")]
    public IActionResult ObterPorId(int id)
    {
        var dadoExistente = _context.tarefas.Find(id);

        if (dadoExistente == null)
        {
            return NotFound();
        }

        return Ok(dadoExistente);
    }

    [HttpGet("ObterPorTitulo")]
    public IActionResult ObterPorTitulo(string titulo)
    {
        var dadosExistente = _context.tarefas.Where(x => x.Titulo.Contains(titulo));

        if (!dadosExistente.Any())
        {
            return NotFound();
        }

        return Ok(dadosExistente);
    }

    [HttpGet("ObterPorData")]
    public IActionResult ObterPorData(string data)
    {
        var dadosExistente = _context.tarefas.Where(x => x.Data.Equals(data));

        if (!dadosExistente.Any())
        {
            return NotFound();
        }

        return Ok(dadosExistente);
    }

    [HttpGet("ObterPorStatus/{status}")]
    public IActionResult ObterPorStatus(Status status)
    {
        var dadosExistente = _context.tarefas.Where(x => x.Status == status);

        if (!dadosExistente.Any())
        {
            return NotFound();
        }

        return Ok(dadosExistente);
    }

    [HttpPut("{id}")]
    public IActionResult Atualizar(Tarefa tarefa, int id)
    {
        var dadoExistente = _context.tarefas.Find(id);

        if (dadoExistente == null)
        {
            return NotFound();
        }

        dadoExistente.Titulo = tarefa.Titulo;
        dadoExistente.Descricao = tarefa.Descricao;
        dadoExistente.Data = tarefa.Data;
        dadoExistente.Status = tarefa.Status;

        _context.tarefas.Update(dadoExistente);
        _context.SaveChanges();
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Deletar(int id)
    {
        var dadoExistente = _context.tarefas.Find(id);

        if (dadoExistente == null)
        {
            return NotFound();
        }

        _context.tarefas.Remove(dadoExistente);
        _context.SaveChanges();
        return NoContent();
    }
}
