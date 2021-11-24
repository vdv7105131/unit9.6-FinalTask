using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        //Создайте свой тип исключения.

        //Сделайте массив из пяти различных видов исключений, включая собственный тип исключения.
        //Реализуйте конструкцию TryCatchFinally, в которой будет итерация на каждый тип исключения (блок finally по желанию).

        //В блоке catch выведите в консольном сообщении текст исключения.

        static void Method1()
        {
            try
            {
                object[] arrayException = { };
                arrayException[0] = new ArgumentNullException();
                arrayException[1] = new RankException();
                arrayException[2] = new DivideByZeroException();
                arrayException[3] = new InvalidOperationException();
                arrayException[4] = new NotImplementedException();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (RankException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Read();
            }
        }
    }
}
