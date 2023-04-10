namespace GerenciaTarefa.Models;
 public class Tarefa {
   
   static public List<Tarefa> listaDeTarefas = new List<Tarefa>{};
    public int Id { get; set; }

    public string? Cabecalho { get; set; }

    public string? Titulo { get; set; }
    public string? Descricao { get; set; }
    public bool TaCompleta { get; set; }

   public string? taskName;

   public Tarefa(string nome){
      this.taskName = nome;
   }
    static public void GuardaTarefa(Tarefa tarefa)
    {
      Tarefa.listaDeTarefas.Add(tarefa);
    }
 }