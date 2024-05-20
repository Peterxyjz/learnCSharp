namespace IntegersV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //xài hàm trả về 4 giá trị cùng 1 lúc
            // 3 qua ngả out, 1 qua ngả return
            int sumA, sumO, sumE, countE;
            sumA = ComputeNumbers(out sumO, out sumE, out countE, out int countP);
            Console.WriteLine("Tổng tất cả:  " + sumA);
            Console.WriteLine("Tổng chẵn:  " + sumO);
            Console.WriteLine("Tổng lẻ:  " + sumE);
            Console.WriteLine("Có " + countE + " số chẵn");
            Console.WriteLine("Có " + countP + " số chẵn");
        }

        //static void Main(string[] args)
        //{
        //    //xài hàm:
        //    //c1: khai báo 1 biến và đưa vào hàm. Có cần gán value cho biến hay không
        //    int x = 10;
        //    PowerBy2V2(out x);
        //    Console.WriteLine("x: " + x);//100

        //    //c2: Không cần gán giá trị đầu vào, do hàm out hứa có value được đổ vào!!! Thích gán thì gán nhưng bị hàm đè mất value
        //    int y;
        //    PowerBy2V2(out y);
        //    Console.WriteLine("y: " + y);

        //    //c3: ChatGPT, copilot hay viết:
        //    PowerBy2V2(out int z);
        //    Console.WriteLine("z: " + z);
        //    //khai báo ngay trong lúc gọi hàm, và đằng nào cũng có value


        //}

        //static void Main(string[] args)
        //{
        //    int x = 10;
        //    //gọi hàm bình phương
        //    PowerBy2(x);
        //    Console.WriteLine("In Main() x is now (after method): " + x);
        //}

        //Thử nghiệm chơi với keyword out
        //keyword chỉ dùng ở tham số hàm (đầu vào của hàm)
        //Viết hàm nhận vào 1 con số và tăng con số đó lên bình phương
        //vd: 2 ==> 4; cấm dùng return, cấm in ra

        static void PowerBy2(int n)
        {
            n *= n; //n đã bị thay đổi vì biến gán = value
            //in thử
            Console.WriteLine(n);
        }

        static void PowerBy2V2(out int n)
        { 
            //em hứa trong hàm, em sẽ return 1 giá trị n nào đó cụ thể qua cái biến n
            //out nghĩa là hứa chắc cú sẽ có
            n = 100;
        }

        //CHANGLE: Viết hàm tính tổng trả về các con số từ 1...100, trả về 1 lượt:
        //- Tổng các số chẵn
        //- Tổng các số lẻ
        //- Số con số chẵn, có bao nhiêu con số chẵn
        //- Có bao nhiêu số nguyên tố

        //Chỉ viết 1 hàm duy nhất:

        /// <summary>
        /// Hàm này trả về từ 1 cho đến 100
        ///     TRẢ VỀ luôn số con số lẻ, số con số chẵn, tổng con số chẵn
        /// </summary>
        /// <param name="oddsSum"></param>
        /// <param name="evensCount"></param>
        /// <param name="evensSum"></param>
        /// <returns></returns>
        static int ComputeNumbers(out int oddsSum, out int evensSum, out int evensCount, out int countP)
        {
            int sumAll = 0;
            oddsSum = 0;
            evensSum = 0;
            evensCount = 0;
            countP = 0;

            for (int i = 1; i <= 10; i++)
            {
                sumAll += i; //gặp i là cộng
                if (i % 2 == 0)
                {
                    evensSum += i;
                    evensCount++;
                }
                else
                    oddsSum += i;
                if(IsPrime(i))
                    countP++;
            }
            return sumAll;
        }

        static bool IsPrime (int n) 
        {
            bool flag = true;
            for (int i = 2; i <= n - 1; i++)
            {
                if(n % i == 0)
                    flag = false;
            }
            return flag;
        }

    }
}
//Chốt hạ:
/*
    Out là kĩ thuật truyền tham chiếu, truyền địa chỉ vùng ram cho biến khác giữ, pass by reference và chỉ được dùng ở tham số hàm
    Ứng dung: Giúp hàm trả về cùng lúc nhiều giá trị qua ngách/ đường/ hướng tham số
    OUT: nghiêm túc, trong code của hàm out, bắt buộc phải có lệnh nào đó để gán 1 giá trị cụ thể cho biến out này
    OUT: em hứa trong hàm của em sẽ trả về cho anh bên ngoài 1 giá trị 
    //Hậu trường:
    //              int x = 10      Ô RAM x [ 10 ]
    //                  x = 11            x [ 11 ]  
   
    //              int x = 10      Ô RAM x [ 10 ]
    
    //         F(out int n)         Ô RAM n [ ?? ]

    //xài       int z               Ô RAM z [ ?? ]

//gọi hàm F(out z)
// Ô RAM z [ ???]
//            |
// Ô Ram N [ ??? ]

//N THAY ĐỔI THÌ Z THAY ĐỔI


*/
