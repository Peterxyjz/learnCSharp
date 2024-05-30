using System.Diagnostics;
using System.Security.Cryptography;

namespace NullValue
{

    internal class Student
    {
        private string _id;
        public double _gpa;//điểm trung bình từ 0 -> 10 
                            //lưu xuống Db, hoặc lấy từ DB lên 
                            //Sinh viên mới vào trờng thì ko có điểm trung bình 
                            //Khi new Student, gán GPA là mấy 
                            //Gán 0, -1 để hiểu răng phải học mới có điểm 
                            //Về logic nhìn DB sẽ thấy gpp là 0 điểm hợp lệ, - 1 là điểm kỳ quặc 
        public Student (string id, double gpa)
        {
            _id = id;
            _gpa = gpa;
        }


        public void ShowProfile()
        {
            Console.WriteLine($"Id: {_id}, GPA: {_gpa}");
        }

    }

    internal class StudentNull
    {
        private string? _id;
        private double? _gpa;//điểm trung bình từ 0 -> 10 
                            //lưu xuống Db, hoặc lấy từ DB lên 
                            //Sinh viên mới vào trờng thì ko có điểm trung bình 
                            //Khi new Student, gán GPA là mấy 
                            //Gán 0, -1 để hiểu răng phải học mới có điểm 
                            //Về logic nhìn DB sẽ thấy gpp là 0 điểm hợp lệ, - 1 là điểm kỳ quặc 
        public StudentNull(string? id, double? gpa)
        {
            _id = id;
            _gpa = gpa;
        }


        public void ShowProfile()
        {
            Console.WriteLine($"Id: {_id}, GPA: {_gpa}");

        }

    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            CreateObjStudent();
            PlayWithNull();
            PlayWithObjVarV1();
            PlayWithObjVarV2();
            PlayWithObjVarV3();
            PlayWithObjVarV4();
            PlayWithNullableV2();
        }


        //Thử nghiệm thêm về Nullable 
        static void PlayWithNullableV2() 
        {
            Student s1 = null; 
            Student? s2 = null;
            //2 cách đều ổn vì biến obj có quyền trỏ vùng null - chuẩn object ko bàn 
            //Vậy dấu ? trong datatype hay nên được dùng kết hợp với 
            //Kiểu primitive/value type - biến đơn giá trị
            //int, long, float, double,.....

            int a = 0; 
            int b = 0;
            int? c = 0;
            c = null; //nó lạ lắm
            //b = null; //toang cmnr
            Console.WriteLine("C: " , c);

            s1?.ShowProfile();
            s2?.ShowProfile();
        }

        //Thử nghiệm về biến object, cụ thể object student
        static void PlayWithObjVarV4()
        {
            
            Student s1 = new Student("SE1123", 999);
            Student s2 = s1??new ("SEGAY", 123);
            s2.ShowProfile();

            Student s3 = new Student("SE33", 546);
            Student s4 = s3 == null ? new("SE666", 89) : new("SE190", 23);

            s4.ShowProfile();   
            int yob = 2003;
            string msg = yob > 2000 ? "GEN Z" : "too outdate"; 
            
            //Biến A = Value lệ thuộc if else gì đó
            //Biến A = Biểu thức đúng sai ? "ứng với biểu thức đúng" : "Ứng với biểu thức sai"
            //? này gọi là: Conditional ternary operator
            //Biểu thức tay 3
            //??.Gọi hàm Null Condition
            //? Giá trị khác được gán cho biến nào đso: COALESING 
            //S4 = S3? new Student(.....);

        }

        static void PlayWithObjVarV3()
        {
            Student s1 = new Student("SE123", 9);
            s1.ShowProfile();
            s1 = null;
            s1?.ShowProfile();
        }

        static void PlayWithObjVarV2()
        {
            //gán các biến object lẫn nhau
            Student s1; 
            Student s2 = new ("SE44", 8.6);

            s1 = s2;

            //check 2 chàng có đúng trỏ vào 1 nàng hay ko
            s1.ShowProfile(); //s2 new nhưng lại bắt s1 in ra

            //Chứng minh thêm
            s1._gpa = 6969;
            //đi hỏi s2
            s2.ShowProfile();
        }

        static void PlayWithObjVarV1() 
        {
            Student s1; 
            Student s2 = null; //Các biến object được quyền gán null (đựac quyền)
            //s2 trỏ vào đáy RAM, byte thứ 0 - byte null
            //hợp lệ có value những bị lỗi lúc runtime.
            Student s3 = null;
            //Câu dưới có thể thay bằng is null hoặc là is notnull 
            if ( s3 == null ) { Console.WriteLine("Please creating an object before calling its"); }
            else s3.ShowProfile();

            Console.WriteLine("Check S3 null or not and print profile !!");
            s3?.ShowProfile(); //Null-Condition Operator 
            //Dấu ? đi kèm biến obj để check if nó là khác null thì mình gọi hàm
            //Nếu s3 = null thì ko gọi hàm, né được if else


            //check lại ? toán tử null condition 
            Console.WriteLine("check S4 null ?");
            Student s4 = new Student("SE69", 10.00);
            s4?.ShowProfile();



            //s2.ShowProfile(); //mò vào vùng đáy RAM tìm hàm để chạy, ko có hàm. Error lúc runtime
            //s1.ShowProfile(); //bị chửi vì chơi biến rác, biến khai báo thì phải gán value

        }

        
        static void CreateObjStudent()
        {
            Student st1 = new Student("SE1", 8.9);
            //tương đương câu lệnh SQL: insert into Student values ('SE1',89)
            Student st2 = new("SE2", 6.9);
            //int currentYear; //Dự kiến lưu 2024, nhưng chưa thèm gán gì cả, mới xin RAM
            //Console.WriteLine(currentYear); //Error lúc gõ Code
            st1.ShowProfile();
            st2.ShowProfile();

            StudentNull sn1 = new StudentNull(null, null);
        }

        //em sinh ra có khả năng chưa giá trị null !!!
        static void PlayWithNullable() 
        {
            int n1; //mới xin RAM, gán rác
                    //nếu xài bị error lúc code
            n1 = 100; 
            
            int? n2 = null;
            //int? bản chất là int nhưng cho phép thêm giá trị null để tương thích giá trị null đọc cột trong table Database
            //Nullable
            //mọi kiểu dữ primitve đính kèm ? có thể mang giá trị null 
            //dĩ nhiên biến obj kiểu student s, lecture l sẵn được quyền dùng null rồi

        }

        static void PlayWithNull()
        {
            Student s1; //mới xin RAM thôi, chưa gán giá trị
            Student s2 = null; //mới xin RAM, và gán null 
            //tạm thời s2 chưa trỏ vùng new nào cả !!!
            //s1.ShowProfile(); //Theo nguyên tắc thì xin RAM thì phải có value thì mới được dùng
            /*s2.ShowProfile();*/ //Error lúc runtime, khi chạy code 
                              //vf ko trỏ vùng new nào cả 
                              //tránh bị runtime reference, ta dùng toán tử so sánh kiểm tra xem biến đang trỏ vùng new hay đang null

            if (s2 == null) Console.WriteLine("Hey, you point nothing. Please create an object callin its method");
            else s2.ShowProfile();
            //được quyền dùng !=null hoặc là ==null để kiểm tra 1 obj có đang trỏ vùng new hay ko !!!

            s2 = new("SE32", 23);
            //s2 = new("SE32", null);
            if (s2 is null)
                Console.WriteLine("Hey, you point nothing. Please create an object first");
            else s2.ShowProfile();


        }
    }
}
