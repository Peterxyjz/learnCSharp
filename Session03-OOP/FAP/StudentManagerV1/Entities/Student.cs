using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV1.Entities
{
    internal class Student
    {
        //class sẽ chứa các đặc điểm và hành vi của đối tượng được tạo ra từ khuôn này
        //đặc điểm là thứ mô tả tính chất thường là tĩnh, nhận dạng của object thuộc class/nhóm này - gọi là biến field, attribute
        //hành vi: động, nói về hành động, xử lí, tính toán của 1 object 
        //          gọi là hàm - method function
        //  hàm + biến -> gọi là members of class
        private string _id; //quy ước: field của obj trong class dùng con Lạc Đà + _ đứng đầu
        private string _name;
        private int _yob;
        private double _gpa;

        //ta cần contrusctor: để đổ value vào 
        //nó là 1 hàm dùng để dựng ra 1 object 
        //hàm constructor - gã xây dựng xây dựng ra 1 gì đó
        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;   
            _name = name;   
            _yob = yob; 
            _gpa = gpa;
        }

        //nhóm hàm get
        public string GetId()
        {
            return _id;
        }
        public string GetName() => _name;
        public int GetYob() => _yob;
        public double GetGpa() => _gpa;

        //nhóm hàm set: nhóm hàm giúp thay đổi info của 1 object 

        public void SetName(string name) =>  _name = name;
        public void SetYob(int yob) =>  _yob = yob;
        public void SetGpa(double gpa) =>  _gpa = gpa;

        //ta có nhu cầu show hết info trong một số tình huống nào đó, đó là lúc ta có 2 loại hàm
        //hàm printInfor và trả về infor
        public void ShowInfor() 
        {
            Console.WriteLine("Here is my infor: ");
            Console.WriteLine($"ID: {_id} | Name: {_name} | Yob: {_yob} | Gpa: {_gpa}");
        }

        public override string ToString()
        {
            return $"id: {_id} | name: {_name} | yob: {_yob} | gpa: {_gpa}";
        }

    }
}

//Class là cái khuôn dùng để đúc ra các object, bức tượng, món đồ
//class là cái khuôn chứa các đặc điểm chung của các object, nó chứa các chi tiết: lồi lõm, bề mặt, góc cạnh, cần nhận vật liệu vào để hình thành nên bức tượng.
//phần nhận vật liệu đổ vào gọi là phểu - constructor 
// bức tượng được đúc xong người ta nhìn thấy nó, người ta có thể chỉnh sửa: chà nhám,... > Gọi là điều chỉnh bức tượng đã có -set, setting thay đổi trên thứ đã có, vẫn là thứ đó chứ không phải object mới.


