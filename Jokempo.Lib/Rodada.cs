namespace Jokempo.Lib;

public class Rodada
{
    private static readonly Random _random = new();

    public Jogada JogadaJogador { get; }
    public Jogada JogadaComputador { get; }
    public ResultadoRodada Resultado { get; }

    public Rodada(Jogada jogadaJogador)
    {
        JogadaJogador = jogadaJogador;
        JogadaComputador = GerarJogadaComputador();
        Resultado = DeterminarResultado(JogadaJogador, JogadaComputador);
    }

    public static Jogada GerarJogadaComputador()
    {
        return (Jogada)_random.Next(3);
    }

    public static ResultadoRodada DeterminarResultado(Jogada jogador, Jogada computador)
    {
        if (jogador == computador)
            return ResultadoRodada.Empate;

        return jogador switch
        {
            Jogada.Pedra => computador == Jogada.Tesoura ? ResultadoRodada.Vitoria : ResultadoRodada.Derrota,
            Jogada.Papel => computador == Jogada.Pedra ? ResultadoRodada.Vitoria : ResultadoRodada.Derrota,
            Jogada.Tesoura => computador == Jogada.Papel ? ResultadoRodada.Vitoria : ResultadoRodada.Derrota,
            _ => ResultadoRodada.Empate
        };
    }

    public static string ObterNomeJogada(Jogada jogada)
    {
        return jogada switch
        {
            Jogada.Pedra => "Pedra ✊",
            Jogada.Papel => "Papel ✋",
            Jogada.Tesoura => "Tesoura ✌️",
            _ => "Desconhecida"
        };
    }

    public static string ObterNomeResultado(ResultadoRodada resultado)
    {
        return resultado switch
        {
            ResultadoRodada.Vitoria => "Vitória",
            ResultadoRodada.Derrota => "Derrota",
            ResultadoRodada.Empate => "Empate",
            _ => "Desconhecido"
        };
    }
}
