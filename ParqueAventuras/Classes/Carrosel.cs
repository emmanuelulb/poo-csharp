namespace ParqueAventuras.Classes;

public class Carrosel : Atracao
{
    public string Tema {get; set;}

    public override void ExibirDados()
    {
        Console.WriteLine($"O nome da atração é: {Nome}| Altura minima: {AlturaMinima} cm| Tema: {Tema}");
    }
}