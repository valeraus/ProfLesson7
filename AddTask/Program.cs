﻿using System;

namespace AddTask
{
    /*
    Створіть атрибут користувача AccessLevelAttribute, який дозволяє визначити рівень доступу користувача до системи. 
    Сформуйте склад співробітників певної фірми як набору класів, наприклад, Manager, Programmer, Director. 
    За допомогою атрибута AccessLevelAttribute розподіліть рівні доступу персоналу 
    та відобразіть на екрані реакцію системи на спробу кожного співробітника отримати доступ до захищеної секції.
     */
    enum AccessLevelControl
    {
        FullControl, MediumControl, LowControl
    }

    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    sealed class AccessLevelAttribute : Attribute
    {
        readonly AccessLevelControl accessLevel;

        public AccessLevelAttribute(AccessLevelControl accessLevel)
        {
            this.accessLevel = accessLevel;
        }

        public AccessLevelControl AccessLevel
        {
            get { return accessLevel; }
        }
    }

    class Employee
    {

    }

    [AccessLevel(AccessLevelControl.LowControl)]
    class Manager : Employee
    {

    }

    [AccessLevel(AccessLevelControl.MediumControl)]
    class Programmer : Employee
    {

    }

    [AccessLevel(AccessLevelControl.FullControl)]
    class Director : Employee
    {

    }

    class Program
    {
        static void ProtectedSection(Employee emp)
        {
            Type employee = emp.GetType();
            object[] attribute = employee.GetCustomAttributes(typeof(AccessLevelAttribute), false);

            if (attribute.Length == 0)
            {
                return;
            }

            foreach (AccessLevelAttribute item in attribute)
            {
                Console.WriteLine(item.AccessLevel);
            }
        }

        static void Main()
        {
            Employee[] employee = new Employee[] { new Manager(), new Programmer(), new Director() };

            foreach (var emp in employee)
            {
                ProtectedSection(emp);
            }

            Console.ReadKey();
        }
    }
}
