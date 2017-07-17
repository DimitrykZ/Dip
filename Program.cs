using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab3kontr
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true) 
            {
                Console.WriteLine("Выберите вариант игры 1 или 2, для выхода 3");
                int var = int.Parse(Console.ReadLine());

                if (var == 3) break;

                Console.WriteLine("Сколько выстрелов хотите сделать?");
                int n = int.Parse(Console.ReadLine());

                int sum = 0;
                double x, y, z;

                for (int i = 0; i < n; i++)
                {


                    
                    Console.WriteLine("Введите координаты выстрела");
                    Console.Write("X=");
                    x = double.Parse(Console.ReadLine());
                    Console.Write("Y=");
                    y = double.Parse(Console.ReadLine());

                    z = Math.Sqrt(x * x + y * y);

                    if (z <= 1 ) sum += 10;
                    else if (z <= 2) sum += 5;
                    else if (z <= 3 && var == 2) sum += 1;


                }

                Console.WriteLine("Общая сумма очков = {0}", sum);
            } 
        }
    }
}
