using MainUI.Music;

namespace MainUI //package mainUi bên Java
{   
    //namespace bên C# | package bên java chẳng qua là tên thư mục /folder/directory chứa src code, chứa class 
    //1 namespace | package ứng với 1 thư mục trên HDD/SSD
    //Trong thư mục này có nhiều file src .cs (.java)
    //file src này chứa class (1 hay nhiều)

    internal class Program
    {

        static void Main(string[] args)
        {
            //getAge();
            //printLyric();
            //gọi hàm static từ class khác:
            //gọi qua tên class chấm trực tiếp không new 
            MusicLibrary.printLyric();

        }
        //các hàm nằm trong class, Main chạy đầu tiên
        //static chơi với static
        static void getAge()
        {
            int yob = 2020;
            int age = 2024 - yob;
            Console.WriteLine("Yob: " + yob + " Age: " + age); //truyền thống ghép chuỗi 
            Console.WriteLine("Yob: {0} Age: {1}", yob, age); //place-holder: thế chỗ
            //                      %d  , yob bên C
            Console.WriteLine($"Yob: {yob} Age: {age}"); //interpolation: phép nội suy nhìn chuỗi đoán biến
        }

        static void printLyric()
        {
            //Console.WriteLine("Tu ay trong toi bung nang ha"); //cw giống sout
            //Console.WriteLine("Mat troi chan ly choi qua tim");
            //Console.WriteLine("Hon toi la mot vuon hoa la");
            //Console.WriteLine("Rat ron huong va ron tieng chim");
            //Ctrl + K + C: comment group | Ctrl + K + U : mở

            //Console.WriteLine("Tu ay trong toi bung nang ha \nMat troi chan ly choi qua tim \nHon toi la mot vuon hoa la \nRat ron huong va ron tieng chim");

            //verbatim: Chuổi nguyên bản, có gì in nấy
            //          Khi ta nói về đường dẫn thư mục trên window
            //String filePath = "C:\\news";
            String filePath = @"C:\news";

            Console.WriteLine(@$"{filePath}Tu ay trong toi bung nang ha 
Mat troi chan ly choi qua tim 
Hon toi la mot vuon hoa la 
Rat ron huong va ron tieng chim");
            Console.WriteLine(@"Tu ay trong toi bung nang ha 
Mat troi chan ly choi qua tim 
Hon toi la mot vuon hoa la 
Rat ron huong va ron tieng chim

<html>
    <body>
        <div></div>
    </body>
</html>
Liệu mai sau phai vội mau không bước bên cạnh nhau (bên cạnh nhau)
Thì ta có đau? (Thì ta có đau? Có đau?)
Đôi mi nhòe phai ai sẽ lau?
Ai sẽ đến lau nỗi đau này?
Vô tâm quay lưng ta thờ ơ, lạnh lùng băng giá như vậy sao? (Vậy sao? Vậy sao?)
Vờ không biết nhau (không biết nhau, không biết nhau)
Lặng im băng qua chẳng nói một lời (chẳng nói một lời)
Ooh-whoa-ooh-whoa-oh-oh-oh (yeah, eh)
Rồi niềm đau có chóng quên? (Hah-ah-ooh-ah)
Hay càng quên càng nhớ thêm, vấn vương vết thương lòng xót xa?
Đừng như con nít (con nít), từng mặn nồng say đắm say (oh-oh-ah)
Cớ sao khi chia tay (chia tay), ta xa lạ đến kì lạ? (Ta xa lạ đến kì lạ)
Ai dám nói trước sau này (trước sau này)
Chẳng ai biết trước tương lai sau này (sau này)
Tình yêu đâu biết mai này có vẹn nguyên
Còn nguyên như lời ta đã hứa trước đây? (Ta đã hứa trước đây)
Dẫu cho giông tố xô xa rời (xa rời)
Còn mãi những điều đẹp đẽ say đắm một thời (một thời)
Nụ cười và giọt nước mắt rơi từng trao cùng ta
Nhìn lại về phía mặt trời (phía mặt trời)
Ta về phía mặt trời (phía mặt trời)
Yah, yah
Tương lai ngày mai ai nào hay (whoa)
Yêu thương rồi buông đôi bàn tay (whoa)
Mong manh đường duyên như vận may
Chia ly, hợp tan nhanh còn hơn mây trời bay (yah)
Quên nhau, vờ như chưa từng quen (sao quên?)
Quên luôn mặt, quên luôn cả tên (sao quên?)
Quên đi, làm sao mà đòi quên?
Khi câu thề xưa vẫn vẹn nguyên nên đừng cố quên (ah)
Vấn vương cũng chẳng sao mà (whoa), nhớ nhung cũng chẳng sao mà (whoa)
Đớn đau cũng chẳng sao mà (whoa)
Dù có đắng cay ta cũng chẳng sao đâu
Chân thành khi còn bên nhau và trân trọng hơn mỗi phút giây (hơn mỗi phút giây)
Thành thật bên nhau mỗi phút giây (yeah, yeah)
Rồi niềm đau có chóng quên? (Hah-ah-ooh-ah)
Hay càng quên càng nhớ thêm, vấn vương vết thương lòng xót xa? (Whoa-oh-oh-oh-oh-oh-oh)
Đừng như con nít (con nít), từng mặn nồng say đắm say (oh-oh-ah)
Cớ sao khi chia tay (chia tay), ta xa lạ đến kì lạ? (Ta xa lạ đến kì lạ, hah)
Ai dám nói trước sau này (trước sau này)
Chẳng ai biết trước tương lai sau này (sau này)
Tình yêu đâu biết mai này có vẹn nguyên
Còn nguyên như lời ta đã hứa trước đây? (Ta đã hứa trước đây)
Dẫu cho giông tố xô xa rời (xa rời)
Còn mãi những điều đẹp đẽ say đắm một thời (một thời)
Nụ cười và giọt nước mắt rơi từng trao cùng ta
Nhìn lại về phía mặt trời
Ai dám nói trước sau này
Chẳng ai biết trước tương lai (trước tương lai, trước tương lai)
Tình yêu đâu biết mai này có vẹn nguyên như lời ta đã hứa trước đây?
Dẫu cho giông tố xô xa rời
Dù cho bão giông chia lìa ta (dù cho bão giông chia lìa ta)
Nụ cười và giọt nước mắt rơi
Để trao tặng em một cơn mơ, y-yah, y-yah (y-yah, y-yah, hah)
Ai dám nói trước sau này (sống bên nhau mà)
Chẳng ai biết trước tương lai sau này (sống bên nhau mà)
Tình yêu đâu biết mai này có vẹn nguyên
Còn nguyên như lời ta đã hứa trước đây? (Ta đã hứa trước đây)
Dẫu cho giông tố xô xa rời (giữ yêu thương kia)
Còn mãi những điều đẹp đẽ say đắm một thời (giữ yêu thương kia)
Nụ cười và giọt nước mắt rơi từng trao cùng ta
Nhìn lại về phía mặt trời (mặt trời)
Ta về phía mặt trời (phía mặt trời, phía mặt trời, phía mặt trời)
");
        }
    }
}
