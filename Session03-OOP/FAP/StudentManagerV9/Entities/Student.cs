using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV9.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //tự động C# sinh ra _backing field ngầm cho property
        //Java không có, hãng thứ 3 độ style này: dependency tên là lombok

        //Quên cú pháp: Prop tab
        public int MyProperty { get; set; }
    }
}
