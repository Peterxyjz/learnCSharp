using BmiV2; //import bên java trỏ đến nơi chứa class mình sẽ dùng

namespace LibraryUsege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bmi = BmiCalculator.GetBmi(75, 1.8);
            //quy tắc đặt tên:
            // biến local - trong hàm nào đó dùng cú pháp con Lạc Đà, camel Case Notation
            //Console.WriteLine(BmiCalculator.GetBmi(75, 1.8));

            Console.WriteLine("Bmi(75kg | 1.8m): " + bmi);
            Console.WriteLine("Bmi(75kg | 1.8m): {0}", bmi);
            Console.WriteLine($"Bmi(75kg | 1.8m): {bmi}");
        }
    }
}
