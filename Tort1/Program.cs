namespace Tort1
{
    internal class Program
    {
        static void Main()
        {
            Tortus.Arrows();
        }
        public static List<DopMenu[]> Make()
        {
            DopMenu[] Shape = new DopMenu[]
            {
                new DopMenu("   Круг - 500", 500),
                new DopMenu("   Квадрат - 600", 600),
                new DopMenu("   Прямоугольник - 600", 700),
                new DopMenu("   Вытянутый прямоугольник - 800", 800)
            };
            DopMenu[] Size = new DopMenu[]
            {
                new DopMenu("   Большой - 400", 400),
                new DopMenu("   Средний - 300", 300),
                new DopMenu("   Маленький - 200",200),
                new DopMenu("   Очень большой - 800",800)
            };
            DopMenu[] Taste = new DopMenu[]
            {
                new DopMenu("   Клубничный - 400", 400),
                new DopMenu("   Шоколадный - 400", 400),
                new DopMenu("   Медовый - 400", 400),
                new DopMenu("   Вкус Cum - 800", 800),
            };
            DopMenu[] Kolvo = new DopMenu[]
            {
                new DopMenu("   4 корджа - 900", 900),
                new DopMenu("   5 корджа - 1000", 1000),
                new DopMenu("   6 корджа - 1400", 1400),
                new DopMenu("   8 корджа - 1800", 1800),
            };
            DopMenu[] Glaze = new DopMenu[]
            {
                new DopMenu("   Сливочный Cum - 300", 300),
                new DopMenu("   Ванильная - 200", 200),
                new DopMenu("   Вареная сгущенка - 400", 400),
                new DopMenu("   Малиновая - 150", 150),
            };
            DopMenu[] Decor = new DopMenu[]
            {
                new DopMenu("   Cum from VAn DarkHolm - 300", 300),
                new DopMenu("   Шоколад - 400", 400),
                new DopMenu("   Ягодки - 400", 400),
                new DopMenu("   Шоколадная крошка - 300", 300),
            };
            List<DopMenu[]> Boba = new List<DopMenu[]>() { Shape, Size, Taste, Kolvo, Glaze, Decor };
            return Boba;
        }
        public static void Menu(int position = 0, int poz = 0)
        {
            List<DopMenu[]> boba = Make();
            if (position == 0)
            {
                Console.WriteLine("Well cum to TORTOTUS");
                Console.WriteLine("-------------------------");
                Console.WriteLine("   ФОРМА");
                Console.WriteLine("   РАЗМЕР");
                Console.WriteLine("   ВКУС");
                Console.WriteLine("   сКОЛЬКО ТЕБЕ КОРЖЕЙ НАХОЙ");
                Console.WriteLine("   Глазурь");
                Console.WriteLine("   Декор");
                Console.WriteLine("   Конец заказа");
                Tortus.Output();
            }
            else if (position != 8)
            {
                Tortus.Dop(boba[position-2]);
            }
            else if (position == 8)
            {
                Console.WriteLine("Спасибо за заказ! ждем вас снова в TORTOTUS!!!!!\r\n " +
                    "для нового заказа, нажмите Enter");
                    Tortus.Zaka();      
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    DopMenu.Zakaz.Clear();
                    DopMenu.Cost.Clear();
                    Tortus.Arrows();
                }    
            }     
        }
    }
}