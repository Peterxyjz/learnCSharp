﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV7.Entities
{
    internal class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        public string Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Yob
        {
            get => _yob;
            set => _yob = value;
        }
        public double Gpa
        {
            get => _gpa; 
            set => _gpa = value;
        }

        public override string ToString() => $"ID: {Id}| Name: {Name}| Yob: {Yob}| Gpa: {Gpa}";
   
    }
}
