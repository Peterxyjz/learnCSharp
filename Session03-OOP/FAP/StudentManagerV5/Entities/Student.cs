//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StudentManagerV5.Entities
//{
//    public class Student
//    {
//        private string _id;
//        private string _name;   
//        private int _yob;
//        private double _gpa;

//        //có nhiều cách đổ vật liệu vào, nhiều cách điền form(thông tin fill, và info bỏ trống)

//        public Student() //photo form trống, giữ điền sau
//        {
//        }

//        public Student(string id, string name, int yob, double gpa)
//        {
//            _id = id;
//            _name = name;
//            _yob = yob;
//            _gpa = gpa;
//        }

//        //giao tiếp ra thế giới bên ngoài với những infor của mình, get và set
//        public string GetName() => _name; 
//        public int GetYob() => _yob; 
//        public double GetGpa() => _gpa;

//        //chỉnh sửa info của object:
//        public void SetName(string name) => _name = name;
//        public void SetYob(int yob) => _yob = yob;
//        public void SetGpa(double gpa) => _gpa = gpa;

//        public override string ToString() => $"ID: {_id} | Name: {_name} | Yob: {_yob} | Gpa: {_gpa}";

//        public void ShowProfile() => Console.WriteLine($"ID: {_id} | Name: {_name} | Yob: {_yob} | Gpa: {_gpa}");
//    }
//}

//Lập trình OOP - Object Oriented Paradigm/ Programming
//Lập trình hướng đối tượng
//1. Nhận diện bài toán, quanh ta, các object
//  Object : cái cụ thể, mô tả được bằng lời dài bao gồm:
//  * Đặc điểm/atribute/ state - tĩnh
//      - ID, Năm Sinh, địa chỉ,...
//  * Hành vi/ Behavior/ method/ function - động
//      - Hỏi tuổi GetAge()...
//2. Gom nhóm chia nhóm đối tượng thành các nhóm riêng
//  Nhóm/Class (Classify - Verb) dựa theo đặc điểm tương đồng của các object
//  ta có class student, lecture,...
//  class như cái khuôn, form, template, blueprint
   
//3. Từ class sẽ ra object trở lại
//  Ngoài đời ta clone/photo - new cái khuôn, template
//  đổ value vào khuôn/form - constructor

//4. Ta có constructor để clone ra object, ta sẽ nhìn thấy object và chỉnh sửa
//      - Thấy, nhìn được, xem được - getter
//      - Chỉnh sửa - setter
//5. Ta muốn show hết info có thể, vd: ta clone 1 account FB
//      - ShowInfor();
//      - ToString
//6. Các hành động khác nếu cần của 1 object

//Lập trình oop chính là lập trình trên template, khuôn, sau đó áp dụng chung cho mọi object clone từ khuôn
//Kỹ thuật tổ chức quản lí info qua OOP

