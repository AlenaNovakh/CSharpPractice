namespace практика
{
    public class Animals
    {
        protected string _name;
        protected int _age;
        public string Name => _name;
        public int Age =>_age;
        public Animals(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public virtual void Method() //метод будет переопределен
        {
            Console.WriteLine("Method in class Animal");
        }
        public void Print()
        {
            Console.WriteLine($"Name: {_name}, Age: {_age}");
        }
    }
    public class Bobiki : Animals
    {
        private string _breed;
        private bool _isValid;
        public string Breed => _breed;
        public Bobiki(string  name, int age, string breed) : base(name, age)
        {
            _breed = breed;
            _isValid = true;
        }
        public Bobiki(string name, int age, string breed, bool isValid) : this(name, age, breed)
        {
            _isValid = isValid;
        }
        public override void Method()
        {
            base.Method();
            Console.WriteLine("Method in class Bobiki");
        }
        public new void Print() //скрытый
        {
            Console.WriteLine($"Name: {_name}, Age: {_age}, Breed: {_breed}");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Animals turtle = new Animals("Pavel", 154); //В кого вырастает череПашка? В череПавла)
            Console.WriteLine(turtle.Name);
            turtle.Print();
            turtle.Method();
            Bobiki dog = new Bobiki("Baton", 2, "corgi");
            dog.Print();
            dog.Method();
            Animals ghostDog = new Bobiki("Ghost Doggy", 3, "dead сhihuahua");
            ghostDog.Print(); 
            ghostDog.Method();
            Animals[] pets = new Animals[3];
            pets[0] = turtle;
            pets[1] = dog;
            pets[2] = ghostDog;
            if (pets[2] is Bobiki)
            {
                Bobiki pet = pets[2] as Bobiki;
                Console.WriteLine(pet.Breed);
            }
            Bobiki doggy = pets[0] as Bobiki;
            if (doggy != null)
            {
                Console.WriteLine(doggy.Age);
            }
        }
    }
}
//структура - это запечатанный класс