using AutoMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper練習
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.name = "Tom";
            student.age = 18;
            student.schoolName = "建中";
            student.studentId = "123";
            student.className = "二丙";
            student.stress = "新北市";

            List<Student> studentList = new List<Student>();
            studentList.Add(student);


            //User user = Mapper.Map<Student, User>(student, cfg =>
            //{
            //    cfg.ForMember(x => x.School_Name, y => y.MapFrom(o => o.schoolName))
            //       .ForMember(x => x.Class_Name, y => y.MapFrom(o => o.className));
            //});


            User user = Mapper.Map<Student, User, MappingProfile>(student);


        }
    }
}
