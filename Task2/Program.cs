using System;

namespace Task2
{
    class Program
    {
        // Создайте консольное приложение, в котором будет происходить
        // сортировка списка фамилий из пяти человек.Сортировка должна происходить
        // при помощи события.Сортировка происходит при введении пользователем
        // либо числа 1 (сортировка А-Я), либо числа 2 (сортировка Я-А).

        //Дополнительно реализуйте проверку введённых данных от пользователя
        //через конструкцию TryCatchFinally с использованием собственного типа исключения.
        static void Main(string[] args)
        {
            NumberRead numberRead = new NumberRead();
            numberRead.NumberEnteredEvent += ShowNumber;

            while (true)
            {
                try
                {
                    numberRead.Read();
                }
                catch(FormatException)
                {
                    Console.WriteLine("Введено некорректное значение");
                }
            }
        }

        static void ShowNumber(int number)
        {
            switch (number)
            {
                case 1: Console.WriteLine("Введено значение: 1"); break;
                case 2: Console.WriteLine("Введено значение: 2"); break;
            }
        }
        class NumberRead
        {
            public delegate void NumberEnteredDelegate(int number);
            public event NumberEnteredDelegate NumberEnteredEvent;

            public void Read()
            {
                Console.WriteLine();
                Console.WriteLine("Введите значение 1 или 2");

                int number = Convert.ToInt32(Console.ReadLine());
                if (number != 1 && number != 2) throw new FormatException();
                NumberEntered(number);
            }

            protected virtual void NumberEntered(int number)
            {
                NumberEnteredEvent?.Invoke(number);
            }
        }
    }
}
