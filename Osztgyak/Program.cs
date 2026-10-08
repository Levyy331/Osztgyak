using Osztgyak;

string fajlNev = "szobak.txt";
if (!File.Exists(fajlNev))
{
    foreach (string szoba in File.ReadAllLines("szobak.txt"))
    {

    }
    
}
else
{
    Console.WriteLine("A szobak.txt fájl nem található");
}