namespace GroupCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Skriv två siffror");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int multi = Multiply(num1, num2);
            //Console.WriteLine($"{num1} x {num2} = {multi} ");
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
