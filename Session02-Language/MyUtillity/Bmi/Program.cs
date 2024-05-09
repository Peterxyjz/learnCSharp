namespace Bmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight = 75;//kg
            double height = 1.8;//m
            double bmi = weight / (height * height);    
            Console.WriteLine(bmi);
        }
    }
}
