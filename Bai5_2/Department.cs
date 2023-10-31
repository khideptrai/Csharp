class Department
{
    public string name;
    Employee[] employees;
    public Department() { }
    public Department(string Name,int Capacity)
    {
        this.Name = Name;
        employees = new Employee[Capacity];
    }
    public string Name
    {
        get { return name; }
        set
        {
            if (value == null)
                throw new ArgumentNullException();
            name = value;
        }
    }
    public Employee this[int index]
    {
        get
        {
            if (index < 0 || index > employees.Length - 1)
                throw new ArgumentOutOfRangeException();
            return employees[index];
        }
        set
        {
            if (index < 0 || index > employees.Length - 1)
                throw new ArgumentOutOfRangeException();
            employees[index] = value;
        }
    }
}
