using System;
using Snake_Game;

namespace CobraJogos
{
    class Program
    {
        public int lins = 30, cols = 79;
        public int[,] cobra = new int[500, 2];
        public int posXCobra = 5, posYCobra = 5;
        public int posXComida, posYComida;
        public int posXComida2, posYComida2;
        public int tamCobra = 3, tempoEspera = 150, pontos = 0;
        public bool fimDoJogo = false;
        public enum Direcao { Direita, Esquerda, Cima, Baixo };
        public void DesenharArea()
        {
            for (int i = 0; i < lins; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0 || i == lins - 1)
                        Console.Write("*");
                    else
                        if (j == 0 || j == cols - 1)
                        Console.WriteLine("*");
                    else
                        Console.WriteLine(" ");
                }
                Console.WriteLine();
            }

            Console.SetCursorPosition(5, 5);

            Console.Write("\t     ( )\t\r\n\t      |                                    \\/\r\n\\/           \\|/\t\t\t\\/         \r\n\t\t\t\\/\t\t\t\t\\/                \\/\r\n\t\\/\r\n\t\t\t.:\t\t\t\t.:      \\/     \r\n\\/\r\n.:\t\t\t\t\\/ \t\r\n\t\r\n       \\  /\t\t\\/\t\t\t\t.:\t\t\t\\/\r\n\t\\/\t\t                   \\/\t\t\t\t\t\r\n\r\n\t\t.:\t\t\t\t\t\t\t\r\n.:\r\n\t\t\t\t\t |\t.:\t\t\t.:\r\n\t\t\t\t\t\\ /\r\n    \\/\r\n\t\t\t.:    \r\n\t\t\t          /          \t\t.:   \r\n\\/\t\t\t\t\\/ \t        \\/                    \\/\r\n\r\n       \\\t\t\t.:\t\r\n\t\\/\r\n\t                                                        ( ) \r\n\t\t\t\t\t.:\t\t       \\ | /\r\n.:\t       ( )\t\t\t\t\t\t\\ /\r\n\t\t|                                                \r\n\t\t\t\t\t\t\t\t\t\r\n\t.:\t\t\t\t\t\\/\t\t\t\t\r\n\r\n\t\t\\/\t\t\t\t\t\t\\/");
        }

        
        public void IniciarCobra()
        {
            for (int i = 0; i < tamCobra; i++)
            {
                cobra[i, 0] = posXCobra;
                cobra[i, 1] = posYCobra;
                posXCobra--;
            }
            for (int i = 0; i < tamCobra; i++)
            {
                Console.SetCursorPosition(cobra[i, 0], cobra[i, 1]);
                Console.WriteLine();
            }
        }
        public void Andar(Direcao d)
        {
            int i = 0;
            Console.SetCursorPosition(cobra[tamCobra - 1, 0], cobra[tamCobra - 1, 1]);
            Console.WriteLine(" ");
            for (i = tamCobra - 1; i > 0; i--)
            {
                cobra[i, 0] = cobra[i - 1, 0];
                cobra[i, 1] = cobra[i - 1, 1];
            }
            switch (d)
            {
                case Direcao.Direita:
                    ++cobra[0, 0];
                    break;
                case Direcao.Esquerda:
                    --cobra[0, 0];
                    break;
                case Direcao.Baixo:
                    ++cobra[0, 1];
                    break;
                case Direcao.Cima:
                    --cobra[0, 1];
                    break;
            }
            Console.SetCursorPosition(cobra[0, 0], cobra[0, 1]);
            Console.Write("▐");
            if (ColidiuComAPropiaCobra(cobra[0, 0], cobra[0, 1]))
            {
                
                fimDoJogo = true;


            }
        }

       


        public void ColidiuComAParede()
        {
            if (cobra[0, 0] == 0 || cobra[0, 0] == cols - 1 ||
             cobra[0, 1] == 0 || cobra[0, 1] == lins - 1)
            {
                
            
                fimDoJogo = true;
            }
        }

        public void DesenharComida2()
        {
            bool sobrepoe = true;
            do
            {
                Random rnd = new Random();
                posXComida2 = rnd.Next(1, cols - 1);
                posYComida2 = rnd.Next(1, lins - 1);
                sobrepoe = false;
                for (int i = 0; i < cobra.GetLength(0); i++)
                {
                    if (cobra[i, 0] == posXComida2 && cobra[i, 1] == posYComida2)
                    {
                        sobrepoe = true;
                    }
                }
            }
            while (sobrepoe == true);
            Console.SetCursorPosition(posXComida2, posYComida2);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Encontrou2()
        {
            if (posXComida2 == cobra[0, 0] && posYComida2 == cobra[0, 1])
            {
                DesenharComida();
                tamCobra += 20;
                tempoEspera -= 5;
                pontos += 20;

                ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
                Random r = new Random();

                ConsoleColor textColor;
                do
                {
                    textColor = colors[r.Next(colors.Length)];
                }
                while (textColor == Console.BackgroundColor);
                Console.ForegroundColor = textColor;

                Console.SetCursorPosition(Console.WindowWidth - 48, 0);
                Console.Write("Pontos: " + pontos);
                Console.Beep(659, 125);
            }
        }
        public void DesenharComida()
        {
            bool sobrepoe = true;
            do
            {
                Random rnd = new Random();
                posXComida = rnd.Next(1, cols - 1);
                posYComida = rnd.Next(1, lins - 1);
                sobrepoe = false;
                for (int i = 0; i < cobra.GetLength(0); i++)
                {
                    if (cobra[i, 0] == posXComida && cobra[i, 1] == posYComida)
                    {
                        sobrepoe = true;
                    }
                }
            }
            while (sobrepoe == true);
            Console.SetCursorPosition(posXComida, posYComida);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("#");
            Console.ForegroundColor = ConsoleColor.White;


        }

        public void Encontrou()
        {
            if (posXComida == cobra[0, 0] && posYComida == cobra[0, 1])
            {

                DesenharComida2();
                tamCobra += 10;
                tempoEspera -= 5;
                pontos += 10;

                ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
                Random r = new Random();

                ConsoleColor textColor;
                do
                {
                    textColor = colors[r.Next(colors.Length)];
                }
                while (textColor == Console.BackgroundColor);
                Console.ForegroundColor = textColor;


                Console.SetCursorPosition(Console.WindowWidth - 48, 0);
                Console.Write("Pontos: " + pontos);
                Console.Beep(659, 125);
            }
        }
        public void Fundo()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
        }
        public bool ColidiuComAPropiaCobra(int posX, int posY)
        {
            int i;
            for (i = 1; i < tamCobra; i++)
            {
                if (cobra[i, 0] == posX && cobra[i, 1] == posY)
                    return true;
            }
            return false;
        }

        public void PontuacaoFinal()
        { 
            Console.SetCursorPosition(Console.WindowWidth - 48, 8);
            Console.Write("Pontuação: " + pontos);
        }
        

        public void Alexsandro()
        {
            DesenharComida2();
            Fundo();
            DesenharArea();
            IniciarCobra();
            DesenharComida();
            Direcao d = Direcao.Direita;
            Console.SetWindowSize(80, 30);
            Console.SetCursorPosition(Console.WindowWidth - 48, 0);

            Console.Write("Pontos: " + pontos);
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo cki = Console.ReadKey();
                    switch (cki.Key)
                    {
                        case ConsoleKey.RightArrow:
                            d = Direcao.Direita;
                            break;

                        case ConsoleKey.LeftArrow:
                            d = Direcao.Esquerda;
                            break;


                        case ConsoleKey.DownArrow:
                            d = Direcao.Baixo;
                            break;

                        case ConsoleKey.UpArrow:
                            d = Direcao.Cima;
                            break;
                        default:
                            break;
                    }
                }
                if (!fimDoJogo)
                {
                    Andar(d);
                    ColidiuComAParede();
                    Encontrou();
                    Encontrou2();
                    System.Threading.Thread.Sleep(tempoEspera);
                }
                else
                { 
                    Game Carlinhos = new Game();
                    Carlinhos.EndGame();
                }
            }
        }

    }
}
