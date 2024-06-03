using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV6.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private int _yob;  
        private double _gpa;

        //get set bthg
        public String GetName () => _name; 
        public void SetName (String name) => _name = name;

        //public int getyob() => _yob;
        //public void setyob(int yob) => _yob = yob;
        
        //get set bản mới:
        public int Yob //đóng 2 vai vừa get vừa set
        {
            get => _yob;
            set => _yob = value;
        }//value ứng với tham  số đầu vào của hàm set yob truyền thống
        //là cách viết gộp của hàm get() và set truyền thống

        //dùng ntn?
        //.Yob là get
        //.Yob = 2005 là set 

        public double Gpa //Property of object chứ không phải attribute/field
        {
            get => _gpa; //_gpa gọi là backing field, biến chống lưng đằng sau set() get()
            set => _gpa = value;
        }
    }
}
