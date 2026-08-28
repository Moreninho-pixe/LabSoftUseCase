namespace GestaoTarefas;

public class Tarefa
{
    public string Nome { get; set; } = string.Empty; 
    public string NomeFuncionario { get; get; } = string.Empty;
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }

    public Tarefa(string nome, DateTime dataInicio, DateTime dataFim, string nomeFuncionario)
    {
        Nome = nome;
        DataInicio = dataInicio;
        DataFim = dataFim;
        NomeFuncionario = nomeFuncionario;
    }

    public int ObterQuantidadeDias()
    {
        return (DataFim - DataInicio).Days;
    }
}