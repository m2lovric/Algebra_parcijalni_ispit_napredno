using Ispit.Konzola.Sucelja;

namespace Ispit.Konzola;

class Program
{
    static void TestirajTelefon(IPametniTelefon telefon)
    {
        Console.Write("Poziv na broj: ");
        string broj = Console.ReadLine();
        Console.WriteLine(telefon.Poziv(broj));
        
        Console.Write("Posjeti web stranicu: ");
        string url = Console.ReadLine();
        Console.WriteLine(telefon.Surfanje(url));
    }
    
    static void Main(string[] args)
    {
        var tel = new PametniTelefon("iPhone 15");
        TestirajTelefon(tel);
    }
}