using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV3.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;   
        private int _yob;
        private double _gpa;

        public Student(string id)
        {
            _id = id;
        }

        public override string ToString() => $"ID: {_id} | Name: {_name} | Yob: {_yob} | Gpa: {_yob}";


    }
}
