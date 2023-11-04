using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();
        ht.Add(1, "Monday");
        ht.Add(2, "Tuesday");
        ht.Add(3, "Wednesday");
        ht.Add(4, "Thursday");
        ht.Add(5, "Friday");
        ht.Add(6, "Saturday");
        ht.Add(7, "Sunday");
        ht.Add(8, "");
        if (!ht.ContainsValue("Tuesday"))
        {
            Console.WriteLine("Khong tim thay Tueday");
        }
        foreach(DictionaryEntry de  in ht)
        {
            Console.WriteLine($"Key: {de.Key} Value: {de.Value}");
        }
    }
}