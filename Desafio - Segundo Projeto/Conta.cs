class Titular
{
    public string Nome { get; set; }
    public double CPF { get; set; }
    public string Endereco { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine("Informações do Titular:");
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"CPF: {CPF}");
        Console.WriteLine($"Endereco: {Endereco}");
    }
}

class Conta
{
    public int IdConta { get; set; }
    public int Agencia { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }
    public int Senha { get; set; }

    public string Informacoes => $"Conta nº {IdConta}, Agência {Agencia}, Titular: {Titular} - Saldo: {Saldo}";

}



    

