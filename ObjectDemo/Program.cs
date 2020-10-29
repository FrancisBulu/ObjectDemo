using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Object
            //object obj = new object;
            //obj.ToString;

            //int x = 10;
            //decimal d = 102.5m;
            //Console.WriteLine(d.ToString()); //enkel tonene op dat moment, als string, maar de variabel biijft altijd decimal
            //Console.WriteLine(x.ToString()); // method om iets te converteren naar string
            #endregion

            int x = 10; // in deze gevaal, liever "byte" gebruiken ipv int --> byte b = 10 omdat het nummer zeer klein is
            byte b = 10;
            int pnumber = 31212122;
            long l = pnumber;
            //b = (byte)pnummber;
            decimal d = 10.25m;
            decimal d1 = 0;
            //ReturnValueNameAttribute dataype naar object -> boxing
            object o = x; // boxing
            object obj = 50; // boxing
            
            x = (int)obj; // casten als integer -> (int) // dat is unboxing // een object naar een datatype brengen -> unboxing // kost veel tijd
            d1 = (decimal)obj;
            Console.WriteLine(x.ToString());
            //Console.WriteLine(obj);
            //obj = "Hello";
            //Console.WriteLine(obj);
            //obj = 15.50m;
            //Console.WriteLine(obj);
        }
    }
}
