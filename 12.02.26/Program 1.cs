namespace First10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1.Student s1 = new Task1.Student("Serov", 8);
            s1.Print();

            Task1.Student s2 = new Task1.Student("Ivanov", 18);

            Task1.Student s3 = new Task1.Student("Puhlyak", 7);

            Task1.Student s4 = new Task1.Student("Thai Van", 18);

            s2.Print();

            s1.Study(5);
            s1.Study(2);
            s1.Study(10);
            s1.Print();

            s2.Study(4);
            s2.Print();
            s1.Marks[1] = 4;
            s2.Marks[2] = 5;
            s3.Marks[1] = 4;
            s4.Marks[2] = 5;

            Task1.Student[] students = { s1, s2, s3, s4 };
            for(int i = 0; i < students.Length; i++)
            {
                students[i].Print();
            }
            Console.WriteLine(Task1.Student.Count);
        }

      
    }
}
