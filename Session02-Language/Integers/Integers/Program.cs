namespace Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintIntegerList();
            //PrintOddNumbers();
            //PrintSumEvenNumber();
            //PrintNumberFrom1ToN(15);
            //Console.WriteLine(SumNumber());
            //expected value: 5050
            //actual: con sum, mày bằng mấy
            //nếu actual là sum == 5050 ==> Passed cased

            Console.WriteLine($"Sum of evens from 1 - 10: {SumEvens()}");

        }

        //C#: cung cấp các datatype về số y chang java:
        //int, long
        //C# cũng cung cấp cấu trúc điều khiển trong code y chang bên java: if, for, do while, while, switch
        //Tên hàm trong C#: khác Java: V + O và con lạc đà
        //              C#: dùng cú pháp Pascal Case Notation
        //Challenge 1: Viết hàm in ra các con số tự nhiên từ 1...100
        static void PrintIntegerList()
        {
            Console.WriteLine("The list of 100 first integers: ");
            for (int i = 1; i <= 100; i++)
            {
                //Console.Write(i + " ");
                //Console.Write("{0} ", i);
                Console.Write($"{i} ");
            }
            Console.WriteLine(); //xuống hàng
        }

        //CHANGLE 2: Viết hàm in ra số lẻ từ 1 - 100 
        static void PrintOddNumbers()
        {
            Console.WriteLine("The list of 100 first odd number: ");
            for (int i = 1; i <= 100; i++)
                if(i % 2 != 0)
                    Console.Write($"{i} ");
            Console.WriteLine(); //xuống hàng
        }

        //CHANGLE 3: Viết hàm in ra Tổng các số chẵn từ 1 - 10
        static void PrintSumEvenNumber()
        {
            Console.WriteLine("The sum of even number from 1 - 10: ");
            //int sum = 0; //acc - accumulation: biến cộng dồn, biến gửi góp
            
            var sum = 0;
            //là kĩ thuật khai báo biến nà không thèm chỉ ra datatype, C# tự suy ra datatype  khi value lần đầu tiên được gán
            //kỹ thuật này được gọi là type infferrnt - suy luận kiểu
            //Java cũng giống vậy
            for (int i = 1; i <= 10; i++)
                if (i % 2 == 0)
                    sum += i;
            Console.Write($"{sum} ");
            Console.WriteLine(); //xuống hàng
            
        }

        //CHANGLE 4: Viết hàm in ra các con số từ 1 - N
        //static void PrintNumberFrom1ToN(int n)
        //{
        //    Console.WriteLine($"The list of 1 to {n}: ");
        //    for (int i = 1;i <= n; i++)
        //        Console.Write($"{i} ");
        //    Console.WriteLine();
        //}

        //static void PrintNumberFrom1ToN(int n)
        //{
        //     n = 5000; //tham số đầu vào của hàm có quyền thay đổi
        //    Console.WriteLine($"The list of 1 to {n}: ");
        //    for (int i = 1; i <= n; i++)
        //        Console.Write($"{i} ");
        //    Console.WriteLine();
        //}


        static void PrintNumberFrom1ToN(in int n) //keyword in ở paramter sẽ biến tham số nhận vào thành readonly và cấm đổi giá trị 
            //mục đích đảm bảo data đi vào đúng mục đích
        {
            //n = 5000;  ==> Lỗi 
            Console.WriteLine($"The list of 1 to {n}: ");
            for (int i = 1; i <= n; i++)
                Console.Write($"{i} ");
            Console.WriteLine();
        }

        //CHANGLE 5: Viết hàm tính tổng của các số từ 1...100 và trả về kết quả
        static int SumNumber()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
                sum += i;
            return sum;
        }

        //CHANGLE 6: Viết hàm tính tổng số chẵn từ 1 - 100 
        static int SumEvens()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
                if (i % 2 == 0)
                    sum += i;
            return sum;
        }

    }
}
