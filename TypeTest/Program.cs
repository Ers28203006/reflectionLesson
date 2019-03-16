using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace TypeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1.С помощью рефлексии вызвать метод Substring класса String и извлечь из строки подстроку заданного размера.");

            string str = "Древние греки придумали Олимпийские игры, пока вели одну из своих " +
              "нескончаемых войн.";

            Type type = typeof(String);

            MethodInfo substring = type.GetMethod("Substring",
                new Type[] { typeof(int), typeof(int) });

            Object result = substring.Invoke(str, new Object[] { 0, 40 });
            Console.WriteLine("{0}\n\"{1}\".\n\n", substring, result);

            Console.WriteLine(" 2.Получить список конструкторов класса List<T>");
            type = typeof(List<>);
            foreach (ConstructorInfo ctor in type.GetConstructors())
            {
                Console.WriteLine(ctor);
            }

            Console.WriteLine("\n\n1.С помощью рефлексии получить список методов класса Console и вывести на экран.");
            type = typeof(Console);
            foreach (MethodInfo method in type.GetMethods())
            {
                Console.WriteLine(method);
            }

            Console.WriteLine("\n\n2.Описать класс с несколькими свойствами. Создать экземпляр класса и инициализировать его свойства.\n"+ 
            "С помощью рефлексии получить свойства и их значения из созданного экземпляра класса. \nВывести полученные значения на экран");

            Student student = new Student("Алеша", "Попович", 25);
            type = typeof(Student);
            Console.WriteLine("Свойства класса: ");
            foreach (PropertyInfo property in type.GetProperties())
            {
                Console.Write(property.Name);
                Console.WriteLine(": "+property.GetValue(student));
            }
            Console.ReadLine();
        }

    }
}
