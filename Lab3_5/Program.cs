using Lab3_5;

class Program
{
    public static void Main(string[] args)
    {
        //tao doi tuong
        StudentModel action = new StudentModel();
        List<Student> listall = action.GetStudent();
        Console.WriteLine("Danh sach sinh vien");
        foreach(var item in listall)
        {
            item.Display();
        }
        Console.WriteLine("Danh sach sinh vien theo id:");
        Student st = action.GetStudent(2);
        st.Display();
        Console.WriteLine("Danh sach sinh vien theo do tuoi tu 25-30:");
        List<Student> listage = action.GetStudent(25, 30);
        foreach (var item in listage)
        {
            item.Display();
        }
    }
}