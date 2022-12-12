namespace Lesson_9._2_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 9.2.2
            //Создайте консольное решение, в котором реализуйте конструкцию Try / Catch / Finally для обработки исключения ArgumentOutOfRangeException. 
            //В случае исключения отобразите в консоль сообщение об ошибке.
            try
            {
                throw new ArgumentOutOfRangeException("Ошибка");
            }
            catch (Exception ex) when (ex is ArgumentOutOfRangeException)
            {
                Console.WriteLine("Выход за пределы");
            }
            //Задание 9.2.3
            //Создайте консольное решение, в котором реализуйте конструкцию Try / Catch / Finally для обработки исключения RankException.
            //В случае исключения отобразите в консоль тип исключения(через метод GetType()).
            try
            {
                throw new RankException("Ошибка Rank");
            }
            catch (RankException ex)
            {
                Console.WriteLine(ex.GetType);
            }
        }
    }
}