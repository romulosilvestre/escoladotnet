using EscolaDotNet.Models;
namespace EscolaDotNet.ViewModels;

//criei a classe
public class DetalhesCursoViewModel{
   //.NET 5
   //criar uma referência
   public Curso Curso { get; set; } = null!;
   public string TituloPagina { get; set; } = string.Empty;
}

