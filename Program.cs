//Josefin Mikaelsson .NET23
namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask user how many rows in the chessboard 
            Console.WriteLine("--------------SCKACKBRÄDET--------------");
            Console.WriteLine();
            Console.WriteLine("Hur stort sckackbräde vill du ha?");
            Console.Write("Ange antal kolumner: ");
            int userInputWidth = int.Parse(Console.ReadLine());
            Console.Write("Ange antal rader: ");
            int userInputLength = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("------------Ditt sckackbräde------------");
            Console.WriteLine();


            //unicode to show the squares, and setting a unicode standard output
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string whiteSquares = "◻︎";
            string blackSquares = "◼︎";


            for (int i = 0; i < userInputLength; i++)
            {

                for (int j = 0; j < userInputWidth; j++)
                {
                    //make every other line start with blacksquare.
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write(whiteSquares);
                        }
                        else
                        {
                            Console.Write(blackSquares);
                        }
                    }
                    else
                    {
                        if (j % 2 == 1)
                        {
                            Console.Write(whiteSquares);
                        }
                        else
                        {
                            Console.Write(blackSquares);
                        }
                    }

                }
                Console.WriteLine();
            }
        }
    }
}