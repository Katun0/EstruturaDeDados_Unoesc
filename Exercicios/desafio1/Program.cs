namespace binaryTicTacToe
{
    class Program
    {
        static char[] boardNumbers = {'0','1','2','3','4','5','6','7','8','9'};
        static int player = 1;
        static int end = 0;
        static int mark;
        static string name1;
        static string name2;
        static void Main()
        {   
            Console.WriteLine("Nome do jogador 1:");
            string name1 = Console.ReadLine();
            Console.WriteLine($"Jogador {name1} registrado como jogador 1, seu marcador será o 0\n");
            Console.WriteLine("Nome do Jogador 2:");
            string name2 = Console.ReadLine();
            Console.WriteLine($"Jogador {name2} registrado como jogador 2, seu marcador será o 1\n");
            board();
            do
            {
                Console.Clear();
//                Console.WriteLine("Nome do jogador 1:");
//                string name1 = Console.ReadLine();
//                Console.WriteLine($"Jogador {name1} registrado como jogador 1, seu marcador será o 0\n");
//                Console.WriteLine("Nome do Jogador 2:");
//                string name2 = Console.ReadLine();
//                Console.WriteLine($"Jogador {name2} registrado como jogador 2, seu marcador será o 1\n");

                if (player % 2 == 0)
                {
                    Console.WriteLine($"Vez do {name2}");
                }
                else
                {
                    Console.WriteLine($"Vez do {name1}");
                }
                board();
                mark = int.Parse(Console.ReadLine());
                if(boardNumbers[mark]!='0' && boardNumbers[mark]!='1')
                {
                    if(player%2==0)
                    {
                        boardNumbers[mark] = '1';
                        player++;
                    }
                    else
                    {
                        boardNumbers[mark] = '0';
                        player++;
                    }
                }

                else
                {
                    Console.WriteLine($"Desculpe, a casa selecionada ja está marcada com {boardNumbers[mark]}, selecione outra por favor\n");
                    Thread.Sleep(2000);
                }
                end = CheckWin();
            }
            while(end != 1 && end != -1);
            Console.Clear();
            board();
            if(end == 1)
            {
                Console.WriteLine($"Jogador(a) {(player%2)+1} Venceu!!!");
                if ((player%2)+1 == 1) {Console.WriteLine($"Parabens {name1}");}
                else {Console.WriteLine($"Parabens {name2}");}
                Thread.Sleep(1000);
            }
        }

        private static void board()
        {
            Console.WriteLine("       |       |       ");
            Console.WriteLine("   {0}   |   {1}   |   {2}  ", boardNumbers[1], boardNumbers[2], boardNumbers[3]);
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("   {0}   |   {1}   |   {2}  ", boardNumbers[4], boardNumbers[5], boardNumbers[6]);
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |       ");
            Console.WriteLine("   {0}   |   {1}   |   {2}  ", boardNumbers[7], boardNumbers[8], boardNumbers[9]);
            Console.WriteLine("       |       |       ");
        }
        private static int CheckWin()
        {
            #region Vitória Horizontal
            //primeira linha
            if(boardNumbers[1]==boardNumbers[2] && boardNumbers[2]==boardNumbers[3]) { return 1;}
            //segunda linha
            else if(boardNumbers[4]==boardNumbers[5] && boardNumbers[5]==boardNumbers[6]) {return 1;}
            //terceira linha
            else if(boardNumbers[7]==boardNumbers[8] && boardNumbers[8]==boardNumbers[9]) {return 1;}
            #endregion

            #region Vitória Vertical
            //primeira coluna
            else if(boardNumbers[1]==boardNumbers[4] && boardNumbers[4]==boardNumbers[7]) {return 1;}
            //segunda coluna
            else if(boardNumbers[2]==boardNumbers[5] && boardNumbers[5]==boardNumbers[8]) {return 1;}
            //terceira coluna
            else if(boardNumbers[3]==boardNumbers[6] && boardNumbers[6]==boardNumbers[9]) {return 1;}
            #endregion"

            #region Vitória Diagonal
            //diagonal
            else if (boardNumbers[1]==boardNumbers[5] && boardNumbers[5]==boardNumbers[9]) {return 1;}
            //diagonal inversa
            else if (boardNumbers[3]==boardNumbers[5] && boardNumbers[5]==boardNumbers[7]) {return 1;}
            #endregion

            #region Empate
            else if (boardNumbers[1] != '1' && boardNumbers[2] != '2' && boardNumbers[3] != '3' && boardNumbers[4] != '4' && boardNumbers[5] != '5' && boardNumbers[6] != '6' && boardNumbers[7] != '7' && boardNumbers[8] != '8' && boardNumbers[9] != '9') {return -1;}
            #endregion
            else{ return 0; }
        }
    }
}