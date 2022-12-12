namespace Practic_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создаю свое исключение
            Exception MyException = new Exception("Новое исключение");
            //Создаю массив исключений
            Exception[] exceptionsArr = { new RankException(), new ArgumentOutOfRangeException(), new ArgumentException(), new FormatException(), MyException };
            //Прохожусь по массиву и вызываю исключения
            foreach (Exception ex in exceptionsArr)
            {
                try
                {
                    throw ex;
                }
                catch (Exception e)
                {
                    //Для каждого исключения вызываю текст исключения
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}