namespace Tort1
{
    internal class Tortus
    {
        private static ConsoleKeyInfo key = Console.ReadKey();
        private static string adres = "C:\\Users\\Евгений\\Desktop\\Пример.txt";
        public static void Arrows()
        {
            key = Console.ReadKey();
            bool Billy = true;
            while (Billy == true)
            {
                int pozition = 0;
                Program.Menu();
                while (key.Key != ConsoleKey.Enter)
                {
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        pozition--;
                        if (pozition < 2)
                        {
                            pozition = 8;
                        }
                    }
                    else if (key.Key == ConsoleKey.DownArrow)
                    {
                        pozition++;
                        if (pozition > 8)
                        {
                            pozition = 2;
                        }
                    }
                    else if (key.Key == ConsoleKey.Escape)
                    {
                        Billy = false;
                        break;
                    }
                    Console.Clear();
                    Program.Menu();
                    Console.SetCursorPosition(0, pozition);
                    Console.WriteLine("->");
                    key = Console.ReadKey();
                }
                Console.Clear();  
                if (pozition >= 2)
                {
                    Program.Menu(pozition);
                    key = Console.ReadKey();
                    int poz = 0;
                    while (key.Key != ConsoleKey.Enter)
                    {
                        if (key.Key == ConsoleKey.UpArrow)
                        {
                            poz--;
                            if (poz < 0)
                            {
                                poz = 3;
                            }
                        }
                        else if (key.Key == ConsoleKey.DownArrow)
                        {
                            poz++;
                            if (poz > 3)
                            {
                                poz = 0;
                            }     
                        }
                        else if(key.Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                        Console.Clear();
                        Program.Menu(pozition, poz);

                        Console.SetCursorPosition(0, poz);
                        Console.WriteLine("->");
                        key = Console.ReadKey();
                    }
                    Console.Clear();
                    List<DopMenu[]> boba = Program.Make();
                    Add(boba, pozition - 2, poz);
                }
                Program.Menu();
                key = Console.ReadKey();
            }
        }
        public static void Dop(DopMenu[] AllPoints)
        {
            foreach (DopMenu point in AllPoints)
            {
                Console.WriteLine(point.Name);
            }
        } 
        public static void Add(List<DopMenu[]> AllPoints, int pozition, int poz)
        {
            if (key.Key == ConsoleKey.Enter)
            {
                DopMenu.Zakaz.Add(AllPoints[pozition][poz].Name);
                DopMenu.Cost.Add(AllPoints[pozition][poz].Price);
            } 
        }
        public static void Output()
        {
            Console.WriteLine("Цена заказа:");
            DopMenu.CostM = DopMenu.Cost.Sum();
            Console.WriteLine(DopMenu.CostM);
              Console.WriteLine("Ваш заказ:");
            foreach (string LUPA in DopMenu.Zakaz)
            {
                Console.WriteLine(LUPA);
            }
        }
        public static void Zaka()
        {
            DopMenu.CostM = DopMenu.Cost.Sum();
            string asmr = Convert.ToString(DopMenu.CostM);
            string Head = "Заказ в кондитерской TORTOTUS \n" +
                "------------------------------------------------------";
            string mpo = String.Join("\n ", DopMenu.Zakaz);
            File.AppendAllText(adres,Head);
            File.AppendAllText(adres,$"\nЦена заказа:{asmr}");
            File.AppendAllText(adres, $"\nВаш заказ:{mpo}");
            File.AppendAllText(adres, $"\nДата заказа:{DateTime.Now.ToString()}");
        }
    }
}