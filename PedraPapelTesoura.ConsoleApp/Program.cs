class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirTitulo();

            int escolhaJogador = Jogador.ObterEscolha();

            int escolhaComputador = Computador.ObterEscolha();

            Jogo.CompararEscolhas(escolhaJogador, escolhaComputador);

            if (!JogadorDesejaContinuar())
                break;
        }
    }

    static void ExibirTitulo()
    {
        Console.Clear();

        Console.WriteLine("----------------------------------");

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write("Pedra");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(",");

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write(" Papel");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(",");

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write(" Tesoura");
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("\n----------------------------------");

        Console.BackgroundColor = ConsoleColor.Black;
    }

    static bool JogadorDesejaContinuar()
    {
        Console.WriteLine("----------------------------------");
        Console.Write("Deseja continuar? (s/N): ");

        if (Console.ReadLine()?.ToUpper() != "S")
            return false;

        return true;
    }
}

