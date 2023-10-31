using DongVat.AnTap;
using DongVat.AnThit;

namespace DongVat
{
    public class Animal
    {
        public int Id;
        public string Name;
        public float Weight;

        public Animal(int id, string name, float weight)
        {
            Id = id;
            Name = name;
            Weight = weight;
        }
    }
    namespace AnCo
    {
        public class Bo : Animal
        {
            public Bo(int id, string name, float weight) : base(id, name, weight)
            {
            }
        }
        public class Trau : Animal
        {
            public Trau(int id, string name, float weight) : base(id, name, weight)
            {
            }
        }
        public class De : Animal
        {
            public De(int id, string name, float weight) : base(id, name, weight)
            {
            }
        }
    }
    namespace AnThit 
    {
        public class CaSau : Animal
        {
            public CaSau(int id, string name, float weight) : base(id, name, weight)
            {
            }
        }
        public class Ho : Animal
        {
            public Ho(int id, string name, float weight) : base(id, name, weight)
            {
            }
        }
        public class SuTu : Animal
        {
            public SuTu(int id, string name, float weight) : base(id, name, weight)
            {
            }
        }
    }
    namespace AnTap
    {
        public class Dog : Animal
        {
            public Dog(int id, string name, float weight) : base(id, name, weight)
            {
            }
        }
    }
    public class Program
    {
        public void Main(string[] args)
        {
            Dog dog_1 = new Dog(1,"Vang",50);
            SuTu suTu = new SuTu(2, "Su Tu", 70);

        }
    }
}