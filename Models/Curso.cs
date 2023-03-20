
namespace escoladotnet.Models;
//Classe : Curso
public class Curso{
    //Dados do Senai InovaTech + Green
    //Classes God (não é boa prática)

    //10 propriedades
    public int Id { get; set; }
    public string? Nome { get; set; } //nullable
    public string? Titulo{get;set;}
    public string? Descricao { get; set; }
    public string? Perfil { get; set; }
    public string? PreRequisitos { get; set; }
    public string? Conteudo{get;set;}
    public string? Recursos { get; set; }
    public int CargaHoraria{ get; set; }
    public int PrazoMeses { get; set; }
}