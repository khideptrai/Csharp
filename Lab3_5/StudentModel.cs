using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_5
{
    class StudentModel
    {
        List<Student> listStudent;
        public StudentModel()
        {
            this.listStudent = new List<Student>
            {
                new Student(){Id = 1,Name="Dung",Age = 20},
                new Student(){Id = 2,Name = "Tuan",Age=25},
                new Student(){Id = 3,Name ="Ha",Age=18},
                new Student(){Id = 4,Name = "Anh",Age = 30},
                new Student(){Id =5,Name ="Long",Age = 24},
            };

        }
        #region các phương thức overloading
        //phương thức trả về danh sách sinh viên
        public List<Student> GetStudent()
        {
            return listStudent;
        }
        //phuong thuc tra ve sinh vien theo id
        public Student GetStudent(int id)
        {
            Student st = null;
            foreach (var item in listStudent)
            {
                if(item.Id == id)
                {
                    st = item;
                }
            }
            return st;
        }
        public List<Student>GetStudent(int x,int y)
        {
            List<Student> result = new List<Student>();
            foreach(var item in listStudent)
            {
                if(item.Age >= x&& item.Age <= y)
                {
                    result.Add(item);
                }
            }
            return result;
        }
        #endregion
    }
}
