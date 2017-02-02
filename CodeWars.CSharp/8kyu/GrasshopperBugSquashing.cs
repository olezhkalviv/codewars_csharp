namespace CodeWars.CSharp._8kyu.GrasshopperBugSquashing
{
    // This class is added to avoid errors, as Preloaded class is described in CodeWars directly, so don't use it.
    class Preloaded
    {
        public static void roll_dice() { }
        public static void move() { }
        public static void combat() { }
        public static void get_coins() { }
        public static void buy_health() { }
        public static void print_status() { }
    }

    // Grasshopper - Bug Squashing
    // https://www.codewars.com/kata/56214b6864fe8813f1000019
    public static class Kata
    {
        public static int health = 100;
        public static int position = 0;
        public static int coins = 0;

        public static void main()
        {
            Preloaded.roll_dice();
            Preloaded.move();
            Preloaded.combat();
            Preloaded.get_coins();
            Preloaded.buy_health();
            Preloaded.print_status();
        }
    }
}
