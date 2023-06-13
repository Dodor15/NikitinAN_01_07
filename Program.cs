using System;

namespace NikitinAN_01_07
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Напишилте колличество жил кабеля");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите диаметр");
            double diametr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("есть ли оплетка?\n" +
                "1-если да\n" +
                "0-если нет");
            int check = Convert.ToInt32(Console.ReadLine());
            bool wire = false;
            if (check == 1)
            {
                wire = true;
            } else if (check == 0)
            {

                wire = false;
            }
                WiresP wp = new WiresP(count, diametr, wire);
            
            Console.WriteLine("получилось: "+wp.Q());
        }
    }
}
