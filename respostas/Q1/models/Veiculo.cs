namespace Q1.Models;

class Veiculo
{
    private string _marca;
    private string _modelo;
    private int _ano;
    private int _velocidadeAtual;

    public string Marca
    {
        get {return _marca;}
        set {_marca = value.ToUpper();}
    }

    public string Modelo
    {
        get {return _modelo;}
        set {_modelo = value;}
    }

    public int Ano
    {
        get {return _ano;}
        set {if (value > 1900 && value <= 2026) _ano = value; else throw new ArgumentException("Ano inválido. Deve estar entre 1901 e 2026.");}
    }

    public int VelocidadeAtual
    {
        get {return _velocidadeAtual;}
    }

    public void Acelerar(int incremento)
    {
        _velocidadeAtual += incremento;
        if (_velocidadeAtual > 200)
        {
            ArgumentException aviso = new ArgumentException("A velocidade não pode exceder 200 km/h.");
            Console.WriteLine(aviso.Message);
            _velocidadeAtual = 200;
        }
    }

    public void Frear(int decremento)
    {
        _velocidadeAtual -= decremento;
        if (_velocidadeAtual < 0)
        {
            ArgumentException aviso = new ArgumentException("A velocidade não pode ser negativa.");
            Console.WriteLine(aviso.Message);
            _velocidadeAtual = 0;
        }
    }

    public void ObterFichaTecnica()
    {
        Console.WriteLine($"Marca: {Marca} | Modelo: {Modelo} | Ano: {Ano} | Velocidade Atual: {VelocidadeAtual} km/h");
    }

    public bool EstaEmMovimento()
    {
        bool emMovimento = VelocidadeAtual > 0;
        return emMovimento;
    }
}