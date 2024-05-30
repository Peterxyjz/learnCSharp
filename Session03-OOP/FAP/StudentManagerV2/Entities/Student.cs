using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }

        public override string ToString()
        {
            return $"Id: {_id} | Name: {_name} | Yob: {_yob} | Gpa: {_gpa}";
        }
        //ctrl . hoặc phải chuột để general constructor
        //Một cái khuông có thể có nhiều cách đúc khác nhau 
        // có nhiều đường vật liệu đi vào ứng với class ==> có nhiều constructor
        //bao nhiêu constructor bấy nhiêu cách new
        //nguyên tắc của hàm set: đưa value bên ngoài đề vào default value
        //Biến ngoài đề value vào biến bên trong
        public void SetYob(int yob) => _yob = yob;
        public void SetGpa(double gpa) => _gpa = gpa;


    }
}
