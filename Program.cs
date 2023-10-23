using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ExceptionDemo
    {
        public void GenerateException()
        {
            Console.WriteLine("Метод начал выполнение.");
            throw new ApplicationException("Произошла ошибка!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начало программы.");

            try
            {
                ExceptionDemo demo = new ExceptionDemo();
                CallGenerateException(demo);
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Завершение программы.");
            }

        }

        public static void CallGenerateException(ExceptionDemo demo)
        {
            Console.WriteLine("Вызываем метод GenerateException() из CallGenerateException().");
            demo.GenerateException();
        }
    }
}
