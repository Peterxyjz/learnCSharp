using StudentManagerV6.Entities;

namespace StudentManagerV6
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Student s1 = new Student();
        //    Console.WriteLine("S1 details: ");
        //    Console.WriteLine("Name: " + s1.GetName());
        //    Console.WriteLine("Yob: " + s1.Yob);
        //    Console.WriteLine("Gpa: " + s1.Gpa);

        //    //gọi hàm set:
        //    s1.Yob = 2004;
        //    s1.Gpa = 8.6;
        //    s1.SetName("An");
        //    Console.WriteLine("S1 details Again: ");
        //    Console.WriteLine("Name: " + s1.GetName());
        //    Console.WriteLine("Yob: " + s1.Yob);
        //    Console.WriteLine("Gpa: " + s1.Gpa);

        //}

        static void PlayWithGetSet()
        {
            //get: lấy ra 1 cái gì đó: READ
            //set: đưa vào 1 cái gì đó: WRITE

            int yob = 2004;
            //tui muốn biết năm sinh của bạn, READ, GET
            //dùng tên biến chính là get value

            Console.WriteLine("Yob: " +yob); //dùng tên biến là get/read

            //đối năm sinh cái coi:
            yob = 2005; //set giá trị mới cho biến, tức là write/set
            //dùng tên biến lấy được value, gọi là get, read
            //dùng tên biến = value; gọi là set/ thiết lập, write
            //với 1 biến ta luôn có được hai thứ get và set
            int age = 2024 - yob;

        }

        static void Main(string[] args)
        {
            //Student s1 = new Student();
            //phải set từng value
            Student s1 = new Student() { Yob = 2004, Gpa = 8.6 };
            //vừa new vừa set 
            Console.WriteLine("S1 detail: ");
            Console.WriteLine("Gpa: " + s1.Gpa);
            Console.WriteLine("Yob: " + s1.Yob);
            Console.WriteLine("Name: " + s1.GetName());
            //kỹ thuật này gọi là: Object initialization
        }
    }
}
