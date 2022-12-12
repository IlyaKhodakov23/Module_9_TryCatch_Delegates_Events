namespace Lesson_9._3_Delegate
{
    internal class Program
    {
        //Задание 9.3.2
        //Создайте консольное приложение, в котором есть функция, принимающая на вход два числа int, и возвращающая результат int вычитания второго числа из первого.
        //Вызовите эту функцию в классе Main при помощи делегата и отобразите результат в консольном сообщении.
        //Задание 9.3.3
        //Используя ваше приложение из задания 9.3.2, реализуйте вызов делегата двумя разными способами.
        //Задание 9.3.4
        //Реализуйте консольное приложение, в котором существует две функции: первая функция вычитает второе число из первого и отображает результат в консольном сообщении,
        //вторая функция складывает два числа и отображает результат в консоли.Реализуйте вызов этих двух функций через многоадресный делегат.
        public delegate int MinusDelegate(int a, int b);
        public delegate void OperationsDelegate(int a, int b);
        static void Main(string[] args)
        {
            MinusDelegate minusDelegate = Minus;
            //int result = minusDelegate.Invoke(30, 100); 1 способ
            int result = minusDelegate(30, 100); // 2 способ
            //Console.WriteLine(result);

            OperationsDelegate operationsDelegate = Minus2;
            operationsDelegate += Plus; //добавление
            operationsDelegate -= Plus; //удаление делегата
            operationsDelegate.Invoke(100, 30);

            //Задание 9.3.8
            //Используя консольное решение из предыдущей задачи 9.3.7, реализуйте применение шаблонных делегатов, описанных выше.
            Func<int, int, int> minusDelegate2 = Minus;
            int resultminus = minusDelegate2.Invoke(50, 10);
            Action<int, int> minusDelegate3 = Plus;
            minusDelegate3(300, 300);
        }

        static int Minus(int a, int b)
        {
            return b - a;
        }
        static void Plus(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Minus2(int a, int b)
        {
            Console.WriteLine(b - a);
        }
    }

}