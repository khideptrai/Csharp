class Contact
{
    private int id;
    private string firtsname;
    private string lastname;
    private string address;
    private string phone;
    private string email;
    public Contact()
    {

    }
    public Contact(int id, string firtsname, string lastname, string address, string phone, string email)
    {
        this.id = id;
        this.firtsname = firtsname;
        this.lastname = lastname;
        this.address = address;
        this.phone = phone;
        this.email = email;
    }
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public string Firtsname
    {
        get { return firtsname; }
        set { firtsname = value; }
    }
    public string Lastname
    {
        get { return lastname; }
        set { lastname = value; }
    }
    public string Address
    {
        get { return address; }
        set { address = value; }
    }
    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    public void Display()
    {
        Console.WriteLine("Ma so:" + id);
        Console.WriteLine("Ho va ten {0} {1}", firtsname, lastname);
        Console.WriteLine("Dia chi: " + address);
        Console.WriteLine("So dien thoai: " + phone);
        Console.WriteLine("Email: " + email);
    }
}
