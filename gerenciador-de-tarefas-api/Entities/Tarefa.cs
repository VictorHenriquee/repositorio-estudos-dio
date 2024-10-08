using gerenciador_de_tarefas_api.Models;

namespace gerenciador_de_tarefas_api.Entities;

public class Tarefa
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public DateTime Data { get; set; }
    public Status Status { get; set; }
}
