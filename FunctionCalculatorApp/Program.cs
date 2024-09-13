
// 3. Найти значение функции y = 4*(x−3)^6 − 7*(x−3)^3 + 2 при данном значении x.


class Program3
{
    static void Main(string[] args)
    {
        string a = Console.ReadLine();
        int x = Convert.ToInt32(a);
        
        int rezult1 = (x-3);

        double rezult2 = Math.Pow(rezult1, 6) * 4;
        double rezult4 = Math.Pow(rezult1, 3) * 7;
        
        double rezult = rezult2 - rezult4;
        double rezult5 = rezult + 2;


        Console.WriteLine("y = " + rezult5);
        
    }
}