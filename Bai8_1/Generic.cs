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