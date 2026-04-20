class Titular
{
    public Titular(string nome, double cpf, string endereco)
    {
        Nome = nome;
        CPF = cpf;
        Endereco = endereco;
    }

    public string Nome { get; }
    public double CPF { get; }
    public string Endereco { get; }

    public void ExibirInformacoes()
    {
        Console.WriteLine("Informações do Titular:");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"CPF: {CPF}");
        Console.WriteLine($"Endereco: {Endereco}");
    }
}

class Conta
{
    public Conta(int idconta, int agencia, string nometitular, double saldo, double limite, int senha)
    {
        IdConta = idconta;
        Agencia = agencia;
        NomeTitular = nometitular;
        Saldo = saldo;
        Limite = limite;
        Senha = senha;
    }

    public int IdConta { get; }
    public int Agencia { get; }
    public string NomeTitular { get; }
    public double Saldo { get; }
    public double Limite { get; }
    public int Senha { get; }

    public void InformacoesConta()
    {
        Console.WriteLine("\nInformações da Conta:");
        Console.WriteLine($"Id da Conta: {IdConta}");
        Console.WriteLine($"Agência: {Agencia}");
        Console.WriteLine($"Saldo: {Saldo}");
        Console.WriteLine($"Limite: {Limite}");
        Console.WriteLine($"Senha: {Senha}");
    }
}



    

