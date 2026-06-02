namespace _2_семестр_финал
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassTask1.Student s1 = new ClassTask1.Student("Sidorov", 19);
            Console.WriteLine(s1.Surname);
            Console.WriteLine(s1.Age);

            ClassTask1.Student s2 = new ClassTask1.Student("Petrov", 29);
        }
    }
}
// 1 УРОК
//класс = шаблон
//объект/экземпляр класса - конкретный пример (студент, ученик, работник)
//!!не трогать шапку в лабораторной!! + все, что жирным - public
//не забыть раскомментить тесты (и не забыть и в гитхабе это сделать)
//проект - добавление нового элемента
//internal менять на public
//поля - как переменные, но всегда private
//свойства - накидка на поля (get и set) (должны быть public, чтобы пользователь мог их получить)
//конструктор 
//
//2 УРОК
//проект - добавить уже существующий элемент (должен быть одинаковый namespace)
//
//
//