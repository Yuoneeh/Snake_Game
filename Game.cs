using Snake_Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using CobraJogos;


namespace Snake_Game
{
    internal class Game
    {
        public void Start()
        {
            Title = "Snake Game - O Jogo da cobrinha!";
            RunMainMenu();
        }

        
        public void RunMainMenu()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetWindowSize(120, 30);
            string prompt = @"
 _____             _          _____                                                      ---. .-==-              
/  ___|           | |        |  __ \                                                    +--=*=++=+*
\ `--. _ __   __ _| | _____  | |  \/ __ _ _ __ ___   ___                              :+.  :+-  .#    
 `--. \ '_ \ / _` | |/ / _ \ | | __ / _` | '_ ` _ \ / _ \                         +++++: #-**: :*+==-       
/\__/ / | | | (_| |   <  __/ | |_\ \ (_| | | | | | |  __/                         .*+#+++=*#*#++*=+#:+     
\____/|_| |_|\__,_|_|\_\___|  \____/\__,_|_| |_| |_|\___|                         .:-*#++++++==++=++-: 
                                                                              --:..===**++++==++=.  
                                                                                =+-::=+=+=:.:*=:*.   
                                                                                =+==++-+. 
                                                                          .::::#+===-+=-:::.....:::::-::----:.
                                                                       :-=-:===+%*::=-#*****+=-::-===:::::.==+++=-
   Bem vindo ao Snake Game! O que você gostaria de fazer?             :*+-::===++%@*.--:+@@*++*+*+====-.::::========-                                                                        
    (Use as setinhas para navegar pelas opções.)                     .*+==--=++=+*##+===+=::+:::.-+=::.-===-....:==++. 
                                                                      =+======+++++=:..-+=-##==-=+===-=+===:::::.++-   
                                                                       -+=:...:=====:.:-=-#@%+--:.==+: .--==----:      
                                                                       --=-:.======+++=-:.   .:=+==*:                
                                                                          ::-===--::.  .:       *=::+                
                                                                                        *+-:   .*=-=-                
                                                                                          -+*++++=++-             
 ";
            string[] options = { "Jogar", "Tutorial", "Sair" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();
            

            switch (selectedIndex)
            {
                case 0:
                    RodeJogo();
                    break;
                case 1:
                    DisplayTutorial();
                    break;
                case 2:
                    FecharJogo();
                    break;


            }
             void FecharJogo()
            {
                WriteLine("\n Pressione qualquer tecla para sair...");
                ReadKey(true);
                Environment.Exit(0);
            }
             void DisplayTutorial()
            {
                Clear();
                WriteLine(@"
   _____       _                  
  / ____|     | |               _ 
 | (___   ___ | |__  _ __ ___  (_)
  \___ \ / _ \| '_ \| '__/ _ \    
  ____) | (_) | |_) | | |  __/  _ 
 |_____/ \___/|_.__/|_|  \___| (_)
                                  ");
                WriteLine(@"Esse é um projeto que busca replicar o gameplay loop único do icônico 'Jogo da Cobrinha'");
                WriteLine("O objetivo do jogo é sobreviver o máximo de tempo possível.");
                WriteLine("\n");
                WriteLine(@"   Colete Frutas para acumular pontos e aumentar de tamanho!

                      Laranja                 Maçã        
                      @ = 10 Pontos   e   # = 20 Pontos");
                WriteLine(@"
   _____          _               _                                 
  / ____|        (_)             | |                              _ 
 | |       _ __   _    __ _    __| |   ___    _ __    ___   ___  (_)
 | |      | '__| | |  / _` |  / _` |  / _ \  | '__|  / _ \ / __|    
 | |____  | |    | | | (_| | | (_| | | (_) | | |    |  __/ \__ \  _ 
  \_____| |_|    |_|  \__,_|  \__,_|  \___/  |_|     \___| |___/ (_)
                                                                    
Bruno Nunes
Cesar Hyoga
Eduardo Felipe
Evelyn Silva

");
                WriteLine("Pressione qualquer tecla para voltar ao menu");
                ReadKey(true);
                RunMainMenu();
            }
             void RodeJogo()
            {
                Clear();
                Program Matheus = new Program();
                Matheus.Alexsandro();

            }
            
        }
            public void EndGame()
            { 
               Program Caroline = new Program();
               
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
            Clear();

            WriteLine(@"
             _____                         ____                 
            / ____|                       / __ \                
           | |  __  __ _ _ __ ___   ___  | |  | |_   _____ _ __ 
           | | |_ |/ _` | '_ ` _ \ / _ \ | |  | \ \ / / _ \ '__|
           | |__| | (_| | | | | | |  __/ | |__| |\ V /  __/ |   
            \_____|\__,_|_| |_| |_|\___|  \____/  \_/ \___|_|   

                                                      
                           ---_ ......._-_--.
                          (|\ /      / /| \  \
                          /  /     .'  -=-'   `.
                         /  /    .'             )
                       _/  /   .'        _.)   /
                      / o   o        _.-' /  .'
                      \          _.-'    / .'*|
                       \______.-'//    .'.' \*|
                        \|  \ | //   .'.' _ |*|
                         `    \|//  .'.'_ _ _|*|
                          .  .// .'.' | _ _ \*|
                          \`-|\_/ /    \ _ _ \*\
                           `/'\__/      \ _ _ \*\
                          /^|            \ _ _ \*
                         '  `             \ _ _ \      
                                           \_                                                     


                                                                                          ");
            
            WriteLine("O objetivo do jogo é sobreviver o máximo de tempo possível.");
            Caroline.PontuacaoFinal();

            ReadKey(true);
                RunMainMenu();
            }
    }
}
