namespace Q2.Models;

class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int DuracaoSegundos { get; set; }

    public Musica(string titulo, string artista, int duracaoSegundos)
    {
        Titulo = titulo;
        Artista = artista;
        DuracaoSegundos = duracaoSegundos;
    }

    public string ObterDuracaoMinutos()
    {
        int minutos = DuracaoSegundos / 60;
        int segundosRestantes = DuracaoSegundos % 60;
        return $"{minutos}m {segundosRestantes}s";
    }

}