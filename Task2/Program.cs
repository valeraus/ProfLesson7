namespace Task2
{
    /*
    Створіть клас і застосуйте до його методів атрибут Obsolete спочатку у формі, що просто виводить попередження, 
    а потім у формі, що перешкоджає компіляції. 
    Продемонструйте роботу атрибута з прикладу виклику даних методів.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            instance.ObsoleteMessage();

            // instance.ObsoleteError();
        }
    }
}
