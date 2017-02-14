using System.Collections.Generic;

namespace CodeWars.CSharp._8kyu
{
    // Welcome!
    // https://www.codewars.com/kata/welcome
    public static class Kata
    {
        static Dictionary<string, string> Greeting => new Dictionary<string, string>()
        {
            {"english", "Welcome"},
            {"czech", "Vitejte"},
            {"danish", "Velkomst"},
            {"dutch", "Welkom"},
            {"estonian", "Tere tulemast"},
            {"finnish", "Tervetuloa"},
            {"flemish", "Welgekomen"},
            {"french", "Bienvenue"},
            {"german", "Willkommen"},
            {"irish", "Failte"},
            {"italian", "Benvenuto"},
            {"latvian", "Gaidits"},
            {"lithuanian", "Laukiamas"},
            {"polish", "Witamy"},
            {"spanish", "Bienvenido"},
            {"swedish", "Valkommen"},
            {"welsh", "Croeso"}
        };

        public static string Greet(string language)
        {
            return Greeting[Greeting.ContainsKey(language) ? language : "english"];
        }
    }
}
