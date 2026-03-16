# Jokempo

Jogo de Pedra, Papel e Tesoura (Jokempo) desenvolvido em C# (.NET 10.0) como atividade da disciplina de C#.

## Membros

- Ricardo Fernandes de Aquino (RM 554597)
- Khadija do Rocio Vieira de Lima (RM 558971)

## Estrutura do Projeto

A solução contém três projetos:

- **Jokempo** — Aplicação console (entrega anterior)
- **Jokempo.Lib** — Class Library com as classes do jogo (Jogador, Estatísticas, Rodada, Jogo)
- **Jokempo.WinForms** — Interface gráfica usando Windows Forms, referenciando a Jokempo.Lib

## Inicialização

### Console

```bash
dotnet run --project Jokempo --framework net10.0
```

### Windows Forms

```bash
dotnet run --project Jokempo.WinForms
```

> **Nota:** O projeto Windows Forms requer ambiente Windows para execução.
