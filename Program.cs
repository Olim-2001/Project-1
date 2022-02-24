using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("name=");
            string name,age;
            name = Console.ReadLine();
            age= Console.ReadLine();
            Console.WriteLine("name=" + name);
            Console.WriteLine( age);

            //***************************************************************************
            /*Double x1,x2,y1,y2, k;
            x1= Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            k = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2-y1),2));
            Console.WriteLine("резултат=" + k);
            Console.ReadLine(); */
            //***********************************************************************************
            /*int x, k, j,p;
            x= Convert.ToInt32(Console.ReadLine());
            k = x % 10;
            j = x / 10;
            p = k* 10 + j;
            Console.WriteLine("резултат=" + p);
            Console.ReadLine(); */
            //***********************************************************************
            /* int n, k;
             n = Convert.ToInt32(Console.ReadLine());
             k = n / 60;
             Console.WriteLine("резултат=" + k);
             Console.ReadLine(); */
            //************************************************************
            //int k;
            //k = Convert.ToInt16(Console.ReadLine());
            
            //while (k > 7)
            //{
            //    k -= 7;
            
            //}

            //switch (k) { 

            //    case 1:Console.WriteLine("Пониделник"+k);break;
            //    case 2: Console.WriteLine("Вторник"+k);    break;
            //    case 3:Console.WriteLine("Среда"+k ); break;
            //    case 4: Console.WriteLine("Четверг" +k); break;
            //    case 5: Console.WriteLine("пятница" +k); break;
            //    case 6: Console.WriteLine("субота" +k); break;
            //    case 7: Console.WriteLine("воскрессение"+k ); break;
                  
            //    }
            
        }
    }
}
