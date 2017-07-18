using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Имю и Фамилию:");
            string name = Console.ReadLine();
            //Console.WriteLine("Введите Фамилию:");
            string fname = Console.ReadLine();
            Console.WriteLine("Введитe возраст:");
            string age = Console.ReadLine();



            Console.WriteLine("Ваше Имя и  Фамилия:");
            Console.WriteLine(name);
            Console.WriteLine(" ");
            Console.WriteLine(fname);
            Console.WriteLine("Ваш возраст:");
            Console.WriteLine(age);



            Console.WriteLine("Введите 1-Число:");
            String num1String = Console.ReadLine();
            int num1Int = Int32.Parse(num1String);

            Console.WriteLine("Введите 2-Число:");
            String num2String = Console.ReadLine();
            int num2Int = Int32.Parse(num2String);

            Console.Write(num1Int);
            num1Int = num1Int * num2Int;
            Console.Write(" * ");
            Console.WriteLine(num2Int);
            Console.Write(" равно: ");
            Console.WriteLine(num1Int);

            Console.ReadLine();    
        }
    }
}
