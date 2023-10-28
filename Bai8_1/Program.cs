public class Program
{
    public static void Main(string[] args)
    {
        Generic<int> test = new Generic<int>(10);
        test.Add(1);
        test.Add(20);
        test.Add(30);
        Console.WriteLine(test.Get(1));
        Console.WriteLine(test.Get(2));
        Console.WriteLine(test.Get(30));
    }
}
public class Generic<T>
{
    T[] array;
    int position;
    public Generic(int n)
    {
        array = new T[n];
        position = 0;
    }
    public void Add(T item)
    {
        if(position < array.Length)
        {
            array[position]= item;
            position++;
        }
    }
    public T Get(int index)
    {
        if (index < array.Length)
        {
            return array[index];
        }
        return default(T);
    }
}