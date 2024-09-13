

// // Скорость первого автомобиля V1 км/ч, второго — V2 км/ч, расстояние между ними S км. 
// Определить расстояние между ними через T часов, если автомобили удаляются друг от друга.


public class Program1
{
    static void Main(string[] args)
    {
        string a = Console.ReadLine();
        int V1 = Convert.ToInt32(a);

        string b = Console.ReadLine();
        int V2 = Convert.ToInt32(b);

        string c  = Console.ReadLine();
        int T = Convert.ToInt32(c);

        string d  = Console.ReadLine();
        int S1 = Convert.ToInt32(d);

        int rezult1 = V1 * T;
        int rezult = V2 * T; 
        int itog = rezult1 + rezult;
        int itog2 = itog + S1;

        Console.WriteLine("S = " + itog2 );
    }
}