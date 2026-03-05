namespace ParqueAventuras.Classes;

public class MontanhaRussa : Atracao
{
    public decimal VelocidadeMaxima {get; set;}

    public override void ExibirDados()
    {
       Console.WriteLine($"O nome da atração é: {Nome}| Altura minima: {AlturaMinima} cm| Velocidade Máxima: {VelocidadeMaxima} km/h");
    }
}