class Jogos
{
    public Jogos(string nome, string genero, int lancamento)
    {
        Nome = nome;
        Genero = genero;
        Lancamento = lancamento;
    }

    public string Nome { get; }
    public string Genero { get; }
    public int Lancamento { get; }
    public bool Disponivel { get; set; }


    public void InformacoesJogo()
    {
        Console.WriteLine($"\nInformações do jogo {Nome}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Lançamento: {Lancamento}");
        if (Disponivel)
        {
            Console.WriteLine($"O jogo {Nome} está disponível para compra!");
        }
        else
        {
            Console.WriteLine($"O jogo {Nome} não está disponível nesse momento");
        }
        Console.WriteLine($"Disponível: {Disponivel}");
    }
}
