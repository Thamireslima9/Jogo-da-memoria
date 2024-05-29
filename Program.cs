internal class Program
{
    private static void Main(string[] args)
    {
        int[,] jogo = new int[4, 4];
        int[,] tela = new int[4, 4];

        //Para criar números aleatórios
        Random gerador = new Random();

        for (int i = 1; i <= 8; i++) //Atribui os pares de números às posições
        {
            //Escolhe a posição do primeiro número do par
            int lin, col;
            for (int j = 0; j < 2; j++)
            {
                do
                {
                    lin = gerador.Next(0, 4);
                    col = gerador.Next(0, 4);

                } while (jogo[lin, col] != 0);
                jogo[lin, col] = i;
            }
        }

        int acertos = 0;
        bool continuarjogando = true;
        do
        {
            Console.WriteLine("   ");
            for (int j = 0; j < 4; j++)
            {
                Console.Write("   {0} ", j + 1);
            }
            Console.WriteLine("\n  -----------------");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0} |", i + 1);
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" {0} |", tela[i, j]);
                }
                Console.WriteLine("\n  -----------------");
            }
            Console.WriteLine();

            int lin1;
            do
            {
                //Pedir as posições do primeiro número
                Console.WriteLine("Escolha uma linha para jogar [1, 4]: ");
                lin1 = int.Parse(Console.ReadLine());
                lin1--;
            } while (lin1 < 0 || lin1 >= 4);

            int col1;
            do
            {
                Console.WriteLine("Escolha uma coluna para jogar [1, 4]: ");
                col1 = int.Parse(Console.ReadLine());
                col1--;
            } while (col1 < 0 || col1 >= 4);

            tela[lin1, col1] = jogo[lin1, col1];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0} ", tela[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int col2, lin2;
            do
            {
                //Pedir as posições do segundo número
                Console.WriteLine("Escolha uma linha para jogar [1, 4]: ");
                lin2 = int.Parse(Console.ReadLine());
                lin2--;
            } while (lin1 < 0 || lin1 >= 4);

            do
            {
                Console.WriteLine("Escolha uma coluna para jogar [1, 4]: ");
                col2 = int.Parse(Console.ReadLine());
                col2--;
            } while (col1 < 0 || col1 >= 4);

            tela[lin2, col2] = jogo[lin2, col2];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0} ", tela[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Em caso de acerto, a matriz tela permanece como está.
            //Em caso de erro, precisamos voltar as posições para zero.
            if (jogo[lin1, col1] != jogo[lin2, col2])
            {
                tela[lin1, col1] = 0;
                tela[lin2, col2] = 0;
            }
            else
            {
                acertos++;
            }
            Console.WriteLine("Caso deseja sair, insira 0.Caso contrário, insira 1:");
            int saida = int.Parse(Console.ReadLine());
            if (saida == 0)
            {
                Console.Clear();
                Console.WriteLine("Você saiu!!");
                continuarjogando = false;
                break;
            }


        } while (acertos < 8 && continuarjogando);
        if (acertos == 8)
        {
            Console.WriteLine("PARABÉNS, VOCÊ COMPLETOU O JOGO!");
        }
    } 
}