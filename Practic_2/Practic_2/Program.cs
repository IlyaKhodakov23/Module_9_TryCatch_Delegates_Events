namespace Practic_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Объявляем класс
            SortSurnames sortSurnames = new SortSurnames();
            string[] arrSurnames = { "Андреев", "Хомяков", "Орлов", "Квашин", "Ястребов" };
            //Добавляем в событие делегирующий метод
            sortSurnames.SortSurnamesEvent += ShowSortNum;
            //Вызываем метод
            sortSurnames.SortSurname(arrSurnames);
        }
        //Создаем метод, который в дальнейшем будем делегировать в метод класса сортировки
        //Данный метод принимает на вход значение и выдает какая сортировка была проведена
        static void ShowSortNum (int sort)
        {
            switch (sort)
            {
                case 1: Console.WriteLine("Список отсортирован по возрастанию");
                    break;
                case 2: Console.WriteLine("Список отсортирован по убыванию");
                    break ;
            }
        }
    //Создаем класс с делегатом событием и методом сортировки
    public class SortSurnames
    {
        //Создаем Делегат
        public delegate void SortSurnamesDelegate(int sort);
        //Создаем событие
        public event SortSurnamesDelegate SortSurnamesEvent;
        //Создаем метод сортировки, который на вход принимает фамилии
        public void SortSurname(string[] Surnames)
        {
            Console.WriteLine("Введите 1 или 2 для сортировки по возрастанию или убыванию соответственно");
            int sort = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (sort == 1)
                {
                    //Если ввели 1, то сортируем по возрастанию
                    IEnumerable<string> surnames = from Surname in Surnames orderby Surname.Substring(0, 1) select Surname;
                    foreach (string surname in surnames)
                    {
                        Console.WriteLine(surname);
                    }
                }
                //Если 2, то по убыванию
                else if (sort == 2)
                {
                    IEnumerable<string> surnames = from Surname in Surnames orderby Surname.Substring(0, 1) descending select Surname;
                    foreach (string surname in surnames)
                    {
                        Console.WriteLine(surname);
                    }
                }
                //Иначе создаем свое исключение
                else throw new Exception("Введено неверное значение");
                //В конце работы программы вызываем делегирующее событие
                ShowSort(sort);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                
        }
            //Создаем виртуальный метод, который вызывает событие - фишка в том, что мы в итоге не знаем где этот метод, как реализован
            //А лишь знаем, что подается на вход и что мы получим уведомление о событии
            protected virtual void ShowSort (int sort)
            {
                SortSurnamesEvent?.Invoke(sort);
            }
    }
    }
}