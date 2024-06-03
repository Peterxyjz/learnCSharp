using StudentManagerV5.Entities;

namespace StudentManagerV5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("SE1", "An", 2004, 8.6);
            Console.WriteLine($"S1 detail: {s1}");

            Student s2 = new Student(name: "Binh",yob: 2004 ,gpa: 8.9,id: "SE1");
            Console.WriteLine($"S2 detail: {s2}");
            //kỹ thuật new mới 
            //  ghi rõ tên đầu vào của hàm kèm dấu : kèm value
            //  cho phép truyền lộn xộn tham số, mà không bị gãy datatype
            //giúp truyền tham số linh hoạt hơn
            // kĩ thuật named-argument - Truyền value vào kèm tên tham số
            //Kĩ thuật new khác - object vô danh - anonymous object
            //object ứng với 1 vùng new, vùng new trả về tọa độ được gán vào biến
            //biến[] ------------> trỏ ---------> [vùng new bự có members]
            //student s ---------> new student(...);
            //s. tức là vào vùng new chấm

            //sinh viên đặc biệt
            new student("se3", "cường", 2004, 8.8).showprofile();
            //object vô danh, vùng new student() đầy đủ info, gọi hàm, được 1 lần, mất dấu vết do không có biến tham chiếu vào nó
            //máy ảo, runtime sẽ rà quét vùng ram coi có thằng nào lơ lửng
            //clear liền để ram cho object khác - garbage collector

            //Hai chàng 1 nàng
            Student s4 = s2;
            PassStudent(s2);
            Console.WriteLine("S2 detail after: ");
            s2.ShowProfile();
        } //hết main()

        //gọi hàm thì dạng passStudent(s2)
        static void PassStudent(Student x)
        {
            //x và biến truyền vào vd: s2, 2 chàng trỏ 1 nàng x thay đổi s2 thay đổi
            x.SetGpa(999);
        }


    }
}
