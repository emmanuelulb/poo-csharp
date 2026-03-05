namespace ParqueAventuras.Classes;

public abstract class Atracao
{
    public string Nome {get; set;}
    public int AlturaMinima {get; set;}

    public abstract void ExibirDados();
}