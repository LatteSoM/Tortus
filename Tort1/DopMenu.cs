namespace Tort1
{
    internal class DopMenu
    {
        public string Name;
        public int Price;
        public static List<string> Zakaz = new List<string>();
        public static List<int> Cost = new List<int>();
        public static int CostM;
        public static string ListZakaza = Convert.ToString(Zakaz);
        public DopMenu(string name, int cost)
        {
            Name = name;
            Price = cost;
        }      
     }
}
