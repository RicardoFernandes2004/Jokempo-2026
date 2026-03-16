namespace Jokempo.Lib;

public class Estatisticas
{
    public int Vitorias { get; private set; }
    public int Derrotas { get; private set; }
    public int Empates { get; private set; }
    public int Total => Vitorias + Derrotas + Empates;

    public void RegistrarResultado(ResultadoRodada resultado)
    {
        switch (resultado)
        {
            case ResultadoRodada.Vitoria:
                Vitorias++;
                break;
            case ResultadoRodada.Derrota:
                Derrotas++;
                break;
            case ResultadoRodada.Empate:
                Empates++;
                break;
        }
    }
}
