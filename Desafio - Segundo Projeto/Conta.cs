class Titular
{
    public string Nome { get; set; }
    public int CPF { get; set; }
    public string Endereco { get; set; }
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

    

