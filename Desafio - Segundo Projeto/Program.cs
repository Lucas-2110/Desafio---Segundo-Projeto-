Titular titular1 = new Titular("Lucas Oliveira Souza", 41496129865, "Rua clementino cunha, 160");


Conta conta1 = new Conta(123456, 1234, "Lucas Oliveira Souza", 1000, 1230, 2321);

Jogos jogo1 = new Jogos("The Last of Us", "Ação e Aventura", 2013)
{
    Disponivel = true,
};

titular1.ExibirInformacoes();
conta1.InformacoesConta();
jogo1.InformacoesJogo();