using StudentManagerV1.Entities;

namespace StudentManagerV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo dựng ra các hồ sơ sinh viên, đăng kí tài khoản hồ sơ sinh viên, [C]RUD
            //có khuôn thì đem ra đúc, đổ vật liệu vào
            //có được 1 object đặt tên cho nó y chang như ba má đặt tên cho mình
            Student s1 = new Student("SE1", "AN", 2004, 8.6);
            //vietsub: s1 là 1 sinh viên và infor đầy đủ của bạn ấy là se1, an, 2004, 8.6
            //giống mình ở nhà ba má gọi là tí tèo <> s1, s2. 
            s1.ShowInfor();
            string msg = s1.ToString();
            Console.WriteLine("s1 details: " + msg);
            Console.WriteLine("s1 details: " + s1); //gọi thầm tên em 
            //ToString() được xử lý y như java
            //Nếu 1 class không có làm hàm toString() 1 cách tường mình, thì khi gọi thầm toString thì C# sẽ trả ra datatype 
            //chứ không phải hexa như java

            //Cách new thứ 2:
            Console.WriteLine("Student2 -------------------");
            Student s2 = new ("SE2", "Binh", 2004, 8.9);
            s2.ShowInfor();
            //Bỏ New Student(), dùng new là đủ

            var s3 = new Student("SE3", "Cuong", 2004, 8.7);
            s3.ShowInfor();
            //bỏ 1 trong 2 vế 

            var s4 = s3;
            //2 chàng trỏ 1 nàng, s4 cùng trỏ vùng new s3
            //nhắc lại: khi bạn truyền biến object là bạn đã truyền tham chiếu rồi
            //hàm F (Student X)
            //{
            //
            //}
            //gọi hàm F(s3) => trong hàm chính là x = s3 2 chàng 1 nàng
            s4.SetYob(2005);
            Console.WriteLine("s3 again after s4");
            s3.ShowInfor();
        }
    }
}
