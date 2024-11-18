using Timely.Models;

public class Tarefa
{
    public int TarefaId { get; set; }
    public int UsuarioId { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public DateTime DataVencimento { get; set; }
    public bool Concluida { get; set; }
    public User Usuario { get; set; }
}
