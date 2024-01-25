/*
Exempel 2. Skriv en konsolapplikation 
som ska för angivna sidolängder av kvadrat och kuber, 
beräkna arean av en kvadrat och en kub, 
såväl som för ett givet arean för att bestämma 
sidolängder av kvadrat och kuber.
 */
namespace ConsoleApp1
{
    internal class Program
    {
        public class CalcArea
        {
            public void Area()
            {
                Console.Clear();
                Console.WriteLine("Enter sidelength of the square:");

                if (int.TryParse(Console.ReadLine(), out int size))
                {
                    int result = size * size;
                    Console.WriteLine($"The area of the square is {result}.");
                }
                else
                {
                    Text("Invalid input, please try again.");
                }
                Console.ReadLine();
            }
            public void SquareSize()
            {
                Console.Clear();
                Console.WriteLine("Enter the area for which you want to determine the side lengths of a square:");

                if (int.TryParse(Console.ReadLine(), out int result) && result >= 0)
                {
                    double size = Math.Sqrt(result);
                    Console.WriteLine($"With the area of {result}, the lengths of the sides of the square is {size}.");
                }
                else
                {
                    Text("Invalid input, please try again.");
                }
                Console.ReadLine();
            }


            public void Text(string text)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(text);
                Thread.Sleep(3000);
                Console.ResetColor();
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                CalcArea calcArea = new CalcArea();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Welcome to area calculation");
                Console.WriteLine("[1] - Calculate area.");
                Console.WriteLine("[2] - Decide side lengths.");
                Console.WriteLine("[3] - Exit.");

                Int32.TryParse(Console.ReadLine(), out int input);
                if (input == 1)
                {
                    calcArea.Area();
                    continue;
                }
                else if (input == 2)
                {
                    calcArea.SquareSize();
                    continue;
                }
                else if (input == 3)
                {
                    calcArea.Text("Shutting down...");
                    return;
                }
                else
                {
                    calcArea.Text("Wrong input. Try again..");
                    continue;
                }
            }
    

        }
    }
}
