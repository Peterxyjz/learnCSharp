using StudentManagerV2.Entities;

namespace StudentManagerV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("SE1","An");
            //Vậy yob và gpa mang giá trị default
            //biến cục bộ - local - biến khai báo trong hàm mà không gán value thì cấm dùng, 
            //biến gắn với đặc điểm của 1 obj mà không đc đổ value vào
            // thì new nó sẽ có default
            //số default: 0
            //chuỗi default: ""
            //bool default: false
            Console.WriteLine(s1);
            s1.SetYob(2004);
            s1.SetYob(2005);
            s1.SetYob(2006);
            s1.SetGpa(8.6);
            Console.WriteLine(s1);

            s1 = new Student("SE2", "Bình");
            Console.WriteLine("s1 again");
            Console.WriteLine(s1);
        }
    }
}

//Mỗi lần gọi new là 1 object mới được tạo ra, vùng ram mới, vùng new mới được tạo ra, 
//set là đổi trên đối tượng hiện tại.