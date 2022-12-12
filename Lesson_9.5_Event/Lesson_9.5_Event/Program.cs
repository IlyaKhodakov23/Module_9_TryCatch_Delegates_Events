namespace Lesson_9._5_Event
{
    internal class Program //Подписчик события
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; // регистрируем событие - добавляем метод в многоадресный делегат
            //делегат выше обрабатывает событие так как совпадает с подписью Notify 
            bl.StartProcess();
        }

        // перехватчик событий
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Процесс завершён!");
        }
    }

    public delegate void Notify();  // делегат
    public class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted; // событие, подписка

        public void StartProcess()
        {
            Console.WriteLine("Процесс начат!");
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted() //protected virtual method
        {
            ProcessCompleted?.Invoke();
        }
    }
}