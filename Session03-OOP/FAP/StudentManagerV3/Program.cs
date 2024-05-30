using StudentManagerV3.Entities;

namespace StudentManagerV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            //nếu khuôn không có constructor thì ta vẫn được 1 object, tức là sẵn có giá trị default
            //máy ảo Java, VM, Runtime machine bên C# sẽ tự động cung cấp 1 empty constructor, phễu rỗng, không tham số, không đầu vào, không gán gì cả, mục đích để kết hợp với toán tử new để cung cấp vùng ram object mang giá trị default cho các field

            //không có constructor, mặc nhiên ta sẽ xài constructor
            Console.WriteLine(s1);

            //Điều gì xảy ra 1 class có sẵn 1 constructor có nhận đầu vào - constructor có tham số
            //thì c# và java không tạo ra cho mình 1 constructor default 
            //tuy nhiên...

            Student s2 = new Student("SE2");
        }
    }
}
