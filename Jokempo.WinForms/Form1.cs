using Jokempo.Lib;

namespace Jokempo.WinForms;

public partial class Form1 : Form
{
    private readonly Jogo _jogo = new();

    public Form1()
    {
        InitializeComponent();
        txtNomeJogador.KeyDown += TxtNomeJogador_KeyDown;
    }

    private void TxtNomeJogador_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            BtnEntrar_Click(sender, e);
        }
    }

    private void BtnEntrar_Click(object? sender, EventArgs e)
    {
        var nome = txtNomeJogador.Text.Trim();

        if (string.IsNullOrWhiteSpace(nome))
        {
            MessageBox.Show("Por favor, digite um nome válido.", "Nome inválido",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _jogo.TrocarJogador(nome);
        pnlJogadas.Enabled = true;
        pnlResultado.Visible = false;
        AtualizarEstatisticas();

        txtNomeJogador.Enabled = false;
        btnEntrar.Text = "Trocar";
        btnEntrar.Click -= BtnEntrar_Click;
        btnEntrar.Click += BtnTrocar_Click;
    }

    private void BtnTrocar_Click(object? sender, EventArgs e)
    {
        txtNomeJogador.Enabled = true;
        txtNomeJogador.Text = "";
        txtNomeJogador.Focus();
        pnlJogadas.Enabled = false;
        pnlResultado.Visible = false;

        btnEntrar.Text = "Entrar";
        btnEntrar.Click -= BtnTrocar_Click;
        btnEntrar.Click += BtnEntrar_Click;
    }

    private void BtnJogada_Click(object? sender, EventArgs e)
    {
        if (sender is not Button btn || btn.Tag is not Jogada jogada)
            return;

        var rodada = _jogo.Jogar(jogada);
        ExibirResultado(rodada);
        AtualizarEstatisticas();
        AdicionarHistorico(rodada);
    }

    private void ExibirResultado(Rodada rodada)
    {
        var nomeJogador = _jogo.JogadorAtual!.Nome;

        lblJogadorEscolheu.Text = $"{nomeJogador} escolheu: {Rodada.ObterNomeJogada(rodada.JogadaJogador)}";
        lblComputadorEscolheu.Text = $"Computador escolheu: {Rodada.ObterNomeJogada(rodada.JogadaComputador)}";

        switch (rodada.Resultado)
        {
            case ResultadoRodada.Vitoria:
                lblResultado.Text = $"🎉 Parabéns, {nomeJogador}! Você venceu!";
                lblResultado.ForeColor = Color.FromArgb(34, 197, 94);
                break;
            case ResultadoRodada.Derrota:
                lblResultado.Text = $"😢 Não foi dessa vez, {nomeJogador}!";
                lblResultado.ForeColor = Color.FromArgb(239, 68, 68);
                break;
            case ResultadoRodada.Empate:
                lblResultado.Text = "🤝 Empate!";
                lblResultado.ForeColor = Color.FromArgb(168, 85, 247);
                break;
        }

        pnlResultado.Visible = true;
    }

    private void AtualizarEstatisticas()
    {
        if (_jogo.JogadorAtual == null) return;

        var stats = _jogo.JogadorAtual.Estatisticas;
        lblVitorias.Text = $"Vitórias: {stats.Vitorias}";
        lblDerrotas.Text = $"Derrotas: {stats.Derrotas}";
        lblEmpates.Text = $"Empates: {stats.Empates}";
        lblTotal.Text = $"Total: {stats.Total}";
    }

    private void AdicionarHistorico(Rodada rodada)
    {
        var simbolo = rodada.Resultado switch
        {
            ResultadoRodada.Vitoria => "✅",
            ResultadoRodada.Derrota => "❌",
            ResultadoRodada.Empate => "➖",
            _ => ""
        };

        var texto = $"{simbolo} {Rodada.ObterNomeJogada(rodada.JogadaJogador)} vs {Rodada.ObterNomeJogada(rodada.JogadaComputador)}";
        lstHistorico.Items.Insert(0, texto);
    }
}
