using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV4.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        //Tạo construct default

        //public Student()
        //{
        //    //không nhận gì vào không làm gì cả
        //}
        //
        //cách gõ nhanh ctor
        public Student()
        {
            
        }
        //nó có quyền sống chung với các constructor khác 
    }
}
