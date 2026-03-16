namespace Jokempo.Lib;

public class Jogo
{
    private readonly List<Jogador> _jogadores = new();

    public Jogador? JogadorAtual { get; private set; }
    public IReadOnlyList<Jogador> Jogadores => _jogadores.AsReadOnly();

    public Jogador TrocarJogador(string nome)
    {
        var jogadorExistente = _jogadores.FirstOrDefault(j =>
            j.Nome.Equals(nome.Trim(), StringComparison.OrdinalIgnoreCase));

        if (jogadorExistente != null)
        {
            JogadorAtual = jogadorExistente;
            return jogadorExistente;
        }

        var novoJogador = new Jogador(nome);
        _jogadores.Add(novoJogador);
        JogadorAtual = novoJogador;
        return novoJogador;
    }

    public Rodada Jogar(Jogada jogada)
    {
        if (JogadorAtual == null)
            throw new InvalidOperationException("Nenhum jogador selecionado. Use TrocarJogador primeiro.");

        var rodada = new Rodada(jogada);
        JogadorAtual.Estatisticas.RegistrarResultado(rodada.Resultado);
        return rodada;
    }
}
