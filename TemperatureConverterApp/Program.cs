

// 2. Дано значение температуры T в градусах Фаренгейта. Определить значение этой же
// температуры в градусах Цельсия. Температура по Цельсию TC и температура по
// Фаренгейту TF связаны следующим соотношением: TC = (TF − 32)·5/9


class Program2
{
    static void Main(string[] args)
    {
        string a = Console.ReadLine();
        int TF = Convert.ToInt32(a);
        
        int rezult1 = (TF - 32 );
        int rezult2 = rezult1 * 5;
        int rezult3 = rezult2 / 9;

        Console.WriteLine("TC = " + rezult3 );
    }
}
