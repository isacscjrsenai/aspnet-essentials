using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GerenciaTarefa.Models;

namespace GerenciaTarefa.Controllers;

public class TarefaController:Controller
{
    public IActionResult Index(){
        ViewData["Cabecalho"] = "Tarefa Diária";
        ViewData["Titulo"] = "Planejar Aula Senai";
        ViewData["Descricao"] = "Criar Nova PEUC";
        ViewData["Tarefa"] = Tarefa.listaDeTarefas;
        return View();
    }

    public void SalvaTarefa(string taskNome){
        Tarefa.GuardaTarefa(new Tarefa(taskNome));
    }
}