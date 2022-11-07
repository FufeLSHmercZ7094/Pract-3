namespace Pract_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите F5 чтобы выбрать октаву или Backspace для выхода");
            ConsoleKeyInfo kl = Console.ReadKey();
            while (kl.Key != ConsoleKey.Backspace)
            {
                if (kl.Key == ConsoleKey.F5)
                {
                    Console.WriteLine("F5");
                    while (kl.Key != ConsoleKey.F6 && kl.Key != ConsoleKey.F7 && kl.Key != ConsoleKey.F8 && kl.Key != ConsoleKey.Backspace)
                    {
                        kl = Zvuchok(kl, 1);
                    }
                }
                else if (kl.Key == ConsoleKey.F6)
                {
                    Console.WriteLine("F6");
                    while (kl.Key != ConsoleKey.F5 && kl.Key != ConsoleKey.F7 && kl.Key != ConsoleKey.F8 && kl.Key != ConsoleKey.Backspace)
                    {
                        kl = Zvuchok(kl, 2);
                    }
                }
                else if (kl.Key == ConsoleKey.F7)
                {
                    Console.WriteLine("F7");
                    while (kl.Key != ConsoleKey.F5 && kl.Key != ConsoleKey.F6 && kl.Key != ConsoleKey.F8 && kl.Key != ConsoleKey.Backspace)
                    {
                        kl = Zvuchok(kl, 3);
                    }
                }
                else if (kl.Key == ConsoleKey.F8)
                {
                    Console.WriteLine("F8");
                    while (kl.Key != ConsoleKey.F5 && kl.Key != ConsoleKey.F6 && kl.Key != ConsoleKey.F7 && kl.Key != ConsoleKey.Backspace)
                    {
                        kl = Zvuchok(kl, 4);
                    }
                }
                else
                {
                    Console.WriteLine(" Такой актавы нету");
                    kl = Console.ReadKey();
                }
            }
        }
        static int Chastota(int z, int x)
        {
            int[,] arr = new int[4, 12] { { 524, 554, 587, 622, 659, 699, 740, 784, 841, 880, 923, 988 }, { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 }, { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 }, { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 } };
        }
        static ConsoleKeyInfo Zvuchok(ConsoleKeyInfo kl, int z) 
        {
            kl = Console.ReadKey();
            if (kl.Key == ConsoleKey.Q) 
            {
                int x = 0;
                int N = Chastota(z, x);
                Beep(N);
            }
            else if (kl.Key == ConsoleKey.W) 
            {
                int x = 1;
                int N = Chastota(z,x);
                Beep(N);
            }
            else if (kl.Key == ConsoleKey.E) 
            {
                int x = 2;
                int N = Chastota(z, x);
                Beep(N);
            }
            else if (kl.Key == ConsoleKey.R) 
            {
                int x = 3;
                int N = Chastota(z, x);
                Beep(N);
            }
            else if (kl.Key == ConsoleKey.T) 
            {
                int x = 4;
                int N = Chastota(z, x);
                Beep(N);
            }
            else if (kl.Key == ConsoleKey.Y) 
            {
                int x = 5;
                int N = Chastota(z, x);
                Beep(N);
            }
            else if (kl.Key == ConsoleKey.U) 
            {
                int x = 6;
                int N = Chastota(z, x);
                Beep(N);
            }
            else if (kl.Key == ConsoleKey.A)
            {
                int x = 7;
                int N = Chastota(z, x);
                Beep(N);
            }
            else if (kl.Key == ConsoleKey.S)
            {
                int x = 8;
                int N = Chastota(z, x);
                Beep(N);
            }
            else if (kl.Key == ConsoleKey.D)
            {
                int x = 9;
                int N = Chastota(z, x);
                Beep(N);
            }
            else if (kl.Key == ConsoleKey.F)
            {
                int x = 10;
                int N = Chastota(z, x);
                Beep(N);
            }
            else if (kl.Key == ConsoleKey.G)
            {
                int x = 11;
                int N = Chastota(z, x);
                Beep(N);
            }
            else if (kl.Key != ConsoleKey.F5 && kl.Key != ConsoleKey.F6 && kl.Key != ConsoleKey.F7 && kl.Key != ConsoleKey.F8 && kl.Key != ConsoleKey.Backspace)
            {
                Console.WriteLine("Выбранной клавиши не существует");
            }
        }

        public static void Beep(int N)
        {
            Console.Clear();
            Console.Beep(N, 500);
        }
    }
}