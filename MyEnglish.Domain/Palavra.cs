namespace MyEnglish.Domain;

public class Palavra
{
    public Guid Id { get; set; }
    public string Conteudo { get; set; } = "";
    public string Traducao { get; set; } = "";
}