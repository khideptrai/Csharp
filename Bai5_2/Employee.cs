class Employee
{
    private int id;
    private string name;
    private int age;

    public Employee() 
    {
        Id = 0;
        Name = "";
        Age = 0;
    }
    public Employee(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }

    public override string ToString()
    {
        return "Id: " + Id + " Name: " + Name + " Age: " + Age;
    }
}
