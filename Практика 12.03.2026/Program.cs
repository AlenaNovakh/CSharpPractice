namespace гитхаб
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //невозможно создать элемент абстрактного класса
            Animal Timosha = new Cat(1);
        }
    }
    public abstract class Animal
    {
        private int _id;
        private string _breed;
        public abstract string Type { get; } // абстрактное св-во
        public Animal(int id)
        {
            _id = id;
        }
        public abstract void Voice(); //без фигурных скобок, чтобы у наследников будет свои
        public virtual void Print()
        {
            Console.WriteLine("Animal ID" + _id);
        }
        public abstract void Breed()
        {
            Console.WriteLine("Animal breed" + _breed);
        }
    }
    public class Cat : Animal
    {
        public override string Type => "Кошка";
        public Cat(int id) : base(id) { }
        public override void Voice() //не забыть override
        {
            Console.WriteLine("Meow");
        }
        public new void Breed()
        {

        }
    }
}
