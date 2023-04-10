using System;

namespace Task2
{
    internal class MyClass
    {
        [Obsolete("Метод устарел")]
        public void ObsoleteMessage()
        {
            Console.WriteLine("Hello world!");
        }

        [Obsolete("Метод не используеться", true)]
        public void ObsoleteError()
        {
            Console.WriteLine("Hello world!");
        }

    }
}