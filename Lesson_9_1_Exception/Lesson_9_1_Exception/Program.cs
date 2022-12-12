namespace Lesson_9_1_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 9.1.3
            //Создайте класс исключения Exception и добавьте в свойство Data дату создания исключения.
            Exception exception = new Exception("Произошло исключение");
            exception.Data.Add("Дата создания исключения: ", DateTime.Now);
            //Задание 9.1.4
            //Создайте класс исключения Exception и переопределите его свойство Message, а также свойство HelpLink, добавив в него ссылку на внешний ресурс
            exception.HelpLink = "www.google.com";
        }
    }
}