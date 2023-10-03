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
}
