using System;

namespace Example
{
    class Program
    {
        // Создайте консольное приложение, в котором будет происходить
        // сортировка списка фамилий из пяти человек.Сортировка должна происходить
        // при помощи события.Сортировка происходит при введении пользователем
        // либо числа 1 (сортировка А-Я), либо числа 2 (сортировка Я-А).
        static void Main(string[] args)
        {
            Sort1(Users());
            Console.WriteLine("");
            Sort2(Users());
        }

        public static string[] Users()
        {
            string[] users = new string[5];
            users[0] = "Иванов";
            users[1] = "Петров";
            users[2] = "Обама";
            users[3] = "Сидоров";
            users[4] = "Жириновский";

            return users;
        }
        public static string[] Sort1(string[] users)
        {
            Array.Sort(users);

            foreach (string user in users)
            {
                Console.WriteLine(user);
            }

            return users;
        }
        public static void Sort2(string[] users)
        {
            string[] usersSort = new string[users.Length];

            Array.Sort(users);

            int a = 0;
            for (int i = users.Length - 1; i >= 0; i--)
            {
                usersSort[i] = users[a];
                a++;
            }

            foreach (string user in usersSort)
            {
                Console.WriteLine(user);
            }
        }
    }
}
