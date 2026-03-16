namespace Jokempo.WinForms;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        pnlJogador = new Panel();
        lblJogador = new Label();
        txtNomeJogador = new TextBox();
        btnEntrar = new Button();

        pnlJogadas = new Panel();
        lblEscolha = new Label();
        btnPedra = new Button();
        btnPapel = new Button();
        btnTesoura = new Button();

        pnlResultado = new Panel();
        lblJogadorEscolheu = new Label();
        lblComputadorEscolheu = new Label();
        lblResultado = new Label();

        pnlEstatisticas = new Panel();
        lblEstatisticasTitulo = new Label();
        lblVitorias = new Label();
        lblDerrotas = new Label();
        lblEmpates = new Label();
        lblTotal = new Label();

        lblHistoricoTitulo = new Label();
        lstHistorico = new ListBox();

        SuspendLayout();

        // --- Painel Jogador ---
        pnlJogador.Location = new Point(20, 15);
        pnlJogador.Size = new Size(540, 50);

        lblJogador.Text = "Jogador:";
        lblJogador.Location = new Point(0, 8);
        lblJogador.AutoSize = true;
        lblJogador.Font = new Font("Segoe UI", 11F, FontStyle.Bold);

        txtNomeJogador.Location = new Point(85, 5);
        txtNomeJogador.Size = new Size(300, 30);
        txtNomeJogador.Font = new Font("Segoe UI", 11F);
        txtNomeJogador.PlaceholderText = "Digite seu nome...";

        btnEntrar.Text = "Entrar";
        btnEntrar.Location = new Point(400, 3);
        btnEntrar.Size = new Size(130, 35);
        btnEntrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnEntrar.BackColor = Color.FromArgb(59, 130, 246);
        btnEntrar.ForeColor = Color.White;
        btnEntrar.FlatStyle = FlatStyle.Flat;
        btnEntrar.FlatAppearance.BorderSize = 0;
        btnEntrar.Cursor = Cursors.Hand;
        btnEntrar.Click += BtnEntrar_Click;

        pnlJogador.Controls.Add(lblJogador);
        pnlJogador.Controls.Add(txtNomeJogador);
        pnlJogador.Controls.Add(btnEntrar);

        // --- Painel Jogadas ---
        pnlJogadas.Location = new Point(20, 80);
        pnlJogadas.Size = new Size(540, 140);
        pnlJogadas.Enabled = false;

        lblEscolha.Text = "Escolha sua jogada:";
        lblEscolha.Location = new Point(0, 0);
        lblEscolha.AutoSize = true;
        lblEscolha.Font = new Font("Segoe UI", 11F, FontStyle.Bold);

        btnPedra.Text = "✊\nPedra";
        btnPedra.Location = new Point(0, 35);
        btnPedra.Size = new Size(165, 90);
        btnPedra.Font = new Font("Segoe UI", 14F);
        btnPedra.BackColor = Color.FromArgb(239, 68, 68);
        btnPedra.ForeColor = Color.White;
        btnPedra.FlatStyle = FlatStyle.Flat;
        btnPedra.FlatAppearance.BorderSize = 0;
        btnPedra.Cursor = Cursors.Hand;
        btnPedra.Tag = Lib.Jogada.Pedra;
        btnPedra.Click += BtnJogada_Click;

        btnPapel.Text = "✋\nPapel";
        btnPapel.Location = new Point(180, 35);
        btnPapel.Size = new Size(165, 90);
        btnPapel.Font = new Font("Segoe UI", 14F);
        btnPapel.BackColor = Color.FromArgb(34, 197, 94);
        btnPapel.ForeColor = Color.White;
        btnPapel.FlatStyle = FlatStyle.Flat;
        btnPapel.FlatAppearance.BorderSize = 0;
        btnPapel.Cursor = Cursors.Hand;
        btnPapel.Tag = Lib.Jogada.Papel;
        btnPapel.Click += BtnJogada_Click;

        btnTesoura.Text = "✌️\nTesoura";
        btnTesoura.Location = new Point(360, 35);
        btnTesoura.Size = new Size(165, 90);
        btnTesoura.Font = new Font("Segoe UI", 14F);
        btnTesoura.BackColor = Color.FromArgb(168, 85, 247);
        btnTesoura.ForeColor = Color.White;
        btnTesoura.FlatStyle = FlatStyle.Flat;
        btnTesoura.FlatAppearance.BorderSize = 0;
        btnTesoura.Cursor = Cursors.Hand;
        btnTesoura.Tag = Lib.Jogada.Tesoura;
        btnTesoura.Click += BtnJogada_Click;

        pnlJogadas.Controls.Add(lblEscolha);
        pnlJogadas.Controls.Add(btnPedra);
        pnlJogadas.Controls.Add(btnPapel);
        pnlJogadas.Controls.Add(btnTesoura);

        // --- Painel Resultado ---
        pnlResultado.Location = new Point(20, 235);
        pnlResultado.Size = new Size(540, 110);
        pnlResultado.BackColor = Color.FromArgb(241, 245, 249);
        pnlResultado.Padding = new Padding(15);
        pnlResultado.Visible = false;

        lblJogadorEscolheu.Text = "";
        lblJogadorEscolheu.Location = new Point(15, 10);
        lblJogadorEscolheu.AutoSize = true;
        lblJogadorEscolheu.Font = new Font("Segoe UI", 11F);

        lblComputadorEscolheu.Text = "";
        lblComputadorEscolheu.Location = new Point(15, 35);
        lblComputadorEscolheu.AutoSize = true;
        lblComputadorEscolheu.Font = new Font("Segoe UI", 11F);

        lblResultado.Text = "";
        lblResultado.Location = new Point(15, 68);
        lblResultado.AutoSize = true;
        lblResultado.Font = new Font("Segoe UI", 14F, FontStyle.Bold);

        pnlResultado.Controls.Add(lblJogadorEscolheu);
        pnlResultado.Controls.Add(lblComputadorEscolheu);
        pnlResultado.Controls.Add(lblResultado);

        // --- Painel Estatísticas (lado direito) ---
        pnlEstatisticas.Location = new Point(580, 15);
        pnlEstatisticas.Size = new Size(200, 170);
        pnlEstatisticas.BackColor = Color.FromArgb(241, 245, 249);
        pnlEstatisticas.Padding = new Padding(12);

        lblEstatisticasTitulo.Text = "Estatísticas";
        lblEstatisticasTitulo.Location = new Point(12, 8);
        lblEstatisticasTitulo.AutoSize = true;
        lblEstatisticasTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

        lblVitorias.Text = "Vitórias: 0";
        lblVitorias.Location = new Point(12, 42);
        lblVitorias.AutoSize = true;
        lblVitorias.Font = new Font("Segoe UI", 10F);
        lblVitorias.ForeColor = Color.FromArgb(34, 197, 94);

        lblDerrotas.Text = "Derrotas: 0";
        lblDerrotas.Location = new Point(12, 68);
        lblDerrotas.AutoSize = true;
        lblDerrotas.Font = new Font("Segoe UI", 10F);
        lblDerrotas.ForeColor = Color.FromArgb(239, 68, 68);

        lblEmpates.Text = "Empates: 0";
        lblEmpates.Location = new Point(12, 94);
        lblEmpates.AutoSize = true;
        lblEmpates.Font = new Font("Segoe UI", 10F);
        lblEmpates.ForeColor = Color.FromArgb(168, 85, 247);

        lblTotal.Text = "Total: 0";
        lblTotal.Location = new Point(12, 126);
        lblTotal.AutoSize = true;
        lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

        pnlEstatisticas.Controls.Add(lblEstatisticasTitulo);
        pnlEstatisticas.Controls.Add(lblVitorias);
        pnlEstatisticas.Controls.Add(lblDerrotas);
        pnlEstatisticas.Controls.Add(lblEmpates);
        pnlEstatisticas.Controls.Add(lblTotal);

        // --- Histórico (lado direito, abaixo das estatísticas) ---
        lblHistoricoTitulo.Text = "Histórico";
        lblHistoricoTitulo.Location = new Point(580, 195);
        lblHistoricoTitulo.AutoSize = true;
        lblHistoricoTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

        lstHistorico.Location = new Point(580, 222);
        lstHistorico.Size = new Size(200, 133);
        lstHistorico.Font = new Font("Segoe UI", 9F);
        lstHistorico.BorderStyle = BorderStyle.FixedSingle;

        // --- Form ---
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 370);
        Text = "Jokempo - Pedra, Papel e Tesoura";
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        BackColor = Color.White;

        Controls.Add(pnlJogador);
        Controls.Add(pnlJogadas);
        Controls.Add(pnlResultado);
        Controls.Add(pnlEstatisticas);
        Controls.Add(lblHistoricoTitulo);
        Controls.Add(lstHistorico);

        ResumeLayout(false);
    }

    #endregion

    private Panel pnlJogador;
    private Label lblJogador;
    private TextBox txtNomeJogador;
    private Button btnEntrar;

    private Panel pnlJogadas;
    private Label lblEscolha;
    private Button btnPedra;
    private Button btnPapel;
    private Button btnTesoura;

    private Panel pnlResultado;
    private Label lblJogadorEscolheu;
    private Label lblComputadorEscolheu;
    private Label lblResultado;

    private Panel pnlEstatisticas;
    private Label lblEstatisticasTitulo;
    private Label lblVitorias;
    private Label lblDerrotas;
    private Label lblEmpates;
    private Label lblTotal;

    private Label lblHistoricoTitulo;
    private ListBox lstHistorico;
}
