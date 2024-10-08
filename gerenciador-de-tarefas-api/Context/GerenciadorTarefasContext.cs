using gerenciador_de_tarefas_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace gerenciador_de_tarefas_api.Context;

public class GerenciadorTarefasContext : DbContext
{
    public GerenciadorTarefasContext(DbContextOptions<GerenciadorTarefasContext> options) : base(options)
    {

    }

    public DbSet<Tarefa> tarefas { get; set; }
}
