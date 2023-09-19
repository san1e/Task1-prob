namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            TTriangle triangle = new TTriangle(a, b, c);

            Console.WriteLine("Довжина сторони A: " + triangle.GetSideA());
            Console.WriteLine("Довжина сторони B: " + triangle.GetSideB());
            Console.WriteLine("Довжина сторони C: " + triangle.GetSideC());
            Console.WriteLine("Периметр трикутника: " + triangle.Per());
            Console.WriteLine("Площа трикутника: " + triangle.Area());

            double NewSideA = double.Parse(Console.ReadLine());
            triangle.SetSideA(NewSideA);
            Console.WriteLine("Нова довжина сторони A: " + triangle.GetSideA());
            Console.WriteLine("Довжина сторони B: " + triangle.GetSideB());
            Console.WriteLine("Довжина сторони C: " + triangle.GetSideC());
            Console.WriteLine("Новий периметр трикутника: " + triangle.Per());
            Console.WriteLine("Нова площа трикутника: " + triangle.Area());
            Console.ReadKey();
        }

    }
}