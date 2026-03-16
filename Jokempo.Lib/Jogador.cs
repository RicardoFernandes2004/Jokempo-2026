namespace Jokempo.Lib;

public class Jogador
{
    public string Nome { get; }
    public Estatisticas Estatisticas { get; }

    public Jogador(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("O nome do jogador não pode ser vazio.", nameof(nome));

        Nome = nome.Trim();
        Estatisticas = new Estatisticas();
    }
}
